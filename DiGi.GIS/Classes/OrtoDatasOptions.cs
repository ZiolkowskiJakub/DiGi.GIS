using DiGi.Core.Classes;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public abstract class OrtoDatasOptions : ExtractOptions
    {
        [JsonInclude, JsonPropertyName("Years")]
        public Range<int> Years { get; set; } = new Range<int>(2008, DateTime.Now.Year);

        [JsonInclude, JsonPropertyName("Reduce")]
        public bool Reduce { get; set; } = true;

        /// <summary>
        /// Max file size in bytes. ulong.MaxValue value will keep one file
        /// </summary>
        [JsonInclude, JsonPropertyName("MaxFileSize")]
        public ulong MaxFileSize { get; set; } = ulong.MaxValue;

        public OrtoDatasOptions(Range<int> years, bool reduce, ulong maxFileSize)
            : base()
        {
            Years = years;
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

