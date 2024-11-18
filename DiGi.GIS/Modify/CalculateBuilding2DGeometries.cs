using DiGi.GIS.Classes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiGi.GIS
{
    public static partial class Modify
    {
        public static void CalculateBuilding2DGeometries(this GISModel gISModel, double tolerance = Core.Constans.Tolerance.Distance)
        {
            List<Building2D> building2Ds = gISModel?.GetObjects<Building2D>();
            if (building2Ds == null)
            {
                return;
            }

            for (int i = 0; i < building2Ds.Count; i++)
            {
                Building2D building2D = building2Ds[i];

                Building2DGeometryCalculationResult building2DGeometryCalculationResult = Create.Building2DGeometryCalculationResult(building2D, tolerance);
                if (building2DGeometryCalculationResult == null)
                {
                    continue;
                }

                gISModel.Update(building2D, building2DGeometryCalculationResult);

            }
        }
    }
}

