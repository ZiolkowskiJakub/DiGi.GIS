using DiGi.GIS.Classes;
using DiGi.GIS.Enums;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static bool IsResidential(this Building2D? building2D)
        {
            if (building2D == null)
            {
                return false;
            }

            if (building2D.BuildingGeneralFunction == BuildingGeneralFunction.residential_buildings)
            {
                return true;
            }

            if (building2D.BuildingSpecificFunctions == null)
            {
                return false;
            }

            if (building2D.BuildingSpecificFunctions.Contains(BuildingSpecificFunction.single_family_building) || building2D.BuildingSpecificFunctions.Contains(BuildingSpecificFunction.multi_family_building))
            {
                return true;
            }

            return false;
        }
    }
}