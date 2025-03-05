using DiGi.GIS.Classes;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Modify
    {
        public static void CalculateAdministrativeAreal2DGeometries(this GISModel gISModel, double tolerance = Core.Constans.Tolerance.Distance)
        {
            List<AdministrativeAreal2D> administrativeAreal2Ds = gISModel?.GetObjects<AdministrativeAreal2D>();
            if(administrativeAreal2Ds == null)
            {
                return;
            }

            for (int i = 0; i < administrativeAreal2Ds.Count; i++)
            {
                AdministrativeAreal2D administrativeAreal2D = administrativeAreal2Ds[i];

                AdministrativeAreal2DGeometryCalculationResult administrativeAreal2DGeometryCalculationResult = Create.AdministrativeAreal2DGeometryCalculationResult(administrativeAreal2D, tolerance);
                if (administrativeAreal2DGeometryCalculationResult == null)
                {
                    continue;
                }

                gISModel.Update(administrativeAreal2D, administrativeAreal2DGeometryCalculationResult);

            }
        }
    }
}

