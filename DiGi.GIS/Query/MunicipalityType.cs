using DiGi.GIS.Classes;
using DiGi.GIS.Enums;
using System.Linq;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static MunicipalityType? MunicipalityType(this UnitCode unitCode)
        {
            if(unitCode == null || unitCode.GetStatisticalUnitType() != StatisticalUnitType.municipalities)
            {
                return null;
            }

            switch(unitCode.Code.Last())
            {
                case '1':
                    return Enums.MunicipalityType.urban_municipality;

                case '2':
                    return Enums.MunicipalityType.rural_municipality;

                case '3':
                    return Enums.MunicipalityType.urban_rural_municipality;

                case '4':
                    return Enums.MunicipalityType.urban_rural_municipality_town;

                case '5':
                    return Enums.MunicipalityType.urban_rural_municipality_rural_area;

                case '8':
                    return Enums.MunicipalityType.Warsaw_district;
            }

            return null;
        }

        public static MunicipalityType? MunicipalityType(this StatisticalUnit statisticalUnit)
        {
            return MunicipalityType(statisticalUnit?.UnitCode);
        }

        //public static MunicipalityType MunicipalityType(this AdministrativeSubdivisionType administrativeSubdivisionType)
        //{
        //    switch(administrativeSubdivisionType)
        //    {
        //        case AdministrativeSubdivisionType.city:
        //        case AdministrativeSubdivisionType.part_of_city:
        //            return Enums.MunicipalityType.urban;

        //        default:
        //            return Enums.MunicipalityType.rural;
        //    }
        //}
    }
}



