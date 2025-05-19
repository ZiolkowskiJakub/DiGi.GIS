using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public class ComparisonTableConversionOptions : TableConversionOptions
    {
        [JsonInclude, JsonPropertyName("IncludeOrtoDatasComparison")]
        public bool IncludeOrtoDatasComparison { get; set; } = true;

        public ComparisonTableConversionOptions()
            :base()
        {

        }

        public ComparisonTableConversionOptions(ComparisonTableConversionOptions comparisonTableConversionOptions)
            : base(comparisonTableConversionOptions)
        {
            if(comparisonTableConversionOptions != null)
            {
                IncludeOrtoDatasComparison = comparisonTableConversionOptions.IncludeOrtoDatasComparison;
            }
        }

        public ComparisonTableConversionOptions(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

    }
}
