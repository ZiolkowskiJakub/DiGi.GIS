using DiGi.BDOT10k.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Classes;
using DiGi.GIS.Enums;

namespace DiGi.GIS
{
    public static partial class Convert
    {
        public static AdministrativeDivision ToDiGi(this OT_ADJA_A oT_ADJA_A, System.Guid? guid = null)
        {
            if (oT_ADJA_A == null)
            {
                return null;
            }

            if (guid == null || !guid.HasValue)
            {
                guid = System.Guid.NewGuid();
            }

            PolygonalFace2D polygonalFace2D = oT_ADJA_A.geometria?.ToDiGi();
            string name = oT_ADJA_A.nazwa;
            AdministrativeDivisionType? administrativeDivisionType = ToDiGi(oT_ADJA_A.rodzaj);

            string reference = Query.Reference(oT_ADJA_A);

            return new AdministrativeDivision(
                guid.Value, 
                reference, 
                polygonalFace2D, 
                administrativeDivisionType.Value, 
                name);
        }
    }
}


