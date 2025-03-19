using System.ComponentModel;

namespace DiGi.GIS.Enums
{
    public enum MunicipalityType
    {
        [Description("rural municipality")] rural_municipality,
        [Description("urban municipality")] urban_municipality,
        [Description("urban-rural municipality")] urban_rural_municipality,
        [Description("urban-rural municipality town")] urban_rural_municipality_town,
        [Description("urban-rural municipality rural area")] urban_rural_municipality_rural_area,
        [Description("Warsaw district")] Warsaw_district,
    }
}
