using DiGi.Core.Classes;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public class OrtoDatasOptions : ExtractOptions
    {
        [JsonInclude, JsonPropertyName("Offset")]
        public double Offset { get; set; } = 5;

        [JsonInclude, JsonPropertyName("Width")]
        public double Width { get; set; } = 300;

        [JsonInclude, JsonPropertyName("Years")]
        public Range<int> Years { get; set; } = new Range<int>(2008, DateTime.Now.Year);

        [JsonInclude, JsonPropertyName("Reduce")]
        public bool Reduce { get; set; } = true;

        public OrtoDatasOptions(Range<int> years, double offset, double width, bool reduce)
            : base()
        {
            Years = years;
            Width = width;
            Offset = offset;
            Reduce = reduce;
        }

        public OrtoDatasOptions()
            : base()
        {

        }

        public OrtoDatasOptions(OrtoDatasOptions ortoDatasOptions)
            : base(ortoDatasOptions)
        {
            if (ortoDatasOptions != null)
            {
                Years = ortoDatasOptions.Years;
                Width = ortoDatasOptions.Width;
                Offset = ortoDatasOptions.Offset;
                Reduce = ortoDatasOptions.Reduce;
            }
        }

        public OrtoDatasOptions(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}

