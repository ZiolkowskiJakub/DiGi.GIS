using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;

namespace DiGi.GIS.Classes
{
    public class YearBuiltData : SerializableObject, IYearBuiltData
    {
        [JsonInclude, JsonPropertyName("Reference")]
        private string reference;

        [JsonInclude, JsonPropertyName("Year")]
        private short year;

        public YearBuiltData(string reference, short year)
        {
            this.reference = reference;
            this.year = year;
        }

        public YearBuiltData(YearBuiltData yearBuiltData)
        {
            if (yearBuiltData != null)
            {
                reference = yearBuiltData.reference;
                year = yearBuiltData.year;
            }
        }

        public YearBuiltData(JsonObject jsonObject)
            : base(jsonObject)
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

        [JsonIgnore]
        public short Year
        {
            get
            {
                return year;
            }
        }
    }
}
