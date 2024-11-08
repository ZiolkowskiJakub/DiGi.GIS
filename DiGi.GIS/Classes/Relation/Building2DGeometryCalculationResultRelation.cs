using DiGi.Core.Relation.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public class Building2DGeometryCalculationResultRelation : OneToOneDirectionalRelation<Building2D, Building2DGeometryCalculationResult>, IGISRelation
    {
        public Building2DGeometryCalculationResultRelation(Building2D building2D, Building2DGeometryCalculationResult building2DGeometryCalculationResult) 
            : base(building2D, building2DGeometryCalculationResult)
        {
        }

        public Building2DGeometryCalculationResultRelation(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public Building2DGeometryCalculationResultRelation(Building2DGeometryCalculationResultRelation building2DGeometryCalculationResultRelation)
            : base(building2DGeometryCalculationResultRelation)
        {
        }
    }
}
