using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public abstract class StatisticalData : SerializableObject, IStatisticalData
    {
        [JsonInclude, JsonPropertyName("Name")]
        private string name;

        [JsonInclude, JsonPropertyName("Reference")]
        private string reference = null;


        public StatisticalData(string name, string reference)
            : base()
        {
            this.name = name;
            this.reference = reference;
        }

        public StatisticalData(StatisticalData statisticalData)
            : base(statisticalData)
        {
            if(statisticalData != null)
            {
                name = statisticalData.name;
                reference = statisticalData.reference;
            }
        }

        public StatisticalData(JsonObject jsonObject)
            : base(jsonObject)
        {

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
        public string Reference
        {
            get
            {
                return reference;
            }
        }
    }
}
