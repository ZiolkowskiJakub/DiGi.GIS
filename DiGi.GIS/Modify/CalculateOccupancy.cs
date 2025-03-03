using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using System;
using System.Collections.Generic;
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

            List<Tuple<AdministrativeSubdivision, AdministrativeAreal2DGeometryCalculationResult>> tuples_AdministrativeSubdivision = new List<Tuple<AdministrativeSubdivision, AdministrativeAreal2DGeometryCalculationResult>>();

            List<AdministrativeSubdivision> administrativeSubdivisions = gISModel?.GetObjects<AdministrativeSubdivision>();
            if (administrativeSubdivisions != null)
            {
                foreach (AdministrativeSubdivision administrativeSubdivision in administrativeSubdivisions)
                {
                    if (administrativeSubdivision == null)
                    {
                        continue;
                    }

                    AdministrativeAreal2DGeometryCalculationResult administrativeAreal2DGeometryCalculationResult = gISModel.GetRelatedObject<AdministrativeAreal2DGeometryCalculationResult>(administrativeSubdivision);
                    if (administrativeAreal2DGeometryCalculationResult == null)
                    {
                        administrativeAreal2DGeometryCalculationResult = Create.AdministrativeAreal2DGeometryCalculationResult(administrativeSubdivision);
                    }

                    tuples_AdministrativeSubdivision.Add(new Tuple<AdministrativeSubdivision, AdministrativeAreal2DGeometryCalculationResult>(administrativeSubdivision, administrativeAreal2DGeometryCalculationResult));
                }
            }

            if(tuples_AdministrativeSubdivision.Count == 0)
            {
                return;
            }
            
            Dictionary<AdministrativeSubdivision, double> dictionary_OccupancyArea = new Dictionary<AdministrativeSubdivision, double>();

            tuples_AdministrativeSubdivision.Sort((x, y) => x.Item2.Area.CompareTo(y.Item2.Area));

            Dictionary<AdministrativeSubdivision, List<Building2D>> dictionary_Building2D = new Dictionary<AdministrativeSubdivision, List<Building2D>>();
            
            foreach (Tuple<AdministrativeSubdivision, AdministrativeAreal2DGeometryCalculationResult> tuple_AdministrativeSubdivision in tuples_AdministrativeSubdivision)
            {
                List<Building2D> building2Ds = new List<Building2D>();

                double occupancyArea = 0;
                if (gISModel.TryGetRelatedObjects<Building2D, AdministrativeAreal2DBuilding2DsRelation>(tuple_AdministrativeSubdivision.Item1, out List<Building2D> building2Ds_AdministrativeSubdivision) && building2Ds_AdministrativeSubdivision != null)
                {
                    foreach (Building2D building2D in building2Ds_AdministrativeSubdivision)
                    {
                        if (building2D == null || !building2D.IsOccupied())
                        {
                            continue;
                        }

                        building2Ds.Add(building2D);

                        occupancyArea += building2D.PolygonalFace2D.GetArea() * building2D.Storeys;
                    }
                }

                dictionary_OccupancyArea[tuple_AdministrativeSubdivision.Item1] = occupancyArea;
                dictionary_Building2D[tuple_AdministrativeSubdivision.Item1] = building2Ds;
            }

            List<Tuple<AdministrativeSubdivision, OccupancyCalculationResult>> tuples_OccupancyCalculationResult = new List<Tuple<AdministrativeSubdivision, OccupancyCalculationResult>>();

            List<Tuple<AdministrativeSubdivision, AdministrativeAreal2DGeometryCalculationResult>> tuples_AdministrativeSubdivision_Temp = new List<Tuple<AdministrativeSubdivision, AdministrativeAreal2DGeometryCalculationResult>>(tuples_AdministrativeSubdivision);
            for (int i = tuples_AdministrativeSubdivision_Temp.Count - 1; i >= 0; i--)
            {
                AdministrativeSubdivision administrativeSubdivision = tuples_AdministrativeSubdivision_Temp[i].Item1;
                if (administrativeSubdivision.Occupancy == null || !administrativeSubdivision.Occupancy.HasValue)
                {
                    if(dictionary_OccupancyArea[administrativeSubdivision] == 0)
                    {
                        tuples_OccupancyCalculationResult.Add(new Tuple<AdministrativeSubdivision, OccupancyCalculationResult>(administrativeSubdivision, new OccupancyCalculationResult(0, 0)));
                        tuples_AdministrativeSubdivision_Temp.RemoveAt(i);
                    }

                    continue;
                }

                uint occupancy = administrativeSubdivision.Occupancy.Value;
                double occupancyArea = dictionary_OccupancyArea[administrativeSubdivision];
                OccupancyCalculationResult occupancyCalculationResult = new OccupancyCalculationResult(occupancyArea, occupancy);

                tuples_OccupancyCalculationResult.Add(new Tuple<AdministrativeSubdivision, OccupancyCalculationResult>(administrativeSubdivision, occupancyCalculationResult));
                tuples_AdministrativeSubdivision_Temp.RemoveAt(i);
            }

            int count = 0;

            while (tuples_AdministrativeSubdivision_Temp.Count != count)
            {
                count = tuples_AdministrativeSubdivision_Temp.Count;
                for (int i = tuples_AdministrativeSubdivision_Temp.Count - 1; i >= 0; i--)
                {
                    AdministrativeSubdivision administrativeSubdivision = tuples_AdministrativeSubdivision_Temp[i].Item1;

                    UniqueReference uniqueReference = Core.Create.UniqueReference(administrativeSubdivision);

                    List<AdministrativeAreal2DAdministrativeAreal2DsRelation> administrativeAreal2DAdministrativeAreal2DsRelations = gISModel.GetRelations<AdministrativeAreal2DAdministrativeAreal2DsRelation>(x => x.Contains(Core.Relation.Enums.RelationSide.To, uniqueReference));
                    if (administrativeAreal2DAdministrativeAreal2DsRelations == null || administrativeAreal2DAdministrativeAreal2DsRelations.Count == 0)
                    {
                        continue;
                    }

                    AdministrativeSubdivision administrativeSubdivision_Parent = gISModel.GetObject<AdministrativeSubdivision>(administrativeAreal2DAdministrativeAreal2DsRelations[0].UniqueReference_From as GuidReference);
                    if (administrativeSubdivision_Parent == null)
                    {
                        continue;
                    }

                    double occupancyPerArea = double.NaN;

                    OccupancyCalculationResult occupancyCalculationResult_Parent = tuples_OccupancyCalculationResult.Find(x => x.Item1.Guid == administrativeSubdivision_Parent.Guid)?.Item2;
                    if (occupancyCalculationResult_Parent != null)
                    {
                        uint? occupancy = occupancyCalculationResult_Parent.Occupancy;
                        double? occupancyArea = occupancyCalculationResult_Parent.OccupancyArea;

                        if(occupancy != null && occupancy.HasValue && occupancyArea != null && occupancyArea.HasValue)
                        {
                            if(occupancyArea.Value != 0 && occupancy.Value != 0)
                            {
                                occupancyPerArea = occupancy.Value / occupancyArea.Value;

                                OccupancyCalculationResult occupancyCalculationResult = new OccupancyCalculationResult(dictionary_OccupancyArea[administrativeSubdivision], System.Convert.ToUInt32(dictionary_OccupancyArea[administrativeSubdivision] * occupancyPerArea));
                                tuples_OccupancyCalculationResult.Add(new Tuple<AdministrativeSubdivision, OccupancyCalculationResult>(administrativeSubdivision, occupancyCalculationResult));

                                tuples_AdministrativeSubdivision_Temp.RemoveAll(x => x.Item1.Guid == administrativeSubdivision.Guid);

                                break;
                            }
                        }
                    }

                    if (!gISModel.TryGetRelatedObjects<AdministrativeSubdivision, AdministrativeAreal2DAdministrativeAreal2DsRelation>(administrativeSubdivision_Parent, out List<AdministrativeSubdivision> administrativeSubdivisions_Child) || administrativeSubdivisions_Child == null)
                    {
                        continue;
                    }

                    List<double> occupancyAreas = new List<double>();
                    List<uint> occupancies = new List<uint>();

                    foreach (AdministrativeSubdivision administrativeSubdivision_Child in administrativeSubdivisions_Child)
                    {
                        OccupancyCalculationResult occupancyCalculationResult_Child = tuples_OccupancyCalculationResult.Find(x => x.Item1.Guid == administrativeSubdivision_Child.Guid)?.Item2;
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
                    foreach (AdministrativeSubdivision administrativeSubdivision_Child in administrativeSubdivisions_Child)
                    {
                        OccupancyCalculationResult occupancyCalculationResult_Child = tuples_OccupancyCalculationResult.Find(x => x.Item1.Guid == administrativeSubdivision_Child.Guid)?.Item2;
                        if (occupancyCalculationResult_Child != null)
                        {
                            continue;
                        }

                        occupancyCalculationResult_Child = new OccupancyCalculationResult(dictionary_OccupancyArea[administrativeSubdivision], System.Convert.ToUInt32(dictionary_OccupancyArea[administrativeSubdivision] * occupancyPerArea));
                        tuples_OccupancyCalculationResult.Add(new Tuple<AdministrativeSubdivision, OccupancyCalculationResult>(administrativeSubdivision, occupancyCalculationResult_Child));
                        guids.Add(administrativeSubdivision.Guid);
                    }

                    if(guids != null && guids.Count != 0)
                    {
                        tuples_AdministrativeSubdivision_Temp.RemoveAll(x => guids.Contains(x.Item1.Guid));
                        break;
                    }
                }
            }

            if(tuples_AdministrativeSubdivision_Temp.Count != 0)
            {
                List<double> occupancyAreas = new List<double>();
                List<uint> occupancies = new List<uint>();

                foreach (Tuple<AdministrativeSubdivision, OccupancyCalculationResult>  tuple_OccupancyCalculationResult in tuples_OccupancyCalculationResult)
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
                    
                    foreach(Tuple<AdministrativeSubdivision, AdministrativeAreal2DGeometryCalculationResult> tuple_AdministrativeSubdivision_Temp in tuples_AdministrativeSubdivision_Temp)
                    {
                        if(dictionary_OccupancyArea.TryGetValue(tuple_AdministrativeSubdivision_Temp.Item1, out double occupancyArea))
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

                            tuples_OccupancyCalculationResult.Add(new Tuple<AdministrativeSubdivision, OccupancyCalculationResult>(tuple_AdministrativeSubdivision_Temp.Item1, occupancyCalculationResult));
                        }
                    }
                }
            }

            foreach(Tuple<AdministrativeSubdivision, OccupancyCalculationResult> tuple_OccupancyCalculationResult in tuples_OccupancyCalculationResult)
            {
                gISModel.Update(tuple_OccupancyCalculationResult.Item1, tuple_OccupancyCalculationResult.Item2);
            }

            foreach(KeyValuePair<AdministrativeSubdivision, List<Building2D>> keyValuePair in dictionary_Building2D)
            {
                List<Building2D> building2Ds = keyValuePair.Value;
                if (building2Ds == null || building2Ds.Count == 0)
                {
                    continue;
                }

                AdministrativeSubdivision administrativeSubdivision = keyValuePair.Key;

                OccupancyCalculationResult occupancyCalculationResult_AdministrativeSubdivision = tuples_OccupancyCalculationResult.Find(x => x.Item1.Guid == administrativeSubdivision.Guid).Item2;
                if (occupancyCalculationResult_AdministrativeSubdivision == null || occupancyCalculationResult_AdministrativeSubdivision.Occupancy == null || occupancyCalculationResult_AdministrativeSubdivision.OccupancyArea == null)
                {
                    continue;
                }

                uint occupancy_AdministrativeSubdivision = occupancyCalculationResult_AdministrativeSubdivision.Occupancy.Value;

                double factor = occupancy_AdministrativeSubdivision / occupancyCalculationResult_AdministrativeSubdivision.OccupancyArea.Value; 

                List<Tuple<Building2D, double, uint>> tuples_Builidng2D = new List<Tuple<Building2D, double, uint>>();
                foreach(Building2D building2D in building2Ds)
                {
                    double occupancyArea = building2D.PolygonalFace2D.GetArea() * building2D.Storeys;

                    uint occupancy = 0;
                    if (occupancy_AdministrativeSubdivision != 0)
                    {
                        occupancy = System.Convert.ToUInt32(System.Math.Floor(occupancyArea * factor));
                        if (occupancy == 0)
                        {
                            occupancy++;
                        }

                        occupancy_AdministrativeSubdivision -= occupancy;
                    }
                    else
                    {
                        occupancy = 1;
                    }

                    tuples_Builidng2D.Add(new Tuple<Building2D, double, uint>(building2D, occupancyArea, occupancy));
                }

                if(occupancy_AdministrativeSubdivision > 0)
                {
                    Random random = new Random(System.Convert.ToInt32(occupancyCalculationResult_AdministrativeSubdivision.Occupancy.Value));

                    Range<int> range = new Range<int>(0, building2Ds.Count - 1);

                    while (occupancy_AdministrativeSubdivision > 0)
                    {
                        int index = Core.Query.Random(random, range);

                        Tuple<Building2D, double, uint> tuple = tuples_Builidng2D[index];

                        tuples_Builidng2D[index] = new Tuple<Building2D, double, uint>(tuple.Item1, tuple.Item2, tuple.Item3 + 1);
                        
                        occupancy_AdministrativeSubdivision--;
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

