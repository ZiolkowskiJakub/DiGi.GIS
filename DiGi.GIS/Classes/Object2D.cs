using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Core.Classes;

namespace DiGi.GIS.Classes
{
    public abstract class Object2D : UniqueObject
    {
        [JsonInclude, JsonPropertyName("Reference")]
        private string reference = null;

        public Object2D(Guid guid, string reference)
            : base(guid)
        {
            this.reference = reference;
        }

        public Object2D(Object2D object2D)
            : base(object2D == null ? Guid.Empty : object2D.Guid)
        {
            if(object2D != null)
            {
                reference = object2D.reference;
            }
        }

        public Object2D(JsonObject jsonObject)
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
