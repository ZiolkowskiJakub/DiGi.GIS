using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Spatial.Classes;
using GeoAPI.CoordinateSystems;
using GeoAPI.CoordinateSystems.Transformations;
using ProjNet.CoordinateSystems;
using ProjNet.CoordinateSystems.Transformations;

namespace DiGi.GIS
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a 3D point from geographic coordinates (WGS 84) to the Polish coordinate system EPSG:2180.
        /// </summary>
        /// <param name="point3D">The source 3D point to be converted.</param>
        /// <returns>A 2D point in the EPSG:2180 coordinate system, or null if the input point is null or conversion fails.</returns>
        public static Point2D? ToEPSG2180(this Point3D? point3D)
        {
            if (point3D == null)
            {
                return null;
            }

            CoordinateSystemFactory coordinateSystemFactory = new();
            ICoordinateSystem coordinateSystem_EPSG2180 = coordinateSystemFactory.CreateFromWkt("PROJCS[\"ETRS89 / Poland CS92\",GEOGCS[\"ETRS89\",DATUM[\"European_Terrestrial_Reference_System_1989\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6258\"]],PRIMEM[\"Greenwich\",0],UNIT[\"degree\",0.0174532925199433],AUTHORITY[\"EPSG\",\"4258\"]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",0],PARAMETER[\"central_meridian\",19],PARAMETER[\"scale_factor\",0.9993],PARAMETER[\"false_easting\",500000],PARAMETER[\"false_northing\",-5300000],UNIT[\"metre\",1,AUTHORITY[\"EPSG\",\"9001\"]],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH],AUTHORITY[\"EPSG\",\"2180\"]]");

            IGeographicCoordinateSystem geographicCoordinateSystem_EPSG4326 = coordinateSystemFactory.CreateGeographicCoordinateSystem("WGS 84", AngularUnit.Degrees, HorizontalDatum.WGS84, PrimeMeridian.Greenwich, new AxisInfo("Longitude", AxisOrientationEnum.East), new AxisInfo("Latitude", AxisOrientationEnum.North));

            CoordinateTransformationFactory coordinateTransformationFactory = new();
            ICoordinateTransformation coordinateTransformation = coordinateTransformationFactory.CreateFromCoordinateSystems(geographicCoordinateSystem_EPSG4326, coordinateSystem_EPSG2180);

            double[] values = coordinateTransformation.MathTransform.Transform([point3D.X, point3D.Y]);
            if (values == null)
            {
                return null;
            }

            return new Point2D(values[0], values[1]);
        }
    }
}