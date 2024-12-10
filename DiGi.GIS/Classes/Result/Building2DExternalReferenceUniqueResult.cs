using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public abstract class Building2DExternalReferenceUniqueResult : ExternalReferenceUniqueResult<Building2D, InstanceRelatedExternalReference>, IGISUniqueResult
    {
        public Building2DExternalReferenceUniqueResult(InstanceRelatedExternalReference reference)
            :base(reference)
        {

        }

        public Building2DExternalReferenceUniqueResult(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Building2DExternalReferenceUniqueResult(Building2DExternalReferenceUniqueResult building2DExternalReferenceUniqueResult)
            : base(building2DExternalReferenceUniqueResult)
        {

        }
    }
}
