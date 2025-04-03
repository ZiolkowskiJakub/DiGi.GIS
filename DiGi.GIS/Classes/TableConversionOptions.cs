using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Core.Classes;

namespace DiGi.GIS.Classes
{
    public class TableConversionOptions : SerializableObject
    {
        [JsonInclude, JsonPropertyName("IncludeModel")]
        public bool IncludeModel { get; set; } = true;
        
        [JsonInclude, JsonPropertyName("IncludeStatistical")]
        public bool IncludeStatistical { get; set; } = true;

        [JsonInclude, JsonPropertyName("IncludeYearBuiltData")]
        public bool IncludeYearBuilt { get; set; } = true;

        [JsonInclude, JsonPropertyName("IncludeOrtoDatasComparison")]
        public bool IncludeOrtoDatasComparison { get; set; } = true;

        [JsonInclude, JsonPropertyName("Years")]
        public Range<int> Years { get; set; } = new Range<int>(2008, System.DateTime.Now.Year);

        [JsonInclude, JsonPropertyName("StatisticalDirectory")]
        public string StatisticalDirectory { get; set; } = null;

        public TableConversionOptions()
        {

        }

        public TableConversionOptions(TableConversionOptions tableConversionOptions)
        {

        }

        public TableConversionOptions(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

    }
}
