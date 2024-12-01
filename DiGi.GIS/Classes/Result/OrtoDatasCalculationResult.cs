using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public class OrtoDatasCalculationResult : UniqueResult<Building2D>, IGISUniqueResult
    {
        [JsonInclude, JsonPropertyName("Reference")]
        private InstanceRelatedExternalReference reference = null;

        public OrtoDatasCalculationResult(InstanceRelatedExternalReference reference)
            :base()
        {
            this.reference = reference;
        }

        public OrtoDatasCalculationResult(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public OrtoDatasCalculationResult(OrtoDatasCalculationResult ortoDatasCalculationResult)
            : base(ortoDatasCalculationResult)
        {
            if(ortoDatasCalculationResult != null)
            {
                reference = ortoDatasCalculationResult.reference;
            }
        }

        [JsonIgnore]
        public InstanceRelatedExternalReference Reference
        {
            get
            {
                return reference;
            }
        }
    }
}
