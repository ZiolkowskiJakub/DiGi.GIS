using DiGi.GIS.Classes;
using DiGi.GIS.Enums;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static bool IsCity(this AdministrativeSubdivisionType administrativeSubdivisionType)
        {
            return SettlementType(administrativeSubdivisionType) == Enums.SettlementType.Urban;
        }

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