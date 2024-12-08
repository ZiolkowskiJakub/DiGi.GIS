using DiGi.Core.Relation.Classes;
using DiGi.GIS.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public class ConstructionDateCalculationResultRelation : OneToManyDirectionalRelation<Building2D, ConstructionDateCalculationResult>, IGISRelation
    {
        public ConstructionDateCalculationResultRelation(Building2D building2D, IEnumerable<ConstructionDateCalculationResult> constructionDateCalculationResults) 
            : base(building2D, constructionDateCalculationResults)
        {
        }

        public ConstructionDateCalculationResultRelation(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public ConstructionDateCalculationResultRelation(ConstructionDateCalculationResultRelation constructionDateCalculationResultRelation)
            : base(constructionDateCalculationResultRelation)
        {
        }
    }
}
