using System.ComponentModel;

namespace DiGi.GIS.Enums
{
    /// <summary>
    /// Specifies the types of administrative subdivisions used to categorize geographic areas.
    /// </summary>
    public enum AdministrativeSubdivisionType
    {
        /// <summary>
        /// Represents a city.
        /// </summary>
        [Description("city")]
        city,

        /// <summary>
        /// Represents part of a city.
        /// </summary>
        [Description("part of a city")]
        part_of_city,

        /// <summary>
        /// Represents a village.
        /// </summary>
        [Description("village")]
        village,

        /// <summary>
        /// Represents part of a village.
        /// </summary>
        [Description("part of a village")]
        part_of_village,

        /// <summary>
        /// Represents a colony.
        /// </summary>
        [Description("colony")]
        colony,

        /// <summary>
        /// Represents part of a colony.
        /// </summary>
        [Description("part of a colony")]
        part_of_colony,

        /// <summary>
        /// Represents a settlement.
        /// </summary>
        [Description("settlement")]
        settlement,

        /// <summary>
        /// Represents part of a settlement.
        /// </summary>
        [Description("part of a settlement")]
        part_of_settlement,

        /// <summary>
        /// Represents a housing estate.
        /// </summary>
        [Description("housing estate")]
        housing_estate,

        /// <summary>
        /// Represents a hamlet.
        /// </summary>
        [Description("hamlet")]
        hamlet,

        /// <summary>
        /// Represents a forest settlement.
        /// </summary>
        [Description("forest settlement")]
        forest_settlement,

        /// <summary>
        /// Represents other types of administrative subdivisions.
        /// </summary>
        [Description("other")]
        other,
    }
}