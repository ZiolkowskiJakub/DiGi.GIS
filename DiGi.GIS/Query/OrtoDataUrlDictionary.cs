using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Classes;
using System;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static Dictionary<int, string> OrtoDataUrlDictionary(this BoundingBox2D boundingBox2D, IEnumerable<int> years, double scale)
        {
            if (years == null)
            {
                return null;
            }

            if (boundingBox2D == null || boundingBox2D.GetArea() < 1)
            {
                return null;
            }

            Point2D min = boundingBox2D.Min;
            Point2D max = boundingBox2D.Max;

            double deltaX = max.X - min.X;
            double deltaY = max.Y - min.Y;

            int width_Int = System.Convert.ToInt32(deltaX * scale);
            int height_Int = System.Convert.ToInt32(deltaY * scale);

            Dictionary<int, string> result = new Dictionary<int, string>();
            foreach(int year in years)
            {
                result[year] = OrtoDataUrl(boundingBox2D, year, width_Int, height_Int);
            }

            return result;
        }

        public static Dictionary<int, string> OrtoDataUrlDictionary(this Building2D building2D, IEnumerable<int> years, double offset = 5, double width = 320, bool squared = false)
        {
            if (building2D == null || years == null)
            {
                return null;
            }

            BoundingBox2D boundingBox2D = building2D.PolygonalFace2D?.GetBoundingBox();
            if (boundingBox2D == null)
            {
                return null;
            }

            boundingBox2D.Offset(offset);

            if (squared && boundingBox2D.Width != boundingBox2D.Height)
            {
                double max_Temp = Math.Max(boundingBox2D.Width, boundingBox2D.Height);

                boundingBox2D = Geometry.Planar.Create.BoundingBox2D(boundingBox2D.GetCentroid(), max_Temp, max_Temp);
            }

            Point2D min = boundingBox2D.Min;
            Point2D max = boundingBox2D.Max;

            double deltaX = max.X - min.X;

            double scale = deltaX / width;

            return OrtoDataUrlDictionary(boundingBox2D, years, scale);
        }
    }
}

