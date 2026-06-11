using DiGi.GIS.Classes;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Modify
    {
        /// <summary>
        /// Calculates the 2D geometries for administrative areal objects within the provided GIS model.
        /// </summary>
        /// <param name="gISModel">The GIS model containing the administrative areal objects to be processed.</param>
        /// <param name="tolerance">The distance tolerance used during the geometry calculation process.</param>
        public static void CalculateAdministrativeAreal2DGeometries(this GISModel gISModel, double tolerance = Core.Constants.Tolerance.Distance)
        {
            List<AdministrativeAreal2D>? administrativeAreal2Ds = gISModel?.GetObjects<AdministrativeAreal2D>();
            if (administrativeAreal2Ds == null)
            {
                return;
            }

            for (int i = 0; i < administrativeAreal2Ds.Count; i++)
            {
                AdministrativeAreal2D administrativeAreal2D = administrativeAreal2Ds[i];

                AdministrativeAreal2DGeometryCalculationResult? administrativeAreal2DGeometryCalculationResult = Create.AdministrativeAreal2DGeometryCalculationResult(administrativeAreal2D, tolerance);
                if (administrativeAreal2DGeometryCalculationResult == null)
                {
                    continue;
                }

                gISModel!.Update(administrativeAreal2D, administrativeAreal2DGeometryCalculationResult);
            }
        }
    }
}