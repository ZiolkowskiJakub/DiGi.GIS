using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using ProjNet.CoordinateSystems;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;

namespace DiGi.GIS
{
    public static partial class Modify
    {
        public static void CalculateOccupancy(this GISModel gISModel, double tolerance = Core.Constans.Tolerance.Distance)
        {
            if(gISModel == null)
            {
                return;
            }

            List<Tuple<AdministrativeAreal2D, AdministrativeAreal2DGeometryCalculationResult>> tuples_AdministrativeAreal2D = new List<Tuple<AdministrativeAreal2D, AdministrativeAreal2DGeometryCalculationResult>>();

            List<AdministrativeAreal2D> administrativeAreal2Ds = gISModel?.GetObjects<AdministrativeAreal2D>();
            if (administrativeAreal2Ds != null)
            {
                foreach (AdministrativeAreal2D administrativeAreal2D in administrativeAreal2Ds)
                {
                    if (administrativeAreal2D == null)
                    {
                        continue;
                    }

                    AdministrativeAreal2DGeometryCalculationResult administrativeAreal2DGeometryCalculationResult = gISModel.GetRelatedObject<AdministrativeAreal2DGeometryCalculationResult>(administrativeAreal2D);
                    if (administrativeAreal2DGeometryCalculationResult == null)
                    {
                        administrativeAreal2DGeometryCalculationResult = Create.AdministrativeAreal2DGeometryCalculationResult(administrativeAreal2D);
                    }

                    tuples_AdministrativeAreal2D.Add(new Tuple<AdministrativeAreal2D, AdministrativeAreal2DGeometryCalculationResult>(administrativeAreal2D, administrativeAreal2DGeometryCalculationResult));
                }
            }

            if(tuples_AdministrativeAreal2D.Count == 0)
            {
                return;
            }
            
            Dictionary<AdministrativeAreal2D, double> dictionary_OccupancyArea = new Dictionary<AdministrativeAreal2D, double>();

            tuples_AdministrativeAreal2D.Sort((x, y) => x.Item2.Area.CompareTo(y.Item2.Area));

            Dictionary<AdministrativeAreal2D, List<Building2D>> dictionary_Building2D = new Dictionary<AdministrativeAreal2D, List<Building2D>>();
            
            foreach (Tuple<AdministrativeAreal2D, AdministrativeAreal2DGeometryCalculationResult> tuple_AdministrativeAreal2D in tuples_AdministrativeAreal2D)
            {
                List<Building2D> building2Ds = new List<Building2D>();

                double occupancyArea = 0;
                if (gISModel.TryGetRelatedObjects<Building2D, AdministrativeAreal2DBuilding2DsRelation>(tuple_AdministrativeAreal2D.Item1, out List<Building2D> building2Ds_AdministrativeAreal2D) && building2Ds_AdministrativeAreal2D != null)
                {
                    foreach (Building2D building2D in building2Ds_AdministrativeAreal2D)
                    {
                        if (building2D == null || !building2D.IsOccupied())
                        {
                            continue;
                        }

                        building2Ds.Add(building2D);

                        occupancyArea += building2D.PolygonalFace2D.GetArea() * building2D.Storeys;
                    }
                }

                dictionary_OccupancyArea[tuple_AdministrativeAreal2D.Item1] = occupancyArea;
                dictionary_Building2D[tuple_AdministrativeAreal2D.Item1] = building2Ds;
            }

            List<Tuple<AdministrativeAreal2D, OccupancyCalculationResult>> tuples_OccupancyCalculationResult = new List<Tuple<AdministrativeAreal2D, OccupancyCalculationResult>>();

            List<Tuple<AdministrativeAreal2D, AdministrativeAreal2DGeometryCalculationResult>> tuples_AdministrativeAreal2D_Temp = new List<Tuple<AdministrativeAreal2D, AdministrativeAreal2DGeometryCalculationResult>>(tuples_AdministrativeAreal2D);
            for (int i = tuples_AdministrativeAreal2D_Temp.Count - 1; i >= 0; i--)
            {
                AdministrativeAreal2D administrativeAreal2D = tuples_AdministrativeAreal2D_Temp[i].Item1;
                if (administrativeAreal2D.Occupancy == null || !administrativeAreal2D.Occupancy.HasValue)
                {
                    if(dictionary_OccupancyArea[administrativeAreal2D] == 0)
                    {
                        tuples_OccupancyCalculationResult.Add(new Tuple<AdministrativeAreal2D, OccupancyCalculationResult>(administrativeAreal2D, new OccupancyCalculationResult(0, 0)));
                        tuples_AdministrativeAreal2D_Temp.RemoveAt(i);
                    }

                    continue;
                }

                uint occupancy = administrativeAreal2D.Occupancy.Value;
                double occupancyArea = dictionary_OccupancyArea[administrativeAreal2D];
                OccupancyCalculationResult occupancyCalculationResult = new OccupancyCalculationResult(occupancyArea, occupancy);

                tuples_OccupancyCalculationResult.Add(new Tuple<AdministrativeAreal2D, OccupancyCalculationResult>(administrativeAreal2D, occupancyCalculationResult));
                tuples_AdministrativeAreal2D_Temp.RemoveAt(i);
            }

            int count = 0;

            while (tuples_AdministrativeAreal2D_Temp.Count != count)
            {
                count = tuples_AdministrativeAreal2D_Temp.Count;
                for (int i = tuples_AdministrativeAreal2D_Temp.Count - 1; i >= 0; i--)
                {
                    AdministrativeAreal2D administrativeAreal2D = tuples_AdministrativeAreal2D_Temp[i].Item1;

                    UniqueReference uniqueReference = Core.Create.UniqueReference(administrativeAreal2D);

                    List<AdministrativeAreal2DAdministrativeAreal2DsRelation> administrativeAreal2DAdministrativeAreal2DsRelations = gISModel.GetRelations<AdministrativeAreal2DAdministrativeAreal2DsRelation>(x => x.Contains_To(uniqueReference));
                    if (administrativeAreal2DAdministrativeAreal2DsRelations == null || administrativeAreal2DAdministrativeAreal2DsRelations.Count == 0)
                    {
                        continue;
                    }

                    AdministrativeAreal2D administrativeAreal2D_Parent = gISModel.GetObject<AdministrativeAreal2D>(administrativeAreal2DAdministrativeAreal2DsRelations[0].UniqueReference_From as GuidReference);
                    if (administrativeAreal2D_Parent == null)
                    {
                        continue;
                    }

                    double occupancyPerArea = double.NaN;

                    OccupancyCalculationResult occupancyCalculationResult_Parent = tuples_OccupancyCalculationResult.Find(x => x.Item1.Guid == administrativeAreal2D_Parent.Guid)?.Item2;
                    if (occupancyCalculationResult_Parent != null)
                    {
                        uint? occupancy = occupancyCalculationResult_Parent.Occupancy;
                        double? occupancyArea = occupancyCalculationResult_Parent.OccupancyArea;

                        if(occupancy != null && occupancy.HasValue && occupancyArea != null && occupancyArea.HasValue)
                        {
                            if(occupancyArea.Value != 0 && occupancy.Value != 0)
                            {
                                occupancyPerArea = occupancy.Value / occupancyArea.Value;

                                OccupancyCalculationResult occupancyCalculationResult = new OccupancyCalculationResult(dictionary_OccupancyArea[administrativeAreal2D], System.Convert.ToUInt32(dictionary_OccupancyArea[administrativeAreal2D] * occupancyPerArea));
                                tuples_OccupancyCalculationResult.Add(new Tuple<AdministrativeAreal2D, OccupancyCalculationResult>(administrativeAreal2D, occupancyCalculationResult));

                                tuples_AdministrativeAreal2D_Temp.RemoveAll(x => x.Item1.Guid == administrativeAreal2D.Guid);

                                break;
                            }
                        }
                    }

                    if (!gISModel.TryGetRelatedObjects<AdministrativeAreal2D, AdministrativeAreal2DAdministrativeAreal2DsRelation>(administrativeAreal2D_Parent, out List<AdministrativeAreal2D> administrativeAreal2Ds_Child) || administrativeAreal2Ds_Child == null)
                    {
                        continue;
                    }

                    List<double> occupancyAreas = new List<double>();
                    List<uint> occupancies = new List<uint>();

                    foreach (AdministrativeAreal2D administrativeAreal2D_Child in administrativeAreal2Ds_Child)
                    {
                        OccupancyCalculationResult occupancyCalculationResult_Child = tuples_OccupancyCalculationResult.Find(x => x.Item1.Guid == administrativeAreal2D_Child.Guid)?.Item2;
                        if(occupancyCalculationResult_Child == null)
                        {
                            continue;
                        }

                        uint? occupancy = occupancyCalculationResult_Child.Occupancy;
                        double? occupancyArea = occupancyCalculationResult_Child.OccupancyArea;

                        if (occupancy != null && occupancy.HasValue && occupancyArea != null && occupancyArea.HasValue)
                        {
                            occupancyAreas.Add(occupancyArea.Value);
                            occupancies.Add(occupancy.Value);
                        }
                    }

                    if(occupancyAreas == null || occupancyAreas.Count == 0 || occupancies == null ||occupancies.Count == 0)
                    {
                        continue;
                    }

                    occupancyPerArea = occupancies.ConvertAll(x  => System.Convert.ToDouble(x)).Sum() / occupancyAreas.Sum();

                    List<Guid> guids = new List<Guid>();
                    foreach (AdministrativeAreal2D administrativeAreal2D_Child in administrativeAreal2Ds_Child)
                    {
                        OccupancyCalculationResult occupancyCalculationResult_Child = tuples_OccupancyCalculationResult.Find(x => x.Item1.Guid == administrativeAreal2D_Child.Guid)?.Item2;
                        if (occupancyCalculationResult_Child != null)
                        {
                            continue;
                        }

                        occupancyCalculationResult_Child = new OccupancyCalculationResult(dictionary_OccupancyArea[administrativeAreal2D], System.Convert.ToUInt32(dictionary_OccupancyArea[administrativeAreal2D] * occupancyPerArea));
                        tuples_OccupancyCalculationResult.Add(new Tuple<AdministrativeAreal2D, OccupancyCalculationResult>(administrativeAreal2D, occupancyCalculationResult_Child));
                        guids.Add(administrativeAreal2D.Guid);
                    }

                    if(guids != null && guids.Count != 0)
                    {
                        tuples_AdministrativeAreal2D_Temp.RemoveAll(x => guids.Contains(x.Item1.Guid));
                        break;
                    }
                }
            }

            if(tuples_AdministrativeAreal2D_Temp.Count != 0)
            {
                List<double> occupancyAreas = new List<double>();
                List<uint> occupancies = new List<uint>();

                foreach (Tuple<AdministrativeAreal2D, OccupancyCalculationResult>  tuple_OccupancyCalculationResult in tuples_OccupancyCalculationResult)
                {
                    uint? occupancy = tuple_OccupancyCalculationResult.Item2.Occupancy;
                    double? occupancyArea = tuple_OccupancyCalculationResult.Item2.OccupancyArea;

                    if (occupancy != null && occupancy.HasValue && occupancyArea != null && occupancyArea.HasValue)
                    {
                        occupancyAreas.Add(occupancyArea.Value);
                        occupancies.Add(occupancy.Value);
                    }
                }

                if (occupancyAreas != null && occupancyAreas.Count != 0 && occupancies != null && occupancies.Count != 0)
                {
                    double occupancyPerArea = occupancies.ConvertAll(x => System.Convert.ToDouble(x)).Sum() / occupancyAreas.Sum();
                    
                    foreach(Tuple<AdministrativeAreal2D, AdministrativeAreal2DGeometryCalculationResult> tuple_AdministrativeAreal2D_Temp in tuples_AdministrativeAreal2D_Temp)
                    {
                        if(dictionary_OccupancyArea.TryGetValue(tuple_AdministrativeAreal2D_Temp.Item1, out double occupancyArea))
                        {
                            OccupancyCalculationResult occupancyCalculationResult = null;

                            if (!double.IsNaN(occupancyArea) && occupancyArea != 0)
                            {
                                occupancyCalculationResult = new OccupancyCalculationResult(occupancyArea, System.Convert.ToUInt32(occupancyArea * occupancyPerArea));
                            }
                            else
                            {
                                occupancyCalculationResult = new OccupancyCalculationResult(occupancyArea, 0);
                            }

                            tuples_OccupancyCalculationResult.Add(new Tuple<AdministrativeAreal2D, OccupancyCalculationResult>(tuple_AdministrativeAreal2D_Temp.Item1, occupancyCalculationResult));
                        }
                    }
                }
            }

            foreach(Tuple<AdministrativeAreal2D, OccupancyCalculationResult> tuple_OccupancyCalculationResult in tuples_OccupancyCalculationResult)
            {
                gISModel.Update(tuple_OccupancyCalculationResult.Item1, tuple_OccupancyCalculationResult.Item2);
            }

            foreach(KeyValuePair<AdministrativeAreal2D, List<Building2D>> keyValuePair in dictionary_Building2D)
            {
                List<Building2D> building2Ds = keyValuePair.Value;
                if (building2Ds == null || building2Ds.Count == 0)
                {
                    continue;
                }

                AdministrativeAreal2D administrativeAreal2D = keyValuePair.Key;

                OccupancyCalculationResult occupancyCalculationResult_AdministrativeAreal2D = tuples_OccupancyCalculationResult.Find(x => x.Item1.Guid == administrativeAreal2D.Guid).Item2;
                if (occupancyCalculationResult_AdministrativeAreal2D == null || occupancyCalculationResult_AdministrativeAreal2D.Occupancy == null || occupancyCalculationResult_AdministrativeAreal2D.OccupancyArea == null)
                {
                    continue;
                }

                uint occupancy_AdministrativeAreal2D = occupancyCalculationResult_AdministrativeAreal2D.Occupancy.Value;

                double factor = occupancy_AdministrativeAreal2D / occupancyCalculationResult_AdministrativeAreal2D.OccupancyArea.Value; 

                List<Tuple<Building2D, double, uint>> tuples_Builidng2D = new List<Tuple<Building2D, double, uint>>();
                foreach(Building2D building2D in building2Ds)
                {
                    double occupancyArea = building2D.PolygonalFace2D.GetArea() * building2D.Storeys;

                    uint occupancy = 0;
                    if (occupancy_AdministrativeAreal2D != 0)
                    {
                        occupancy = System.Convert.ToUInt32(System.Math.Floor(occupancyArea * factor));
                        if (occupancy == 0)
                        {
                            occupancy++;
                        }

                        occupancy_AdministrativeAreal2D -= occupancy;
                    }
                    else
                    {
                        occupancy = 1;
                    }

                    tuples_Builidng2D.Add(new Tuple<Building2D, double, uint>(building2D, occupancyArea, occupancy));
                }

                if(occupancy_AdministrativeAreal2D > 0)
                {
                    Random random = new Random(System.Convert.ToInt32(occupancyCalculationResult_AdministrativeAreal2D.Occupancy.Value));

                    Range<int> range = new Range<int>(0, building2Ds.Count - 1);

                    while (occupancy_AdministrativeAreal2D > 0)
                    {
                        int index = Core.Query.Random(random, range);

                        Tuple<Building2D, double, uint> tuple = tuples_Builidng2D[index];

                        tuples_Builidng2D[index] = new Tuple<Building2D, double, uint>(tuple.Item1, tuple.Item2, tuple.Item3 + 1);
                        
                        occupancy_AdministrativeAreal2D--;
                    }
                }

                foreach(Tuple<Building2D, double, uint> tuple_Building2D in tuples_Builidng2D)
                {
                    OccupancyCalculationResult occupancyCalculationResult = new OccupancyCalculationResult(tuple_Building2D.Item2, tuple_Building2D.Item3);

                    gISModel.Update(tuple_Building2D.Item1, occupancyCalculationResult);
                }
            }
        }
    }
}

