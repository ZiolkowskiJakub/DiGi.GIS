using DiGi.Core.Relation.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public class AdministrativeAreal2DGeometryCalculationResultRelation : OneToOneDirectionalRelation<AdministrativeAreal2D, AdministrativeAreal2DGeometryCalculationResult>, IGISRelation
    {
        public AdministrativeAreal2DGeometryCalculationResultRelation(AdministrativeAreal2D administrativeAreal2D, AdministrativeAreal2DGeometryCalculationResult administrativeAreal2DGeometryCalculationResult) 
            : base(administrativeAreal2D, administrativeAreal2DGeometryCalculationResult)
        {
        }

        public AdministrativeAreal2DGeometryCalculationResultRelation(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public AdministrativeAreal2DGeometryCalculationResultRelation(AdministrativeAreal2DGeometryCalculationResultRelation building2DGeometryCalculationResultRelation)
            : base(building2DGeometryCalculationResultRelation)
        {
        }
    }
}
