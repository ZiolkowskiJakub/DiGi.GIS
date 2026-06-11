using DiGi.BDL.Enums;
using DiGi.GIS.Classes;
using DiGi.GIS.Interfaces;

namespace DiGi.GIS
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether the specified statistical data collection contains a record associated with the provided variable.
        /// </summary>
        /// <param name="statisticalDataCollection">The statistical data collection to search.</param>
        /// <param name="variable">The variable used as a reference for searching within the collection.</param>
        /// <returns>True if the collection contains a record matching the variable's reference; otherwise, false.</returns>
        public static bool Contains(this StatisticalDataCollection statisticalDataCollection, Variable variable)
        {
            if (statisticalDataCollection == null)
            {
                return false;
            }

            string reference = ((int)variable).ToString();

            IStatisticalData? statisticalData = statisticalDataCollection.Find<IStatisticalData>(x => x?.Reference == reference);

            return statisticalData != null;
        }
    }
}