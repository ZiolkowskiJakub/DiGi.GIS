using DiGi.BDOT10k.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Classes;
using DiGi.GIS.Enums;

namespace DiGi.GIS
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts an <see cref="OT_ADJA_A"/> object to a <see cref="AdministrativeDivision"/> instance.
        /// </summary>
        /// <param name="oT_ADJA_A">The source <see cref="OT_ADJA_A"/> object to convert.</param>
        /// <param name="guid">An optional <see cref="System.Guid"/> to assign as the identifier for the resulting administrative division. If null, a new GUID will be generated.</param>
        /// <returns>The converted <see cref="AdministrativeDivision"/> instance, or null if the source object is null.</returns>
        public static AdministrativeDivision? ToDiGi(this OT_ADJA_A? oT_ADJA_A, System.Guid? guid = null)
        {
            if (oT_ADJA_A == null)
            {
                return null;
            }

            if (guid == null || !guid.HasValue)
            {
                guid = System.Guid.NewGuid();
            }

            PolygonalFace2D? polygonalFace2D = oT_ADJA_A.geometria?.ToDiGi();
            string name = oT_ADJA_A.nazwa;
            AdministrativeDivisionType? administrativeDivisionType = ToDiGi(oT_ADJA_A.rodzaj);
            string? reference = Query.Reference(oT_ADJA_A);
            string code = oT_ADJA_A.identyfikatorTERYTjednostki;

            #region Temporary fix for invalid code -> 1004 (0410)

            //Temporary solution for bug in identyfikatorTERYTjednostki PL.PZGiK.994.0410__OT_ADJA_A.xml is 1004 for powiat nakielski and should be 0410. This code should be removed after fixing the bug in BDO TERYT data.

            // SAMPLES:

            //Valid:
            //<ot:identyfikatorPRG>1002010520</ot:identyfikatorPRG>
            //<ot:identyfikatorTERYTjednostki>0201052</ot:identyfikatorTERYTjednostki>
            //<ot:idTERYTjednostkiNadrzednej>0201</ot:idTERYTjednostkiNadrzednej>

            //Invalid:
            //<ot:identyfikatorPRG>100410</ot:identyfikatorPRG>
            //<ot:identyfikatorTERYTjednostki>1004</ot:identyfikatorTERYTjednostki>
            //<ot:idTERYTjednostkiNadrzednej>04</ot:idTERYTjednostkiNadrzednej>

            if (!string.IsNullOrWhiteSpace(code))
            {
                string? parentCode = oT_ADJA_A.idTERYTjednostkiNadrzednej;
                if (!string.IsNullOrWhiteSpace(parentCode))
                {
                    if (!code.StartsWith(parentCode))
                    {
                        if (oT_ADJA_A.identyfikatorPRG is string pRG && !string.IsNullOrWhiteSpace(pRG) && pRG.Length >= code.Length + 2)
                        {
                            code = pRG.Substring(2, code.Length);
                            if (!code.StartsWith(parentCode))
                            {
                                throw new System.Exception($"Code {code} does not start with parent code {parentCode} for OT_ADJA_A with id {oT_ADJA_A.id}");
                            }
                        }
                    }
                }
            }

            #endregion Temporary fix for invalid code -> 1004 (0410)

            return new AdministrativeDivision(
                guid.Value,
                reference,
                code,
                polygonalFace2D,
                administrativeDivisionType.Value,
                name);
        }
    }
}
