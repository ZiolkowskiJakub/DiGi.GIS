using DiGi.BDOT10k.Enums;
using DiGi.GIS.Enums;
using System;

namespace DiGi.GIS
{
    public static partial class Convert
    {
        public static LocationType ToDiGi(this OT_RodzajMiejscowosci oT_RodzajMiejscowosci)
        {
            switch (oT_RodzajMiejscowosci)
            {
                case OT_RodzajMiejscowosci.miasto:
                    return LocationType.city;
                case OT_RodzajMiejscowosci.czesc_miasta:
                    return LocationType.part_of_city;
                case OT_RodzajMiejscowosci.wies:
                    return LocationType.village;
                case OT_RodzajMiejscowosci.czesc_wsi:
                    return LocationType.part_of_village;
                case OT_RodzajMiejscowosci.kolonia:
                    return LocationType.colony;
                case OT_RodzajMiejscowosci.czesc_kolonii:
                    return LocationType.part_of_colony;
                case OT_RodzajMiejscowosci.osada:
                    return LocationType.settlement;
                case OT_RodzajMiejscowosci.czesc_osady:
                    return LocationType.part_of_settlement;
                case OT_RodzajMiejscowosci.osiedle:
                    return LocationType.housing_estate;
                case OT_RodzajMiejscowosci.przysiolek:
                    return LocationType.hamlet;
                case OT_RodzajMiejscowosci.osada_lesna:
                    return LocationType.forest_settlement;
                case OT_RodzajMiejscowosci.inny_obiekt:
                    return LocationType.other_object;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}


