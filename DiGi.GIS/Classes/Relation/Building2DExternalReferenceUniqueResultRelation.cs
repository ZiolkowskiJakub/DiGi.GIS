using DiGi.Core.Relation.Classes;
using DiGi.GIS.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public class Building2DExternalReferenceUniqueResultRelation : OneToManyBidirectionalRelation<Building2D, Building2DExternalReferenceGuidResult>, IGISRelation
    {
        public Building2DExternalReferenceUniqueResultRelation(Building2D building2D, IEnumerable<Building2DExternalReferenceGuidResult> building2DExternalReferenceUniqueResults) 
            : base(building2D, building2DExternalReferenceUniqueResults)
        {
        }

        public Building2DExternalReferenceUniqueResultRelation(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public Building2DExternalReferenceUniqueResultRelation(Building2DExternalReferenceUniqueResultRelation ortoDatasCalculationResultRelation)
            : base(ortoDatasCalculationResultRelation)
        {
        }
    }
}
