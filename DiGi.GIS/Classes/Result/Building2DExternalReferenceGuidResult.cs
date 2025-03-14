using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public abstract class Building2DExternalReferenceGuidResult : ExternalReferenceGuidResult<Building2D, InstanceRelatedExternalReference>, IGISGuidResult
    {
        public Building2DExternalReferenceGuidResult(InstanceRelatedExternalReference reference)
            : base(reference)
        {

        }

        public Building2DExternalReferenceGuidResult(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Building2DExternalReferenceGuidResult(Building2DExternalReferenceGuidResult building2DExternalReferenceGuidResult)
            : base(building2DExternalReferenceGuidResult)
        {

        }
    }
}
