using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;

namespace DiGi.GIS.Classes
{
    public class IndexData : UniqueObject, IGISUniqueObject
    {
        [JsonInclude, JsonPropertyName("Index")]
        private int index;

        [JsonInclude, JsonPropertyName("Reference")]
        private string reference;

        [JsonInclude, JsonPropertyName("Name")]
        private string name;

        public IndexData(int index, string reference, string name)
            : base()
        {
            this.index = index;
            this.reference = reference;
            this.name = name;
        }

        public IndexData(IndexData indexData)
            : base(indexData)
        {
            if(indexData != null)
            {
                index = indexData.index;
                reference = indexData.reference;
                name = indexData.name;
            }
        }

        public IndexData(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        [JsonIgnore]
        public int Index
        {
            get
            {
                return Index;
            }
        }

        [JsonIgnore]
        public string Reference
        {
            get
            {
                return reference;
            }
        }

        [JsonIgnore]
        public string Name
        {
            get
            {
                return name;
            }
        }

        [JsonIgnore]
        public override string UniqueId
        {
            get
            {
                return index.ToString();
            }
        }

        public override string ToString()
        {
            return string.Join("\t", index.ToString(), reference == null ? string.Empty : reference, name == null ? string.Empty : name);
        }
    }
}
