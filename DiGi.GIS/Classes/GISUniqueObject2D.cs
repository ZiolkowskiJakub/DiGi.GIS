using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;

namespace DiGi.GIS.Classes
{
    public abstract class GISUniqueObject2D : UniqueObject, IGISUniqueObject2D
    {
        [JsonInclude, JsonPropertyName("Reference")]
        private string reference = null;

        public GISUniqueObject2D(Guid guid, string reference)
            : base(guid)
        {
            this.reference = reference;
        }

        public GISUniqueObject2D(GISUniqueObject2D object2D)
            : base(object2D == null ? Guid.Empty : object2D.Guid)
        {
            if(object2D != null)
            {
                reference = object2D.reference;
            }
        }

        public GISUniqueObject2D(JsonObject jsonObject)
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
