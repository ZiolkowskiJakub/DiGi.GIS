using DiGi.BDOT10k.Classes;
using DiGi.BDOT10k.Enums;
using DiGi.BDOT10k.UI.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Classes;
using DiGi.GIS.Enums;
using DiGi.GIS.Interfaces;
using System;
using System.Collections.Generic;


namespace DiGi.GIS
{
    public static partial class Convert
    {
        public static GISModel ToDiGi(this SlownikObiektowGeometrycznych slownikObiektowGeometrycznych, ISource source = null)
        {
            if(slownikObiektowGeometrycznych == null)
            {
                return null;
            }

            GISModel result = new GISModel(source);

            List<ADMS_A> aDMS_As = slownikObiektowGeometrycznych.GetObiektyGeometryczne<ADMS_A>();
            if(aDMS_As != null)
            {
                foreach(ADMS_A aDMS_A in aDMS_As)
                {
                    OT_ADMS_A oT_ADMS_A = aDMS_A?.OT_PowierzchniowyObiektGeometryczny;
                    if (oT_ADMS_A == null)
                    {
                        continue;
                    }

                    Guid guid = result.GetNewGuid<AdministrativeAreal2D>();

                    PolygonalFace2D polygonalFace2D = aDMS_A.Geometry;
                    string name = oT_ADMS_A.nazwa;
                    uint? occupancy = oT_ADMS_A.liczbaMieszkancow;
                    AdministrativeArealType? administrativeArealType = ToDiGi(oT_ADMS_A.rodzaj);

                    string reference = Query.Reference(aDMS_A);

                    AdministrativeAreal2D administrativeAreal2D = new AdministrativeAreal2D(guid, reference, polygonalFace2D, administrativeArealType == null || !administrativeArealType.HasValue ? AdministrativeArealType.other : administrativeArealType.Value, name, occupancy);
                    result.Update(administrativeAreal2D);
                }
            }

            List<BUBD_A> bUBD_As = slownikObiektowGeometrycznych.GetObiektyGeometryczne<BUBD_A>();
            if(bUBD_As != null)
            {
                foreach(BUBD_A bUBD_A in bUBD_As)
                {
                    OT_BUBD_A oT_BUBD_A = bUBD_A?.OT_PowierzchniowyObiektGeometryczny;
                    if (oT_BUBD_A == null)
                    {
                        continue;
                    }

                    Guid guid = result.GetNewGuid<Building2D>();

                    PolygonalFace2D polygonalFace2D = bUBD_A.Geometry;
                    ushort storeys = oT_BUBD_A.liczbaKondygnacji == null || !oT_BUBD_A.liczbaKondygnacji.HasValue ? (ushort)1 : oT_BUBD_A.liczbaKondygnacji.Value; ;
                    string reference = Query.Reference(bUBD_A);
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

                    Building2D building2D = new Building2D(guid, reference, polygonalFace2D, storeys, buildingPhase, buildingGeneralFunction, buildingSpecificFunctions);
                    result.Update(building2D);
                }
            }

            return result;
        }
    }
}


