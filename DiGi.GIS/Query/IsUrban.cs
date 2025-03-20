using DiGi.GIS.Enums;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static bool IsUrban(this MunicipalityType municipalityType)
        {
            return municipalityType != Enums.MunicipalityType.rural_municipality && municipalityType != Enums.MunicipalityType.urban_rural_municipality_rural_area;
        }
    }
}



