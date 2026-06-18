using DiGi.BDOT10k.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Classes;
using DiGi.GIS.Enums;

namespace DiGi.GIS
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts an <see cref="OT_ADMS_A"/> instance to a <see cref="AdministrativeSubdivision"/> instance.
        /// </summary>
        /// <param name="oT_ADMS_A">The source <see cref="OT_ADMS_A"/> object to convert.</param>
        /// <param name="guid">An optional unique identifier for the resulting <see cref="AdministrativeSubdivision"/>. If not provided, a new <see cref="System.Guid"/> will be generated.</param>
        /// <returns>A <see cref="AdministrativeSubdivision"/> instance if the source object is not null; otherwise, null.</returns>
        public static AdministrativeSubdivision? ToDiGi(this OT_ADMS_A? oT_ADMS_A, System.Guid? guid = null)
        {
            if (oT_ADMS_A == null)
            {
                return null;
            }

            if (guid == null || !guid.HasValue)
            {
                guid = System.Guid.NewGuid();
            }

            PolygonalFace2D? polygonalFace2D = oT_ADMS_A.geometria?.ToDiGi();
            string name = oT_ADMS_A.nazwa;
            uint? occupancy = oT_ADMS_A.liczbaMieszkancow;
            AdministrativeSubdivisionType? administrativeSubdivisionType = ToDiGi(oT_ADMS_A.rodzaj);
            string? reference = Query.Reference(oT_ADMS_A);
            string code = oT_ADMS_A.identyfikatorTERC;

            return new AdministrativeSubdivision(
                guid.Value,
                reference,
                code,
                polygonalFace2D,
                administrativeSubdivisionType == null || !administrativeSubdivisionType.HasValue ? AdministrativeSubdivisionType.other : administrativeSubdivisionType.Value,
                name,
                occupancy);
        }
    }
}
