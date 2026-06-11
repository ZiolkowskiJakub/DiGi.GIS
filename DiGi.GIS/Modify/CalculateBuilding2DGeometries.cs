using DiGi.GIS.Classes;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Modify
    {
        /// <summary>
        /// Calculates the 2D geometries for all building objects within the provided GIS model.
        /// </summary>
        /// <param name="gISModel">The GIS model containing the buildings to process.</param>
        /// <param name="tolerance">The distance tolerance used during geometry calculation.</param>
        public static void CalculateBuilding2DGeometries(this GISModel? gISModel, double tolerance = Core.Constants.Tolerance.Distance)
        {
            List<Building2D>? building2Ds = gISModel?.GetObjects<Building2D>();
            if (building2Ds == null)
            {
                return;
            }

            for (int i = 0; i < building2Ds.Count; i++)
            {
                Building2D building2D = building2Ds[i];

                Building2DGeometryCalculationResult? building2DGeometryCalculationResult = Create.Building2DGeometryCalculationResult(building2D, tolerance);
                if (building2DGeometryCalculationResult == null)
                {
                    continue;
                }

                gISModel!.Update(building2D, building2DGeometryCalculationResult);
            }
        }
    }
}