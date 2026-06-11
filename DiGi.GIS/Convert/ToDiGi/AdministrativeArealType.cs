using DiGi.BDOT10k.Enums;
using DiGi.GIS.Enums;
using System;

namespace DiGi.GIS
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts an <see cref="OT_RodzajMiejscowosci"/> enumeration value to its corresponding <see cref="AdministrativeSubdivisionType"/>.
        /// </summary>
        /// <param name="oT_RodzajMiejscowosci">The source locality type from the BDOT10k system.</param>
        /// <returns>The equivalent administrative subdivision type in the DiGi GIS system.</returns>
        public static AdministrativeSubdivisionType ToDiGi(this OT_RodzajMiejscowosci oT_RodzajMiejscowosci)
        {
            return oT_RodzajMiejscowosci switch
            {
                OT_RodzajMiejscowosci.miasto => AdministrativeSubdivisionType.city,
                OT_RodzajMiejscowosci.czesc_miasta => AdministrativeSubdivisionType.part_of_city,
                OT_RodzajMiejscowosci.wies => AdministrativeSubdivisionType.village,
                OT_RodzajMiejscowosci.czesc_wsi => AdministrativeSubdivisionType.part_of_village,
                OT_RodzajMiejscowosci.kolonia => AdministrativeSubdivisionType.colony,
                OT_RodzajMiejscowosci.czesc_kolonii => AdministrativeSubdivisionType.part_of_colony,
                OT_RodzajMiejscowosci.osada => AdministrativeSubdivisionType.settlement,
                OT_RodzajMiejscowosci.czesc_osady => AdministrativeSubdivisionType.part_of_settlement,
                OT_RodzajMiejscowosci.osiedle => AdministrativeSubdivisionType.housing_estate,
                OT_RodzajMiejscowosci.przysiolek => AdministrativeSubdivisionType.hamlet,
                OT_RodzajMiejscowosci.osada_lesna => AdministrativeSubdivisionType.forest_settlement,
                OT_RodzajMiejscowosci.inny_obiekt => AdministrativeSubdivisionType.other,
                _ => throw new NotImplementedException(),
            };
        }
    }
}