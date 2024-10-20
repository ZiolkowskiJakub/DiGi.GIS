using DiGi.BDOT10k.Enums;
using DiGi.GIS.Enums;
using System;

namespace DiGi.GIS
{
    public static partial class Convert
    {
        public static AdministrativeArealType ToDiGi(this OT_RodzajMiejscowosci oT_RodzajMiejscowosci)
        {
            return oT_RodzajMiejscowosci switch
            {
                OT_RodzajMiejscowosci.miasto => AdministrativeArealType.city,
                OT_RodzajMiejscowosci.czesc_miasta => AdministrativeArealType.part_of_city,
                OT_RodzajMiejscowosci.wies => AdministrativeArealType.village,
                OT_RodzajMiejscowosci.czesc_wsi => AdministrativeArealType.part_of_village,
                OT_RodzajMiejscowosci.kolonia => AdministrativeArealType.colony,
                OT_RodzajMiejscowosci.czesc_kolonii => AdministrativeArealType.part_of_colony,
                OT_RodzajMiejscowosci.osada => AdministrativeArealType.settlement,
                OT_RodzajMiejscowosci.czesc_osady => AdministrativeArealType.part_of_settlement,
                OT_RodzajMiejscowosci.osiedle => AdministrativeArealType.housing_estate,
                OT_RodzajMiejscowosci.przysiolek => AdministrativeArealType.hamlet,
                OT_RodzajMiejscowosci.osada_lesna => AdministrativeArealType.forest_settlement,
                OT_RodzajMiejscowosci.inny_obiekt => AdministrativeArealType.other,
                _ => throw new NotImplementedException(),
            };
        }
    }
}


