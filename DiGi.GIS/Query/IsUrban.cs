using DiGi.GIS.Enums;

namespace DiGi.GIS
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether the specified municipality type is considered urban.
        /// </summary>
        /// <param name="municipalityType">The municipality type to evaluate.</param>
        /// <returns>True if the municipality type is urban; otherwise, false.</returns>
        public static bool IsUrban(this MunicipalityType municipalityType)
        {
            return municipalityType != Enums.MunicipalityType.rural_municipality && municipalityType != Enums.MunicipalityType.urban_rural_municipality_rural_area;
        }
    }
}