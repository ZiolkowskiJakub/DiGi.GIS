using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Classes;
using System;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Query
    {
        /// <summary>
        /// Generates a dictionary of orthodata URLs for the specified bounding box and years based on a given scale.
        /// </summary>
        /// <param name="boundingBox2D">The bounding box area to query.</param>
        /// <param name="years">A collection of years for which to retrieve data URLs.</param>
        /// <param name="scale">The scale factor used to calculate image dimensions.</param>
        /// <returns>A dictionary mapping years to their corresponding orthodata URLs, or null if the input is invalid or the area is too small.</returns>
        public static Dictionary<int, string>? OrtoDataUrlDictionary(this BoundingBox2D? boundingBox2D, IEnumerable<int>? years, double scale)
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

            Dictionary<int, string> result = [];
            foreach (int year in years)
            {
                if (OrtoDataUrl(boundingBox2D, year, width_Int, height_Int) is string url)
                {
                    result[year] = url;
                }
            }

            return result;
        }

        /// <summary>
        /// Generates a dictionary of orthodata URLs for the specified building across multiple years.
        /// </summary>
        /// <param name="building2D">The building object to query.</param>
        /// <param name="years">A collection of years for which to retrieve data URLs.</param>
        /// <param name="offset">The offset distance to expand the bounding box around the building.</param>
        /// <param name="width">The desired width used to calculate the scale.</param>
        /// <param name="squared">Whether to force the resulting bounding box to be square.</param>
        /// <returns>A dictionary mapping years to their corresponding orthodata URLs, or null if the building or years are null.</returns>
        public static Dictionary<int, string>? OrtoDataUrlDictionary(this Building2D? building2D, IEnumerable<int>? years, double offset = 5, double width = 320, bool squared = false)
        {
            if (building2D == null || years == null)
            {
                return null;
            }

            BoundingBox2D? boundingBox2D = building2D.PolygonalFace2D?.GetBoundingBox();
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

            if (boundingBox2D is null)
            {
                return null;
            }

            Point2D min = boundingBox2D.Min;
            Point2D max = boundingBox2D.Max;

            double deltaX = max.X - min.X;

            double scale = deltaX / width;

            return OrtoDataUrlDictionary(boundingBox2D, years, scale);
        }
    }
}