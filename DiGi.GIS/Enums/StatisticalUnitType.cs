using System.ComponentModel;

namespace DiGi.GIS.Enums
{
    public enum StatisticalUnitType
    {
        [Description("country")] country,
        [Description("macroregions")] macroregions,
        [Description("voivedships")] voivedships,
        [Description("regions")] regions,
        [Description("subregions")] subregions,
        [Description("counties")] counties,
        [Description("municipalities")] municipalities,
        [Description("statistical_towns")] statistical_towns,
    }
}
