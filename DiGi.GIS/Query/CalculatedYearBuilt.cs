using DiGi.GIS.Classes;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Query
    {
        /// <summary>
        /// Returns the year built to use for a building: the user-entered year when one exists, otherwise the predicted year.
        /// <para>The user year takes part only when one was recorded as an exact year, so a building whose user entries are bounds alone falls through to the prediction. Neither holding a value answers null, so a caller leaves the column it would write as it stood.</para>
        /// </summary>
        /// <param name="yearBuiltDatas">The stored year built data of one building, or null.</param>
        /// <returns>The user year when one exists, otherwise the predicted year, otherwise null.</returns>
        public static short? CalculatedYearBuilt(this IEnumerable<YearBuiltData>? yearBuiltDatas)
        {
            UserYearBuilt? userYearBuilt = MostFrequentUserYearBuilt(yearBuiltDatas);
            if (userYearBuilt is not null)
            {
                return userYearBuilt.Year;
            }

            PredictedYearBuilt? predictedYearBuilt = MostFrequentPredictedYearBuilt(yearBuiltDatas);
            return predictedYearBuilt?.Year;
        }
    }
}
