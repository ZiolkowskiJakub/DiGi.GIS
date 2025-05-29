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
        public static Building2D ToDiGi(this OT_BUBD_A oT_BUBD_A)
        {
            PolygonalFace2D polygonalFace2D = oT_BUBD_A.geometria?.ToDiGi();
            ushort storeys = oT_BUBD_A.liczbaKondygnacji == null || !oT_BUBD_A.liczbaKondygnacji.HasValue ? (ushort)1 : oT_BUBD_A.liczbaKondygnacji.Value; ;
            string reference = Query.Reference(oT_BUBD_A);
            BuildingPhase? buildingPhase = ToDiGi(oT_BUBD_A.kategoriaIstnienia);
            BuildingGeneralFunction? buildingGeneralFunction = oT_BUBD_A.funkcjaOgolnaBudynku == null || !oT_BUBD_A.funkcjaOgolnaBudynku.HasValue ? null as BuildingGeneralFunction? : ToDiGi(oT_BUBD_A.funkcjaOgolnaBudynku.Value);

            HashSet<BuildingSpecificFunction> buildingSpecificFunctions = new HashSet<BuildingSpecificFunction>() { ToDiGi(oT_BUBD_A.przewazajacaFunkcjaBudynku) };
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


