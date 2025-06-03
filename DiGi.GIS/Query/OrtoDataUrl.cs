using DiGi.Geometry.Planar.Classes;
using System.Globalization;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static string OrtoDataUrl(this BoundingBox2D boundingBox2D, int year, double scale)
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

            return OrtoDataUrl(boundingBox2D, year, width_Int, height_Int);
        }

        public static string OrtoDataUrl(this BoundingBox2D boundingBox2D, int year, int width, int height)
        {
            if(boundingBox2D == null)
            {
                return null;
            }

            Point2D min = boundingBox2D.Min;
            Point2D max = boundingBox2D.Max;

            return string.Format("https://mapy.geoportal.gov.pl/wss/service/PZGIK/ORTO/WMS/StandardResolutionTime?REQUEST=GetMap&TRANSPARENT=TRUE&FORMAT=image%2Fjpeg&VERSION=1.1.0&LAYERS=Raster&STYLES=&EXCEPTIONS=application%2Fvnd.ogc.se_xml&TIME={0}&SRS=EPSG:2180&width={1}&height={2}&SERVICE=WMS&BBOX={3},{4},{5},{6}", year, width, height, min.X.ToString(CultureInfo.InvariantCulture), min.Y.ToString(CultureInfo.InvariantCulture), max.X.ToString(CultureInfo.InvariantCulture), max.Y.ToString(CultureInfo.InvariantCulture));
        }
    }
}

