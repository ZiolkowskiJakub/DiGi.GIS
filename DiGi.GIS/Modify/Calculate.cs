using DiGi.GIS.Classes;

namespace DiGi.GIS
{
    public static partial class Modify
    {
        /// <summary>
        /// Calculates various 2D geometries and occupancy for the provided GIS model based on a specified tolerance.
        /// </summary>
        /// <param name="gISModel">The GIS model instance to perform calculations on.</param>
        /// <param name="tolerance">The distance tolerance used during geometry calculations. Defaults to Core.Constants.Tolerance.Distance.</param>
        public static void Calculate(this GISModel gISModel, double tolerance = Core.Constants.Tolerance.Distance)
        {
            if (gISModel == null)
            {
                return;
            }

            CalculateBuilding2DGeometries(gISModel, tolerance);

            CalculateAdministrativeAreal2DGeometries(gISModel, tolerance);

            CalculateAdministrativeAreal2DAdministrativeAreal2Ds(gISModel, tolerance);

            CalculateAdministrativeAreal2DBuilding2Ds(gISModel, tolerance);

            CalculateOccupancy(gISModel);
        }
    }
}