using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Classes;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static List<Building2D> Building2Ds(this GISModel gISModel, Point2D point2D, out List<AdministrativeAreal2D> administrativeAreal2Ds, double tolerance = Core.Constans.Tolerance.Distance)
        {
            administrativeAreal2Ds = null;

            if (gISModel == null || point2D == null)
            {
                return null;
            }

            List<AdministrativeAreal2D> administrativeAreal2Ds_All = gISModel.GetObjects<AdministrativeAreal2D>();
            if (administrativeAreal2Ds_All == null)
            {
                return null;
            }

            administrativeAreal2Ds = new List<AdministrativeAreal2D>();

            List<Building2D> result = new List<Building2D>();
            foreach (AdministrativeAreal2D administrativeAreal2D in administrativeAreal2Ds_All)
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
                    PolygonalFace2D polygonalFace2D = building2D?.PolygonalFace2D;
                    if (polygonalFace2D == null)
                    {
                        continue;
                    }

                    if (building2D == null || !polygonalFace2D.GetBoundingBox().InRange(point2D, tolerance))
                    {
                        continue;
                    }

                    if (!polygonalFace2D.InRange(point2D, tolerance))
                    {
                        continue;
                    }

                    result.Add(building2D);
                }
            }

            return result;
        }
    }
}