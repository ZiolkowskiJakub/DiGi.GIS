using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Classes;
using System;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Modify
    {
        public static void CalculateAdministrativeAreal2DBuilding2Ds(this GISModel gISModel, double tolerance = Core.Constans.Tolerance.Distance)
        {
            List<Building2D> building2Ds = gISModel?.GetObjects<Building2D>();
            if(building2Ds == null)
            {
                return;
            }

            List<Tuple<Building2D, Building2DGeometryCalculationResult>> tuples_Building2D = new List<Tuple<Building2D, Building2DGeometryCalculationResult>>();
            foreach(Building2D building2D in building2Ds)
            {
                Building2DGeometryCalculationResult building2DGeometryCalculationResult = gISModel.GetRelatedObject<Building2DGeometryCalculationResult>(building2D);
                if(building2DGeometryCalculationResult == null)
                {
                    building2DGeometryCalculationResult = Create.Building2DGeometryCalculationResult(building2D);
                }

                tuples_Building2D.Add(new Tuple<Building2D, Building2DGeometryCalculationResult>(building2D, building2DGeometryCalculationResult));
            }


            List<AdministrativeAreal2D> administrativeAreal2Ds = gISModel?.GetObjects<AdministrativeAreal2D>();
            if (administrativeAreal2Ds == null)
            {
                return;
            }

            List<Tuple<AdministrativeAreal2D, AdministrativeAreal2DGeometryCalculationResult>> tuples_AdministrativeAreal2D = new List<Tuple<AdministrativeAreal2D, AdministrativeAreal2DGeometryCalculationResult>>();
            foreach (AdministrativeAreal2D administrativeAreal2D in administrativeAreal2Ds)
            {
                AdministrativeAreal2DGeometryCalculationResult administrativeAreal2DGeometryCalculationResult = gISModel.GetRelatedObject<AdministrativeAreal2DGeometryCalculationResult>(administrativeAreal2D);
                if (administrativeAreal2DGeometryCalculationResult == null)
                {
                    administrativeAreal2DGeometryCalculationResult = Create.AdministrativeAreal2DGeometryCalculationResult(administrativeAreal2D);
                }

                tuples_AdministrativeAreal2D.Add(new Tuple<AdministrativeAreal2D, AdministrativeAreal2DGeometryCalculationResult>(administrativeAreal2D, administrativeAreal2DGeometryCalculationResult));
            }

            Dictionary<AdministrativeAreal2D, List<Building2D>> dictionary = new Dictionary<AdministrativeAreal2D, List<Building2D>>();
            foreach(Tuple<Building2D, Building2DGeometryCalculationResult> tuple_Building2D in tuples_Building2D)
            {
                Point2D internalPoint = tuple_Building2D.Item2.InternalPoint;
                if(internalPoint == null)
                {
                    continue;
                }

                List<Tuple<AdministrativeAreal2D, AdministrativeAreal2DGeometryCalculationResult>> tuples_AdministrativeAreal2D_Temp = tuples_AdministrativeAreal2D.FindAll(x => x.Item2.BoundingBox.InRange(internalPoint, tolerance) && x.Item1.PolygonalFace2D.Inside(internalPoint, tolerance));
                if(tuples_AdministrativeAreal2D_Temp.Count == 0)
                {
                    tuples_AdministrativeAreal2D_Temp = new List<Tuple<AdministrativeAreal2D, AdministrativeAreal2DGeometryCalculationResult>>(tuples_AdministrativeAreal2D);

                    List<Tuple<AdministrativeAreal2D, double>> tuple_Distances = new List<Tuple<AdministrativeAreal2D, double>>();
                    foreach(Tuple<AdministrativeAreal2D, AdministrativeAreal2DGeometryCalculationResult> tuple_AdministrativeAreal2D in tuples_AdministrativeAreal2D)
                    {
                        tuple_Distances.Add(new Tuple<AdministrativeAreal2D, double>(tuple_AdministrativeAreal2D.Item1, tuple_AdministrativeAreal2D.Item1.PolygonalFace2D.ExternalEdge.Distance(internalPoint)));
                    }

                    tuple_Distances.Sort((x, y) => x.Item2.CompareTo(y.Item2));

                    tuple_Distances = tuple_Distances.FindAll(x => Core.Query.AlmostEquals(tuple_Distances[0].Item2, x.Item2, tolerance));
                    tuples_AdministrativeAreal2D_Temp = tuple_Distances.ConvertAll(x => tuples_AdministrativeAreal2D_Temp.Find(y => x.Item1 == y.Item1));
                    tuples_AdministrativeAreal2D_Temp.Sort((x, y) => x.Item2.Area.CompareTo(y.Item2.Area));

                    tuples_AdministrativeAreal2D_Temp = new List<Tuple<AdministrativeAreal2D, AdministrativeAreal2DGeometryCalculationResult>>() { tuples_AdministrativeAreal2D_Temp[0] };
                }

                tuples_AdministrativeAreal2D_Temp.Sort((x, y) => x.Item2.Area.CompareTo(y.Item2.Area));

                AdministrativeAreal2D administrativeAreal2D = tuples_AdministrativeAreal2D_Temp[0].Item1;

                if (!dictionary.TryGetValue(administrativeAreal2D, out List<Building2D> buidling2Ds))
                {
                    buidling2Ds = new List<Building2D>();
                    dictionary[administrativeAreal2D] = buidling2Ds;
                }

                buidling2Ds.Add(tuple_Building2D.Item1);
            }

            foreach(KeyValuePair<AdministrativeAreal2D, List<Building2D>> keyValuePair in dictionary)
            {
                gISModel.Update(keyValuePair.Key, keyValuePair.Value);
            }
        }
    }
}

