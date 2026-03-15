using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Classes;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static List<Building2D>? Building2Ds<UAdministrativeAreal2D>(this GISModel? gISModel, Point2D? point2D, out List<UAdministrativeAreal2D>? administrativeAreal2Ds, double distance = 0, double tolerance = Core.Constants.Tolerance.Distance) where UAdministrativeAreal2D : AdministrativeAreal2D
        {
            administrativeAreal2Ds = null;

            if (gISModel == null || point2D == null)
            {
                return null;
            }

            List<UAdministrativeAreal2D>? administrativeAreal2Ds_All = gISModel.GetObjects<UAdministrativeAreal2D>();
            if (administrativeAreal2Ds_All == null)
            {
                return null;
            }

            administrativeAreal2Ds = [];

            Circle2D? circle2D = distance > 0 ? new Circle2D(point2D, distance) : null;

            Dictionary<string, Building2D> dictionary = [];
            foreach (UAdministrativeAreal2D administrativeAreal2D in administrativeAreal2Ds_All)
            {
                AdministrativeAreal2DGeometryCalculationResult? administrativeAreal2DGeometryCalculationResult = gISModel.GetRelatedObject<AdministrativeAreal2DGeometryCalculationResult>(administrativeAreal2D);
                administrativeAreal2DGeometryCalculationResult ??= Create.AdministrativeAreal2DGeometryCalculationResult(administrativeAreal2D);

                if (administrativeAreal2DGeometryCalculationResult?.BoundingBox is not BoundingBox2D boundingBox2D || !boundingBox2D.InRange(point2D, tolerance))
                {
                    continue;
                }

                if (administrativeAreal2D.PolygonalFace2D is not PolygonalFace2D polygonalFace2D_Temp || !polygonalFace2D_Temp.InRange(point2D, tolerance))
                {
                    continue;
                }

                administrativeAreal2Ds.Add(administrativeAreal2D);

                if (!gISModel.TryGetRelatedObjects<Building2D, AdministrativeAreal2DBuilding2DsRelation>(administrativeAreal2D, out List<Building2D>? building2Ds) || building2Ds == null)
                {
                    continue;
                }

                foreach (Building2D building2D in building2Ds)
                {
                    string? reference = building2D?.Reference;
                    if (reference == null)
                    {
                        continue;
                    }

                    if (dictionary.ContainsKey(reference))
                    {
                        continue;
                    }

                    if (building2D?.PolygonalFace2D is not PolygonalFace2D polygonalFace2D)
                    {
                        continue;
                    }

                    if (circle2D == null)
                    {
                        if (polygonalFace2D?.GetBoundingBox() is not BoundingBox2D boundingBox2D_Building2D || !boundingBox2D_Building2D.InRange(point2D, tolerance))
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
                        if (!circle2D.InRange(polygonalFace2D.ExternalEdge, tolerance))
                        {
                            continue;
                        }
                    }

                    dictionary[reference] = building2D;
                }
            }

            return [.. dictionary.Values];
        }
    }
}