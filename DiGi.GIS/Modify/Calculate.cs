using DiGi.GIS.Classes;

namespace DiGi.GIS
{
    public static partial class Modify
    {
        public static void Calculate(this GISModel gISModel, double tolerance = Core.Constans.Tolerance.Distance)
        {
            if(gISModel == null)
            {
                return;
            }

            CalculateBuilding2DGeometries(gISModel, tolerance);
            CalculateAdministrativeAreal2DGeometries(gISModel, tolerance);
            CalculateAdministrativeAreal2DBuilding2Ds(gISModel, tolerance);
        }
    }
}

