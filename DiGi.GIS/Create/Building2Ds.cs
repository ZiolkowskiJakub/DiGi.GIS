using DiGi.BDOT10k.Classes;
using DiGi.BDOT10k.Enums;
using DiGi.BDOT10k.UI.Classes;
using DiGi.GIS.Classes;
using DiGi.GIS.Enums;
using DiGi.Geometry.Planar.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.GIS
{
    public static partial class Create
    {
        public static List<Building2D> Building2Ds(this SlownikObiektowGeometrycznych slownikObiektowGeometrycznych)
        {
            if (slownikObiektowGeometrycznych == null)
            {
                return null;
            }

            List<ADMS_A> aDMS_As = slownikObiektowGeometrycznych.GetObiektyGeometryczne<ADMS_A>();

            List<ADMS_A> aDMS_As_LiczbaMieszkancow = new List<ADMS_A>();
            foreach (ADMS_A aDMS_A in aDMS_As)
            {
                OT_ADMS_A oT_ADMS_A = aDMS_A?.OT_PowierzchniowyObiektGeometryczny;
                if (oT_ADMS_A == null)
                {
                    continue;
                }

                if (oT_ADMS_A.liczbaMieszkancow == null || !oT_ADMS_A.liczbaMieszkancow.HasValue || oT_ADMS_A.liczbaMieszkancow.Value == 0)
                {
                    continue;
                }

                aDMS_As_LiczbaMieszkancow.Add(aDMS_A);
            }

            List<Tuple<string, ADMS_A, List<Tuple<BUBD_A, ADMS_A>>>> tuples = new List<Tuple<string, ADMS_A, List<Tuple<BUBD_A, ADMS_A>>>>();

            List<BUBD_A> bUBD_As = slownikObiektowGeometrycznych.GetObiektyGeometryczne<BUBD_A>();
            foreach (BUBD_A bUBD_A in bUBD_As)
            {
                OT_BUBD_A oT_BUBD_A = bUBD_A.OT_PowierzchniowyObiektGeometryczny;
                if (oT_BUBD_A == null)
                {
                    continue;
                }

                ADMS_A aDMS_A = Query.ADMS_A(aDMS_As, bUBD_A);
                if (aDMS_A == null)
                {
                    continue;
                }

                ADMS_A aDMS_A_LiczbaMieszkancow = Query.ADMS_A(aDMS_As_LiczbaMieszkancow, bUBD_A);
                if (aDMS_A_LiczbaMieszkancow == null)
                {
                    continue;
                }

                string uniqueId = aDMS_A_LiczbaMieszkancow.OT_PowierzchniowyObiektGeometryczny?.identyfikatorSIMC;
                if (string.IsNullOrWhiteSpace(uniqueId))
                {
                    continue;
                }

                Tuple<string, ADMS_A, List<Tuple<BUBD_A, ADMS_A>>> tuple = tuples.Find(x => x.Item1 == uniqueId);
                if (tuple == null)
                {
                    tuple = new Tuple<string, ADMS_A, List<Tuple<BUBD_A, ADMS_A>>>(uniqueId, aDMS_A_LiczbaMieszkancow, new List<Tuple<BUBD_A, ADMS_A>>());
                    tuples.Add(tuple);
                }

                tuple.Item3.Add(new Tuple<BUBD_A, ADMS_A>(bUBD_A, aDMS_A));
            }

            List<Building2D> result = new List<Building2D>();
            foreach (Tuple<string, ADMS_A, List<Tuple<BUBD_A, ADMS_A>>> tuple in tuples)
            {
                ADMS_A aDMS_A = tuple.Item2;

                uint? liczbaMieszkancow_Temp = Query.Dwellers(aDMS_As_LiczbaMieszkancow, aDMS_A);
                if (liczbaMieszkancow_Temp == null || !liczbaMieszkancow_Temp.HasValue || liczbaMieszkancow_Temp.Value == 0)
                {
                    continue;
                }

                uint dwellings = liczbaMieszkancow_Temp.Value;

                List<BUBD_A> bUBD_As_ADMS_A = tuple.Item3.ConvertAll(x => x.Item1);

                double area = 0;
                foreach (BUBD_A bUBD_A in bUBD_As_ADMS_A)
                {
                    int liczbaKondygnacji = 1;
                    OT_BUBD_A oT_BUBD_A = bUBD_A.OT_PowierzchniowyObiektGeometryczny;
                    if (oT_BUBD_A?.liczbaKondygnacji != null && oT_BUBD_A.liczbaKondygnacji.HasValue)
                    {
                        liczbaKondygnacji = oT_BUBD_A.liczbaKondygnacji.Value;
                    }

                    area += bUBD_A.Area * liczbaKondygnacji;
                }

                double dwellingDensity = dwellings / area;

                Dictionary<BUBD_A, int> dictionary = new Dictionary<BUBD_A, int>();

                int count = 0;
                foreach (BUBD_A bUBD_A in bUBD_As_ADMS_A)
                {
                    if (count >= dwellings)
                    {
                        dictionary[bUBD_A] = 0;
                        continue;
                    }

                    int count_BUBD_A = System.Convert.ToInt32(System.Math.Floor(bUBD_A.Area * dwellingDensity));
                    if (count_BUBD_A == 0)
                    {
                        count_BUBD_A = 1;
                    }

                    if (count + count_BUBD_A > dwellings)
                    {
                        count_BUBD_A = System.Convert.ToInt32(dwellings) - count;
                    }

                    dictionary[bUBD_A] = count_BUBD_A;
                    count += count_BUBD_A;
                }

                if (count < dwellings)
                {
                    Random random = new Random((int)dwellings);

                    Core.Classes.Range<int> range = new Core.Classes.Range<int>(0, bUBD_As_ADMS_A.Count - 1);

                    while (count < dwellings)
                    {
                        int index = Core.Query.Random(random, range);
                        dictionary[bUBD_As_ADMS_A[index]]++;
                        count++;
                    }
                }

                HashSet<Guid> guids = new HashSet<Guid>();
                foreach (Tuple<BUBD_A, ADMS_A> tuple_BUBD_A in tuple.Item3)
                {
                    BUBD_A bUBD_A = tuple_BUBD_A.Item1;
                    ADMS_A aDMS_A_BUBD_A = tuple_BUBD_A.Item2;

                    OT_BUBD_A oT_BUBD_A = bUBD_A.OT_PowierzchniowyObiektGeometryczny;
                    OT_ADMS_A oT_ADMS_A_BUBD_A = aDMS_A_BUBD_A.OT_PowierzchniowyObiektGeometryczny;

                    Guid guid = Guid.NewGuid();
                    while(guids.Contains(guid))
                    {
                        guid = Guid.NewGuid();
                    }

                    guids.Add(guid);

                    PolygonalFace2D polygonalFace2D = bUBD_A.Geometry;
                    ushort storeys = oT_BUBD_A.liczbaKondygnacji == null || !oT_BUBD_A.liczbaKondygnacji.HasValue ? (ushort)1 : oT_BUBD_A.liczbaKondygnacji.Value; ;
                    string reference = Query.Reference(bUBD_A);
                    ushort occupancy = System.Convert.ToUInt16(dictionary[bUBD_A]);
                    BuildingPhase? buildingPhase = Convert.ToDiGi(oT_BUBD_A.kategoriaIstnienia);
                    BuildingGeneralFunction? buildingGeneralFunction = oT_BUBD_A.funkcjaOgolnaBudynku == null || !oT_BUBD_A.funkcjaOgolnaBudynku.HasValue ? null as BuildingGeneralFunction? : Convert.ToDiGi(oT_BUBD_A.funkcjaOgolnaBudynku.Value);

                    HashSet<BuildingSpecificFunction> buildingSpecificFunctions = new HashSet<BuildingSpecificFunction>() { Convert.ToDiGi(oT_BUBD_A.przewazajacaFunkcjaBudynku) };
                    if(oT_BUBD_A.funkcjaSzczegolowaBudynku != null)
                    {
                        foreach(OT_FunSzczegolowaBudynku oT_FunSzczegolowaBudynkuType in oT_BUBD_A.funkcjaSzczegolowaBudynku)
                        {
                            buildingSpecificFunctions.Add(Convert.ToDiGi(oT_FunSzczegolowaBudynkuType));
                        }
                    }

                    //Location location = new Location(oT_ADMS_A_BUBD_A.nazwa, Convert.ToDiGi(oT_ADMS_A_BUBD_A.rodzaj), dwellings, dwellingDensity);

                    //Building2D building2D = new Building2D(guid, reference, polygonalFace2D, storeys, occupancy, buildingPhase, buildingGeneralFunction, buildingSpecificFunctions, location);
                    //result.Add(building2D);
                }
            }

            return result;
        }

        public static List<Building2D> Building2Ds(string directory)
        {
            if(string.IsNullOrWhiteSpace(directory) || !System.IO.Directory.Exists(directory))
            {
                return null;
            }

            List<Building2D> result = new List<Building2D>();

            string[] directories = System.IO.Directory.GetDirectories(directory);
            foreach(string directory_Temp in directories)
            {
                string[] paths = System.IO.Directory.GetFiles(directory_Temp, "Building2D.json", System.IO.SearchOption.AllDirectories);
                if(paths == null)
                {
                    continue;
                }

                foreach(string path in paths)
                {
                    Building2D building2D = Core.Convert.ToDiGi<Building2D>((Core.Classes.Path?)path)?.FirstOrDefault();
                    if(building2D == null)
                    {
                        continue;
                    }
                }
            }

            return result;
        }
    }
}
