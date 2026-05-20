using DiGi.GIS.Classes;
using DiGi.GIS.Enums;

namespace DiGi.GIS
{
    public static partial class Query
    {
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