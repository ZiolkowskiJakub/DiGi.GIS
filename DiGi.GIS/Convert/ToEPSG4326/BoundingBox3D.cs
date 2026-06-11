using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Spatial.Classes;

namespace DiGi.GIS
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a 2D bounding box to a 3D bounding box in the EPSG:4326 coordinate system.
        /// </summary>
        /// <param name="boundingBox2D">The 2D bounding box to convert.</param>
        /// <returns>A <see cref="BoundingBox3D"/> representing the converted coordinates, or <see langword="null"/> if the input bounding box is null.</returns>
        public static BoundingBox3D? ToEPSG4326(this BoundingBox2D? boundingBox2D)
        {
            if (boundingBox2D == null)
            {
                return null;
            }

            return new BoundingBox3D(boundingBox2D.Min.ToEPSG4326(), boundingBox2D.Max.ToEPSG4326());
        }
    }
}