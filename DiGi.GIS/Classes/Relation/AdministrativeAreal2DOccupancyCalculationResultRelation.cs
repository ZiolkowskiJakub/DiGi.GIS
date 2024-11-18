using DiGi.Core.Relation.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public class AdministrativeAreal2DOccupancyCalculationResultRelation : OneToOneDirectionalRelation<AdministrativeAreal2D, OccupancyCalculationResult>, IGISRelation
    {
        public AdministrativeAreal2DOccupancyCalculationResultRelation(AdministrativeAreal2D administrativeAreal2D, OccupancyCalculationResult occupancyCalculationResult) 
            : base(administrativeAreal2D, occupancyCalculationResult)
        {
        }

        public AdministrativeAreal2DOccupancyCalculationResultRelation(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public AdministrativeAreal2DOccupancyCalculationResultRelation(AdministrativeAreal2DOccupancyCalculationResultRelation administrativeAreal2DOccupancyCalculationResultRelation)
            : base(administrativeAreal2DOccupancyCalculationResultRelation)
        {
        }
    }
}
