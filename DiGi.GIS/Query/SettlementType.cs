using DiGi.GIS.Classes;
using DiGi.GIS.Enums;

namespace DiGi.GIS
{
    public static partial class Query
    {
        /// <summary>
        /// Maps an administrative subdivision type to a settlement type.
        /// </summary>
        /// <param name="administrativeSubdivisionType">The administrative subdivision type to convert.</param>
        /// <returns>The corresponding <see cref="DiGi.GIS.Enums.SettlementType"/>.</returns>
        public static SettlementType SettlementType(this AdministrativeSubdivisionType administrativeSubdivisionType)
        {
            switch(administrativeSubdivisionType)
            {
                case AdministrativeSubdivisionType.city:
                case AdministrativeSubdivisionType.part_of_city:
                    return Enums.SettlementType.Urban;

                case AdministrativeSubdivisionType.other:
                    return Enums.SettlementType.Undefined;

                default:
                    return Enums.SettlementType.Rural;
            }
        }

        /// <summary>
        /// Maps an administrative subdivision object to a settlement type based on its type property.
        /// </summary>
        /// <param name="administrativeSubdivision">The administrative subdivision instance.</param>
        /// <returns>The corresponding <see cref="DiGi.GIS.Enums.SettlementType"/>.</returns>
        public static SettlementType SettlementType(this AdministrativeSubdivision administrativeSubdivision)
        {
            if (administrativeSubdivision is null)
            {
                return Enums.SettlementType.Undefined;
            }

            return SettlementType(administrativeSubdivision.AdministrativeSubdivisionType);
        }
    }
}