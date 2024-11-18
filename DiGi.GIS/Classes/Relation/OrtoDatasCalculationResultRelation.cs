using DiGi.Core.Relation.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public class OrtoDatasCalculationResultRelation : OneToOneBidirectionalRelation<Building2D, OrtoDatasCalculationResult>, IGISRelation
    {
        public OrtoDatasCalculationResultRelation(Building2D building2D, OrtoDatasCalculationResult ortoDatasCalculationResult) 
            : base(building2D, ortoDatasCalculationResult)
        {
        }

        public OrtoDatasCalculationResultRelation(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public OrtoDatasCalculationResultRelation(OrtoDatasCalculationResultRelation ortoDatasCalculationResultRelation)
            : base(ortoDatasCalculationResultRelation)
        {
        }
    }
}
