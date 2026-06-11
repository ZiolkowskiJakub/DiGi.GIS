using System.ComponentModel;

namespace DiGi.GIS.Enums
{
    /// <summary>
    /// Specifies the type of administrative division.
    /// </summary>
    public enum AdministrativeDivisionType
    {
        /// <summary>
        /// Represents a country level administrative division.
        /// </summary>
        [Description("country")] country,

        /// <summary>
        /// Represents a voivodeship (province) level administrative division.
        /// </summary>
        [Description("voivodeship (province)")] voivodeship,

        /// <summary>
        /// Represents a county (powiat) level administrative division.
        /// </summary>
        [Description("county (powiat)")] county,

        /// <summary>
        /// Represents a municipality (gmina) level administrative division.
        /// </summary>
        [Description("municipality (gmina)")] municipality,

        /// <summary>
        /// Represents a town located within an urban-rural municipality.
        /// </summary>
        [Description("town in an urban-rural municipality")] town_in_urban_rural_municipality,

        /// <summary>
        /// Represents a district or delegation level administrative division.
        /// </summary>
        [Description("district or delegation")] district_or_delegation,
    }
}