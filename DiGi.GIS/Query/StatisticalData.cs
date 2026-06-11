using DiGi.BDL.Enums;
using DiGi.GIS.Classes;
using DiGi.GIS.Interfaces;

namespace DiGi.GIS
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves a specific statistical data item from the collection based on the provided variable.
        /// </summary>
        /// <typeparam name="TStatisticalData">The type of statistical data to retrieve, which must implement <see cref="IStatisticalData"/>.</typeparam>
        /// <param name="statisticalDataCollection">The collection of statistical data to search within.</param>
        /// <param name="variable">The variable used as a reference key to find the specific statistical data item.</param>
        /// <returns>The found statistical data item of type <typeparamref name="TStatisticalData"/>, or default if not found or if the collection is null.</returns>
        public static TStatisticalData? StatisticalData<TStatisticalData>(this StatisticalDataCollection? statisticalDataCollection, Variable variable) where TStatisticalData : IStatisticalData
        {
            if (statisticalDataCollection == null)
            {
                return default;
            }

            return statisticalDataCollection.Find<TStatisticalData>(x => x?.Reference == ((int)variable).ToString());
        }
    }
}