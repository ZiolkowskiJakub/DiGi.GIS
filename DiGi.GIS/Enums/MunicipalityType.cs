using System.ComponentModel;

namespace DiGi.GIS.Enums
{
    /// <summary>
    /// Specifies the type of municipality.
    /// </summary>
    public enum MunicipalityType
    {
        /// <summary>
        /// Represents a rural municipality.
        /// </summary>
        [Description("rural municipality")] rural_municipality,

        /// <summary>
        /// Represents an urban municipality.
        /// </summary>
        [Description("urban municipality")] urban_municipality,

        /// <summary>
        /// Represents an urban-rural municipality.
        /// </summary>
        [Description("urban-rural municipality")] urban_rural_municipality,

        /// <summary>
        /// Represents an urban-rural municipality town.
        /// </summary>
        [Description("urban-rural municipality town")] urban_rural_municipality_town,

        /// <summary>
        /// Represents an urban-rural municipality rural area.
        /// </summary>
        [Description("urban-rural municipality rural area")] urban_rural_municipality_rural_area,

        /// <summary>
        /// Represents a Warsaw district.
        /// </summary>
        [Description("Warsaw district")] Warsaw_district,
    }
}