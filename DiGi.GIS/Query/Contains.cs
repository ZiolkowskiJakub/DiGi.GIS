using DiGi.BDL.Enums;
using DiGi.GIS.Classes;
using DiGi.GIS.Interfaces;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static bool Contains(this StatisticalDataCollection statisticalDataCollection, Variable variable)
        {
            if (statisticalDataCollection == null)
            {
                return false;
            }

            string reference = ((int)variable).ToString();

            IStatisticalData statisticalData = statisticalDataCollection.Find<IStatisticalData>(x => x.Reference == reference);

            return statisticalData != null;
        }
    }
}