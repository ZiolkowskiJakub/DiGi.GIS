using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.GIS.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static List<Building2D> Building2Ds<UAdministrativeAreal2D>(this GISModel gISModel, Point2D point2D, out List<UAdministrativeAreal2D> administrativeAreal2Ds, double distance = 0, double tolerance = Core.Constans.Tolerance.Distance) where UAdministrativeAreal2D : AdministrativeAreal2D
        {
            administrativeAreal2Ds = null;

            if (gISModel == null || point2D == null)
            {
                return null;
            }

            List<UAdministrativeAreal2D> administrativeAreal2Ds_All = gISModel.GetObjects<UAdministrativeAreal2D>();
            if (administrativeAreal2Ds_All == null)
            {
                return null;
            }

            administrativeAreal2Ds = new List<UAdministrativeAreal2D>();

            Circle2D circle2D = distance > 0 ? new Circle2D(point2D, distance) : null;

            Dictionary<string, Building2D> dictionary = new Dictionary<string, Building2D>();
            foreach (UAdministrativeAreal2D administrativeAreal2D in administrativeAreal2Ds_All)
            {
                AdministrativeAreal2DGeometryCalculationResult administrativeAreal2DGeometryCalculationResult = gISModel.GetRelatedObject<AdministrativeAreal2DGeometryCalculationResult>(administrativeAreal2D);
                if (administrativeAreal2DGeometryCalculationResult == null)
                {
                    administrativeAreal2DGeometryCalculationResult = Create.AdministrativeAreal2DGeometryCalculationResult(administrativeAreal2D);
                }

                if (!administrativeAreal2DGeometryCalculationResult.BoundingBox.InRange(point2D, tolerance))
                {
                    continue;
                }

                if (!administrativeAreal2D.PolygonalFace2D.InRange(point2D, tolerance))
                {
                    continue;
                }

                administrativeAreal2Ds.Add(administrativeAreal2D);

                if (!gISModel.TryGetRelatedObjects<Building2D, AdministrativeAreal2DBuilding2DsRelation>(administrativeAreal2D, out List<Building2D> building2Ds) || building2Ds == null)
                {
                    continue;
                }

                foreach (Building2D building2D in building2Ds)
                {
                    string reference = building2D?.Reference;
                    if(reference == null)
                    {
                        continue;
                    }

                    if(dictionary.ContainsKey(reference))
                    {
                        continue;
                    }

                    PolygonalFace2D polygonalFace2D = building2D.PolygonalFace2D;
                    if (polygonalFace2D == null)
                    {
                        continue;
                    }

                    if(circle2D == null)
                    {
                        if (polygonalFace2D.GetBoundingBox().InRange(point2D, tolerance))
                        {
                            continue;
                        }

                        if (!polygonalFace2D.InRange(point2D, tolerance))
                        {
                            continue;
                        }
                    }
                    else
                    {
                        if(!circle2D.InRange(polygonalFace2D.ExternalEdge, tolerance))
                        {
                            continue;
                        }
                    }


                    dictionary[reference] = building2D;
                }
            }

            return dictionary.Values.ToList();
        }
    }
}