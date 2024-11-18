using DiGi.Core.Classes;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public class OrtoDataOptions : ExtractOptions
    {
        [JsonInclude, JsonPropertyName("Offset")]
        public double Offset { get; set; } = 5;

        [JsonInclude, JsonPropertyName("Width")]
        public double Width { get; set; } = 300;

        [JsonInclude, JsonPropertyName("Years")]
        public Range<int> Years { get; set; } = new Range<int>(2008, DateTime.Now.Year);

        public OrtoDataOptions(Range<int> years, double offset, double width)
            : base()
        {
            Years = years;
            Width = width;
            Offset = offset;
        }

        public OrtoDataOptions()
            : base()
        {

        }

        public OrtoDataOptions(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
