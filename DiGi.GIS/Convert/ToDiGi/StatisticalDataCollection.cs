using DiGi.BDL.Classes;
using DiGi.GIS.Classes;

namespace DiGi.GIS
{
    public static partial class Convert
    {
        public static StatisticalDataCollection ToDiGi(this UnitYearlyValues unitYearlyValues)
        {
            UnitCode unitCode = Create.UnitCode(unitYearlyValues?.unitId);
            if(unitCode == null)
            {
                return null;
            }

            StatisticalDataCollection result = new StatisticalDataCollection(System.Guid.NewGuid(), unitCode);
            result.AddRange(unitYearlyValues);

            return result;
        }
    }
}
