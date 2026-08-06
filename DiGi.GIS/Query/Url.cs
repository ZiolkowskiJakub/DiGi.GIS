using DiGi.Geometry.Planar.Classes;
using System.Globalization;

namespace DiGi.GIS
{
    public static partial class Query
    {
        /// <summary>
        /// Generates a URL for orthophoto data based on a bounding box, year, and scale factor.
        /// </summary>
        /// <param name="boundingBox2D">The bounding box defining the geographic area.</param>
        /// <param name="year">The year of the orthophoto data to retrieve.</param>
        /// <param name="scale">The scale used to calculate the pixel dimensions of the image.</param>
        /// <returns>A string containing the constructed URL, or null if the bounding box is null.</returns>
        public static string? Url_OrtoData(this BoundingBox2D? boundingBox2D, int year, double scale)
        {
            if (boundingBox2D == null)
            {
                return null;
            }

            Point2D min = boundingBox2D.Min;
            Point2D max = boundingBox2D.Max;

            double deltaX = max.X - min.X;
            double deltaY = max.Y - min.Y;

            int width_Int = System.Convert.ToInt32(deltaX * scale);
            int height_Int = System.Convert.ToInt32(deltaY * scale);

            return Url_OrtoData(boundingBox2D, year, width_Int, height_Int);
        }

        /// <summary>
        /// Generates a URL for orthophoto data based on a bounding box, year, and specific pixel dimensions.
        /// </summary>
        /// <param name="boundingBox2D">The bounding box defining the geographic area.</param>
        /// <param name="year">The year of the orthophoto data to retrieve.</param>
        /// <param name="width">The width of the requested image in pixels.</param>
        /// <param name="height">The height of the requested image in pixels.</param>
        /// <returns>A string containing the constructed URL, or null if the bounding box is null.</returns>
        public static string? Url_OrtoData(this BoundingBox2D? boundingBox2D, int year, int width, int height)
        {
            if (boundingBox2D == null)
            {
                return null;
            }

            Point2D min = boundingBox2D.Min;
            Point2D max = boundingBox2D.Max;

            return string.Format("https://mapy.geoportal.gov.pl/wss/service/PZGIK/ORTO/WMS/StandardResolutionTime?REQUEST=GetMap&TRANSPARENT=TRUE&FORMAT=image%2Fjpeg&VERSION=1.1.0&LAYERS=Raster&STYLES=&EXCEPTIONS=application%2Fvnd.ogc.se_xml&TIME={0}&SRS=EPSG:2180&width={1}&height={2}&SERVICE=WMS&BBOX={3},{4},{5},{6}", year, width, height, min.X.ToString(CultureInfo.InvariantCulture), min.Y.ToString(CultureInfo.InvariantCulture), max.X.ToString(CultureInfo.InvariantCulture), max.Y.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Generates a URL for querying elevation data for a given 2D point from the GUGiK API.
        /// </summary>
        /// <param name="point2D">The 2D point for which to retrieve elevation.</param>
        /// <returns>A string containing the constructed elevation query URL, or null if the point is null.</returns>
        public static string? Url_Elevation(this Point2D? point2D)
        {
            if (point2D == null)
            {
                return null;
            }

            double easting = point2D.X;
            double northing = point2D.Y;

            // In EPSG:2180 (PL-1992), if X represents Northing (e.g. > 550,000 while Y < 550,000), swap them so parameter x receives Easting and parameter y receives Northing.
            if (point2D.X > 550000 && point2D.Y < 550000)
            {
                easting = point2D.Y;
                northing = point2D.X;
            }

            string string_X = easting.ToString(CultureInfo.InvariantCulture);
            string string_Y = northing.ToString(CultureInfo.InvariantCulture);

            return $"https://services.gugik.gov.pl/nmt/?request=GetHByXY&x={string_X}&y={string_Y}";
        }
    }
}