using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.GIS
{
    public static partial class Query
    {
        /// <summary>
        /// Converts a point from EPSG:2180 to WGS 84 geographic coordinates.
        /// <para>The converted point carries the longitude as X and the latitude as Y, so the <see cref="Coordinates"/> take the latitude first. This method exists so the latitude/longitude swap lives in one place; callers that only need the converted point call ToEPSG4326.</para>
        /// </summary>
        /// <param name="point2D">The point in the EPSG:2180 coordinate system.</param>
        /// <returns>The WGS 84 coordinates of the point, or <see langword="null"/> if the point is null or the conversion fails.</returns>
        public static Coordinates? Coordinates(this Point2D? point2D)
        {
            Point3D? point3D = Convert.ToEPSG4326(point2D);
            if (point3D is null)
            {
                return null;
            }

            return new Coordinates(point3D.Y, point3D.X);
        }
    }
}