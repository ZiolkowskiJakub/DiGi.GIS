using DiGi.BDOT10k.Classes;
using DiGi.BDOT10k.Enums;
using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Classes;
using DiGi.GIS.Enums;
using System;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts an <see cref="OT_BUBD_A"/> object to a <see cref="Building2D"/> object.
        /// </summary>
        /// <param name="oT_BUBD_A">The source <see cref="OT_BUBD_A"/> object to convert.</param>
        /// <returns>A <see cref="Building2D"/> instance if the input is not null; otherwise, null.</returns>
        public static Building2D? ToDiGi(this OT_BUBD_A? oT_BUBD_A)
        {
            if (oT_BUBD_A is null)
            {
                return null;
            }

            PolygonalFace2D? polygonalFace2D = oT_BUBD_A?.geometria?.ToDiGi();
            ushort storeys = oT_BUBD_A?.liczbaKondygnacji == null || !oT_BUBD_A.liczbaKondygnacji.HasValue ? (ushort)1 : oT_BUBD_A.liczbaKondygnacji.Value;
            string? reference = Query.Reference(oT_BUBD_A);
            BuildingPhase? buildingPhase = ToDiGi(oT_BUBD_A!.kategoriaIstnienia);
            BuildingGeneralFunction? buildingGeneralFunction = oT_BUBD_A.funkcjaOgolnaBudynku == null || !oT_BUBD_A.funkcjaOgolnaBudynku.HasValue ? null : ToDiGi(oT_BUBD_A.funkcjaOgolnaBudynku.Value);

            HashSet<BuildingSpecificFunction> buildingSpecificFunctions = [ToDiGi(oT_BUBD_A.przewazajacaFunkcjaBudynku)];
            if (oT_BUBD_A.funkcjaSzczegolowaBudynku != null)
            {
                foreach (OT_FunSzczegolowaBudynku oT_FunSzczegolowaBudynkuType in oT_BUBD_A.funkcjaSzczegolowaBudynku)
                {
                    buildingSpecificFunctions.Add(ToDiGi(oT_FunSzczegolowaBudynkuType));
                }
            }

            return new Building2D(
                Guid.NewGuid(),
                reference,
                polygonalFace2D,
                storeys,
                buildingPhase,
                buildingGeneralFunction,
                buildingSpecificFunctions);
        }
    }
}