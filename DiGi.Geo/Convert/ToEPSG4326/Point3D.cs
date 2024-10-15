using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Spatial.Classes;
using GeoAPI.CoordinateSystems;
using ProjNet.CoordinateSystems.Transformations;
using ProjNet.CoordinateSystems;
using GeoAPI.CoordinateSystems.Transformations;

namespace DiGi.Geo
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts from EPSG:2180 to EPSG:4326 Coordinate System 
        /// </summary>
        /// <param name="point2D">Point2D in EPSG:2180 Coordinate System</param>
        /// <returns>Point3D in EPSG:4326 Coordinate System</returns>
        public static Point3D ToEPSG4326(this Point2D point2D)
        {
            CoordinateSystemFactory coordinateSystemFactory = new CoordinateSystemFactory();
            ICoordinateSystem coordinateSystem_EPSG2180 = coordinateSystemFactory.CreateFromWkt("PROJCS[\"ETRS89 / Poland CS92\",GEOGCS[\"ETRS89\",DATUM[\"European_Terrestrial_Reference_System_1989\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6258\"]],PRIMEM[\"Greenwich\",0],UNIT[\"degree\",0.0174532925199433],AUTHORITY[\"EPSG\",\"4258\"]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",0],PARAMETER[\"central_meridian\",19],PARAMETER[\"scale_factor\",0.9993],PARAMETER[\"false_easting\",500000],PARAMETER[\"false_northing\",-5300000],UNIT[\"metre\",1,AUTHORITY[\"EPSG\",\"9001\"]],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH],AUTHORITY[\"EPSG\",\"2180\"]]");

            IGeographicCoordinateSystem geographicCoordinateSystem_EPSG4326 = coordinateSystemFactory.CreateGeographicCoordinateSystem("WGS 84", AngularUnit.Degrees, HorizontalDatum.WGS84, PrimeMeridian.Greenwich, new AxisInfo("Longitude", AxisOrientationEnum.East), new AxisInfo("Latitude", AxisOrientationEnum.North));

            CoordinateTransformationFactory coordinateTransformationFactory = new CoordinateTransformationFactory();
            ICoordinateTransformation coordinateTransformation = coordinateTransformationFactory.CreateFromCoordinateSystems(coordinateSystem_EPSG2180, geographicCoordinateSystem_EPSG4326);

            double[] values = coordinateTransformation.MathTransform.Transform(new double[] { point2D.X, point2D.Y });
            if (values == null)
            {
                return null;
            }

            return new Point3D(values[0], values[1], values[2]);
        }
    }
}

