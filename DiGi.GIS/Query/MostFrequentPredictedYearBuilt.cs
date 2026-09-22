using DiGi.GIS.Classes;
using System;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Query
    {
        /// <summary>
        /// Returns the most frequent predicted year built across every prediction stored in the given year built data.
        /// <para>A building may hold several stored records, each carrying several predictions, so the count spans every prediction of every record. The year with the greatest count wins; a count tie goes to the year whose newest prediction is the most recent, and two years sharing both count and recency to the greater year, so a re-run that stores one more prediction is answered deterministically.</para>
        /// <para>Two stored records are two votes by design, so a re-run that stores a second record for the building is a second opinion rather than a duplicate.</para>
        /// </summary>
        /// <param name="yearBuiltDatas">The stored year built data of one building, or null.</param>
        /// <returns>The most frequent prediction, or null when no prediction is stored.</returns>
        public static PredictedYearBuilt? MostFrequentPredictedYearBuilt(this IEnumerable<YearBuiltData>? yearBuiltDatas)
        {
            if (yearBuiltDatas is null)
            {
                return null;
            }

            Dictionary<short, int> countByYear = [];
            Dictionary<short, PredictedYearBuilt> newestByYear = [];

            foreach (YearBuiltData? yearBuiltData in yearBuiltDatas)
            {
                List<PredictedYearBuilt>? predictedYearBuilts = yearBuiltData?.GetPredictedYearBuilts();
                if (predictedYearBuilts is null)
                {
                    continue;
                }

                foreach (PredictedYearBuilt predictedYearBuilt in predictedYearBuilts)
                {
                    countByYear.TryGetValue(predictedYearBuilt.Year, out int count);
                    countByYear[predictedYearBuilt.Year] = count + 1;

                    if (!newestByYear.TryGetValue(predictedYearBuilt.Year, out PredictedYearBuilt? newest) || newest is null || predictedYearBuilt.DateTime > newest.DateTime)
                    {
                        newestByYear[predictedYearBuilt.Year] = predictedYearBuilt;
                    }
                }
            }

            if (countByYear.Count == 0)
            {
                return null;
            }

            int bestCount = -1;
            DateTime bestDateTime = default;
            short bestYear = default;
            bool found = false;

            foreach (KeyValuePair<short, int> keyValuePair in countByYear)
            {
                PredictedYearBuilt newest = newestByYear[keyValuePair.Key];

                if (!found
                    || keyValuePair.Value > bestCount
                    || (keyValuePair.Value == bestCount && newest.DateTime > bestDateTime)
                    || (keyValuePair.Value == bestCount && newest.DateTime == bestDateTime && keyValuePair.Key > bestYear))
                {
                    found = true;
                    bestCount = keyValuePair.Value;
                    bestDateTime = newest.DateTime;
                    bestYear = keyValuePair.Key;
                }
            }

            return newestByYear[bestYear];
        }
    }
}
