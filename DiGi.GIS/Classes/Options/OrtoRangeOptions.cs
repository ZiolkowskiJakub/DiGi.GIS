using DiGi.Core.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public class OrtoRangeOptions : Options
    {
        [JsonInclude, JsonPropertyName("Width")]
        public double Width { get; set; } = 300;

        [JsonInclude, JsonPropertyName("Height")]
        public double Height { get; set; } = 300;

        public OrtoRangeOptions(double width, double height)
            : base()
        {
            Width = width;
            Height = height;
        }

        public OrtoRangeOptions()
            : base()
        {

        }

        public OrtoRangeOptions(OrtoRangeOptions ortoRangeOptions)
            : base(ortoRangeOptions)
        {
            if (ortoRangeOptions != null)
            {
                Width = ortoRangeOptions.Width;
                Height = ortoRangeOptions.Height;
            }
        }

        public OrtoRangeOptions(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}

