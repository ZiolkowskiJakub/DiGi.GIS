using DiGi.BDL.Enums;
using DiGi.GIS.Classes;
using DiGi.GIS.Interfaces;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static TStatisticalData StatisticalData<TStatisticalData>(this StatisticalDataCollection statisticalDataCollection, Variable variable) where TStatisticalData : IStatisticalData
        {
            if (statisticalDataCollection == null)
            {
                return default;
            }

            return statisticalDataCollection.Find<TStatisticalData>(x => x.Reference == ((int)variable).ToString());

        }
    }
}



