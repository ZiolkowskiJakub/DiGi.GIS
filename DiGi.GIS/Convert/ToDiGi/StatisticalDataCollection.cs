using DiGi.BDL.Classes;
using DiGi.GIS.Classes;

namespace DiGi.GIS
{
    public static partial class Convert
    {
        public static StatisticalDataCollection ToDiGi(this UnitYearlyValues unitYearlyValues)
        {
            if (unitYearlyValues == null)
            {
                return null;
            }

            if(string.IsNullOrWhiteSpace(unitYearlyValues.unitId))
            {
                return null;
            }

            StatisticalDataCollection result = new StatisticalDataCollection(System.Guid.NewGuid(), unitYearlyValues.unitId);
            result.AddRange(unitYearlyValues);

            return result;
        }
    }
}
