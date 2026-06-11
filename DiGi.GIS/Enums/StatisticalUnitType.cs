using System.ComponentModel;

namespace DiGi.GIS.Enums
{
    /// <summary>
    /// Specifies the types of statistical units used for geographical and administrative data categorization.
    /// </summary>
    public enum StatisticalUnitType
    {
        /// <summary>
        /// Represents a country-level statistical unit.
        /// </summary>
        [Description("country")] country,

        /// <summary>
        /// Represents a macro-region level statistical unit.
        /// </summary>
        [Description("macroregions")] macroregions,

        /// <summary>
        /// Represents a voivodeship (provincial) level statistical unit.
        /// </summary>
        [Description("voivedships")] voivedships,

        /// <summary>
        /// Represents a region level statistical unit.
        /// </summary>
        [Description("regions")] regions,

        /// <summary>
        /// Represents a sub-region level statistical unit.
        /// </summary>
        [Description("subregions")] subregions,

        /// <summary>
        /// Represents a county level statistical unit.
        /// </summary>
        [Description("counties")] counties,

        /// <summary>
        /// Represents a municipality level statistical unit.
        /// </summary>
        [Description("municipalities")] municipalities,

        /// <summary>
        /// Represents a statistical town level statistical unit.
        /// </summary>
        [Description("statistical_towns")] statistical_towns,
    }
}