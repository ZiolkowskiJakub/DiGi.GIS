using DiGi.GIS.Classes;
using DiGi.GIS.Enums;

namespace DiGi.GIS
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether the specified administrative subdivision type represents a city.
        /// </summary>
        /// <param name="administrativeSubdivisionType">The administrative subdivision type to evaluate.</param>
        /// <returns>True if the administrative subdivision type is urban; otherwise, false.</returns>
        public static bool IsCity(this AdministrativeSubdivisionType administrativeSubdivisionType)
        {
            return SettlementType(administrativeSubdivisionType) == Enums.SettlementType.Urban;
        }

        /// <summary>
        /// Determines whether the specified administrative subdivision represents a city.
        /// </summary>
        /// <param name="administrativeSubdivision">The administrative subdivision to evaluate.</param>
        /// <returns>True if the administrative subdivision is not null and its type is urban; otherwise, false.</returns>
        public static bool IsCity(this AdministrativeSubdivision administrativeSubdivision)
        {
            if (administrativeSubdivision is null)
            {
                return false;
            }

            return IsCity(administrativeSubdivision.AdministrativeSubdivisionType);
        }
    }
}