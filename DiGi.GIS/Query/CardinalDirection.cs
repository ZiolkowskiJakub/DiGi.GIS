using DiGi.GIS.Enums;

namespace DiGi.GIS
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the cardinal direction for a given azimuth angle.
        /// </summary>
        /// <param name="azimuth">The azimuth angle in degrees, typically ranging from 0 to 360.</param>
        /// <returns>The corresponding <see cref="Enums.CardinalDirection"/> based on the provided azimuth.</returns>
        public static CardinalDirection CardinalDirection(this double azimuth)
        {
            if (double.IsNaN(azimuth))
            {
                return Enums.CardinalDirection.Undefined;
            }

            //double normalizedAzimuth = ((azimuth % 360) + 360) % 360;

            // Each direction covers 45°, centered on its main bearing
            // e.g. North is centered at 0°, NE at 45°, etc.
            if (azimuth >= 337.5 || azimuth < 22.5)
            {
                return Enums.CardinalDirection.North;
            }

            if (azimuth < 67.5)
            {
                return Enums.CardinalDirection.NorthEast;
            }

            if (azimuth < 112.5)
            {
                return Enums.CardinalDirection.East;
            }

            if (azimuth < 157.5)
            {
                return Enums.CardinalDirection.SouthEast;
            }

            if (azimuth < 202.5)
            {
                return Enums.CardinalDirection.South;
            }
            if (azimuth < 247.5)
            {
                return Enums.CardinalDirection.SouthWest;
            }

            if (azimuth < 292.5)
            {
                return Enums.CardinalDirection.West;
            }

            if (azimuth < 337.5)
            {
                return Enums.CardinalDirection.NorthWest;
            }

            return Enums.CardinalDirection.Undefined;
        }
    }
}