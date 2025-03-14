using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public abstract class AdministrativeAreal2DExternalReferenceGuidResult : ExternalReferenceGuidResult<AdministrativeAreal2D, InstanceRelatedExternalReference>, IGISGuidResult
    {
        public AdministrativeAreal2DExternalReferenceGuidResult(InstanceRelatedExternalReference reference)
            : base(reference)
        {

        }

        public AdministrativeAreal2DExternalReferenceGuidResult(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public AdministrativeAreal2DExternalReferenceGuidResult(AdministrativeAreal2DExternalReferenceGuidResult administrativeAreal2DExternalReferenceGuidResult)
            : base(administrativeAreal2DExternalReferenceGuidResult)
        {

        }
    }
}