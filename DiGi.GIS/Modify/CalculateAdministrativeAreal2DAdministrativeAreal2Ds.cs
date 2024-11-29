using DiGi.GIS.Classes;
using System;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Modify
    {
        public static void CalculateAdministrativeAreal2DAdministrativeAreal2Ds(this GISModel gISModel, double tolerance = Core.Constans.Tolerance.Distance)
        {
            List<Building2D> building2Ds = gISModel?.GetObjects<Building2D>();
            if(building2Ds == null)
            {
                return;
            }

            List<AdministrativeAreal2D> administrativeAreal2Ds = gISModel?.GetObjects<AdministrativeAreal2D>();
            if (administrativeAreal2Ds == null)
            {
                return;
            }

            List<Tuple<AdministrativeAreal2D, AdministrativeAreal2DGeometryCalculationResult>> tuples = new List<Tuple<AdministrativeAreal2D, AdministrativeAreal2DGeometryCalculationResult>>();
            foreach (AdministrativeAreal2D administrativeAreal2D in administrativeAreal2Ds)
            {
                AdministrativeAreal2DGeometryCalculationResult administrativeAreal2DGeometryCalculationResult = gISModel.GetRelatedObject<AdministrativeAreal2DGeometryCalculationResult>(administrativeAreal2D);
                if (administrativeAreal2DGeometryCalculationResult == null)
                {
                    administrativeAreal2DGeometryCalculationResult = Create.AdministrativeAreal2DGeometryCalculationResult(administrativeAreal2D);
                }

                tuples.Add(new Tuple<AdministrativeAreal2D, AdministrativeAreal2DGeometryCalculationResult>(administrativeAreal2D, administrativeAreal2DGeometryCalculationResult));
            }

            tuples.Sort((x, y) => y.Item2.Area.CompareTo(x.Item2.Area));

            Dictionary<AdministrativeAreal2D, List<AdministrativeAreal2D>> dictionary = new Dictionary<AdministrativeAreal2D, List<AdministrativeAreal2D>>();
            while(tuples.Count > 0)
            {
                Tuple<AdministrativeAreal2D, AdministrativeAreal2DGeometryCalculationResult> tuple = tuples[0];
                tuples.Remove(tuple);

                List<Tuple<AdministrativeAreal2D, AdministrativeAreal2DGeometryCalculationResult>> tuples_Temp = tuples.FindAll(x => tuple.Item2.BoundingBox.InRange( x.Item2.InternalPoint, tolerance) && tuple.Item1.PolygonalFace2D.InRange(x.Item2.InternalPoint, tolerance));
                dictionary[tuple.Item1] = tuples_Temp.ConvertAll(x => x.Item1);
            }

            foreach(KeyValuePair<AdministrativeAreal2D, List<AdministrativeAreal2D>> keyValuePair in dictionary)
            {
                gISModel.Update(keyValuePair.Key, keyValuePair.Value);
            }
        }
    }
}

