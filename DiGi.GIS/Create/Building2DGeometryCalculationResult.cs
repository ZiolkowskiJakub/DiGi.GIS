using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.GIS.Classes;

namespace DiGi.GIS
{
    public static partial class Create
    {
        public static Building2DGeometryCalculationResult Building2DGeometryCalculationResult(this Building2D building2D, double tolerance = Core.Constans.Tolerance.Distance)
        {
            PolygonalFace2D polygonalFace2D = building2D?.PolygonalFace2D;
            if(polygonalFace2D == null)
            {
                return null;
            }

            IPolygonal2D polygonal2D = polygonalFace2D.ExternalEdge;
            if (polygonal2D == null)
            {
                return null;
            }

            BoundingBox2D boundingBox = polygonalFace2D.GetBoundingBox();
            Rectangle2D rectangle = Geometry.Planar.Create.Rectangle2D(polygonalFace2D, tolerance);
            Point2D centroid = Geometry.Planar.Query.Centroid(polygonalFace2D);
            Point2D internalPoint = polygonalFace2D.GetInternalPoint(tolerance);
            
            double thinnessRatio = Geometry.Planar.Query.ThinnessRatio(polygonal2D);
            double rectangularThinnessRatio = Geometry.Planar.Query.RectangularThinnessRatio(polygonal2D);
            double rectangularity = Geometry.Planar.Query.Rectangularity(polygonal2D);
            double isoperimetricRatio = Geometry.Planar.Query.IsoperimetricRatio(polygonal2D);

            double area = polygonalFace2D.GetArea();
            double perimeter = polygonal2D.GetPerimeter();

            return new Building2DGeometryCalculationResult(boundingBox, rectangle, centroid, internalPoint, thinnessRatio, rectangularity, area, perimeter, rectangularThinnessRatio, isoperimetricRatio);
        }
    }
}

