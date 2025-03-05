using System.ComponentModel;

namespace DiGi.GIS.Enums
{
    public enum AdministrativeDivisionType
    {
        [Description("country")] country,
        [Description("voivodeship (province)")] voivodeship,
        [Description("county (powiat)")] county,
        [Description("municipality (gmina)")] municipality,
        [Description("town in an urban-rural municipality")] town_in_urban_rural_municipality,
        [Description("district or delegation")] district_or_delegation,
    }
}
