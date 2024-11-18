using DiGi.Core.Relation.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public class Building2DOccupancyCalculationResultRelation : OneToOneDirectionalRelation<Building2D, OccupancyCalculationResult>, IGISRelation
    {
        public Building2DOccupancyCalculationResultRelation(Building2D building2D, OccupancyCalculationResult occupancyCalculationResult) 
            : base(building2D, occupancyCalculationResult)
        {
        }

        public Building2DOccupancyCalculationResultRelation(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public Building2DOccupancyCalculationResultRelation(Building2DOccupancyCalculationResultRelation building2DOccupancyCalculationResultRelation)
            : base(building2DOccupancyCalculationResultRelation)
        {
        }
    }
}
