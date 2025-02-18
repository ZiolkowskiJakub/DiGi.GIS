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

        /// <summary>
        /// Max file size in bytes. ulong.MaxValue value will keep one file
        /// </summary>
        [JsonInclude, JsonPropertyName("MaxFileSize")]
        public ulong MaxFileSize { get; set; } = ulong.MaxValue;

        public OrtoDatasOptions(Range<int> years, double offset, double width, bool reduce, ulong maxFileSize)
            : base()
        {
            Years = years;
            Width = width;
            Offset = offset;
            Reduce = reduce;
            MaxFileSize = maxFileSize;
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
                MaxFileSize = ortoDatasOptions.MaxFileSize;
            }
        }

        public OrtoDatasOptions(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}

