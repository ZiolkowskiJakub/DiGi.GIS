using DiGi.GIS.Classes;
using DiGi.GIS.Enums;
using System;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Query
    {
        /// <summary>
        /// Returns the most frequent user-entered year built across every user entry stored in the given year built data.
        /// <para>Only entries recorded as an exact year take part in the count; entries recorded as a bound (at or before, after) are bounds rather than years and are skipped. The year with the greatest count wins; a count tie goes to the year whose newest entry is the most recent, a missing timestamp counting as the oldest, and two years sharing both count and recency to the greater year, so a re-run that stores one more entry is answered deterministically.</para>
        /// </summary>
        /// <param name="yearBuiltDatas">The stored year built data of one building, or null.</param>
        /// <returns>The most frequent exact user entry, or null when none is stored.</returns>
        public static UserYearBuilt? MostFrequentUserYearBuilt(this IEnumerable<YearBuiltData>? yearBuiltDatas)
        {
            if (yearBuiltDatas is null)
            {
                return null;
            }

            Dictionary<short, int> countByYear = [];
            Dictionary<short, UserYearBuilt> newestByYear = [];

            foreach (YearBuiltData? yearBuiltData in yearBuiltDatas)
            {
                UserYearBuilt? userYearBuilt = yearBuiltData?.GetUserYearBuilt();
                if (userYearBuilt is null || userYearBuilt.YearBuiltRelation != YearBuiltRelation.Exact)
                {
                    continue;
                }

                countByYear.TryGetValue(userYearBuilt.Year, out int count);
                countByYear[userYearBuilt.Year] = count + 1;

                if (!newestByYear.TryGetValue(userYearBuilt.Year, out UserYearBuilt? newest) || newest is null || CompareTimestamps(userYearBuilt.DateTime, newest.DateTime) > 0)
                {
                    newestByYear[userYearBuilt.Year] = userYearBuilt;
                }
            }

            if (countByYear.Count == 0)
            {
                return null;
            }

            int bestCount = -1;
            DateTimeOffset? bestDateTime = null;
            short bestYear = default;
            bool found = false;

            foreach (KeyValuePair<short, int> keyValuePair in countByYear)
            {
                UserYearBuilt newest = newestByYear[keyValuePair.Key];

                if (!found
                    || keyValuePair.Value > bestCount
                    || (keyValuePair.Value == bestCount && CompareTimestamps(newest.DateTime, bestDateTime) > 0)
                    || (keyValuePair.Value == bestCount && CompareTimestamps(newest.DateTime, bestDateTime) == 0 && keyValuePair.Key > bestYear))
                {
                    found = true;
                    bestCount = keyValuePair.Value;
                    bestDateTime = newest.DateTime;
                    bestYear = keyValuePair.Key;
                }
            }

            return newestByYear[bestYear];

            //A missing timestamp sorts oldest, so a legacy entry without provenance loses to any dated one
            int CompareTimestamps(DateTimeOffset? dateTime, DateTimeOffset? dateTime_Other)
            {
                if (dateTime is null && dateTime_Other is null)
                {
                    return 0;
                }

                if (dateTime is null)
                {
                    return -1;
                }

                if (dateTime_Other is null)
                {
                    return 1;
                }

                return dateTime.Value.CompareTo(dateTime_Other.Value);
            }
        }
    }
}
