using DiGi.Core.Relation.Classes;
using DiGi.GIS.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public class Building2DConstructionDateCalculationResultRelation : OneToManyDirectionalRelation<Building2D, Building2DConstructionDateCalculationResult>, IGISRelation
    {
        public Building2DConstructionDateCalculationResultRelation(Building2D building2D, IEnumerable<Building2DConstructionDateCalculationResult> constructionDateCalculationResults) 
            : base(building2D, constructionDateCalculationResults)
        {
        }

        public Building2DConstructionDateCalculationResultRelation(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public Building2DConstructionDateCalculationResultRelation(Building2DConstructionDateCalculationResultRelation building2DConstructionDateCalculationResultRelation)
            : base(building2DConstructionDateCalculationResultRelation)
        {
        }
    }
}
