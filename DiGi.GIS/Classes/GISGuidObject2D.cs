using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;

namespace DiGi.GIS.Classes
{
    public abstract class GISGuidObject2D : GuidObject, IGISGuidObject2D
    {
        [JsonInclude, JsonPropertyName("Reference")]
        private string reference = null;

        public GISGuidObject2D(Guid guid, string reference)
            : base(guid)
        {
            this.reference = reference;
        }

        public GISGuidObject2D(GISGuidObject2D gISGuidObject2D)
            : base(gISGuidObject2D == null ? Guid.Empty : gISGuidObject2D.Guid)
        {
            if(gISGuidObject2D != null)
            {
                reference = gISGuidObject2D.reference;
            }
        }

        public GISGuidObject2D(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        [JsonIgnore]
        public string Reference
        {
            get
            {
                return reference;
            }
        }

    }
}
