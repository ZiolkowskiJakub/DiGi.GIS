using DiGi.BDOT10k.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Classes;
using DiGi.GIS.Enums;

namespace DiGi.GIS
{
    public static partial class Convert
    {
        public static AdministrativeSubdivision ToDiGi(this OT_ADMS_A oT_ADMS_A, System.Guid? guid = null)
        {
            if (oT_ADMS_A == null)
            {
                return null;
            }

            if (guid == null || !guid.HasValue)
            {
                guid = System.Guid.NewGuid();
            }

            PolygonalFace2D polygonalFace2D = oT_ADMS_A.geometria?.ToDiGi();
            string name = oT_ADMS_A.nazwa;
            uint? occupancy = oT_ADMS_A.liczbaMieszkancow;
            AdministrativeSubdivisionType? administrativeSubdivisionType = ToDiGi(oT_ADMS_A.rodzaj);

            string reference = Query.Reference(oT_ADMS_A);

            return new AdministrativeSubdivision(
                guid.Value, 
                reference, 
                polygonalFace2D, 
                administrativeSubdivisionType == null || !administrativeSubdivisionType.HasValue ? AdministrativeSubdivisionType.other : administrativeSubdivisionType.Value, 
                name, 
                occupancy);
        }
    }
}


