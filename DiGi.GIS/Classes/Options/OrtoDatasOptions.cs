using DiGi.Core.Classes;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Provides options for configuring orthophoto data retrieval and processing settings.
    /// </summary>
    public abstract class OrtoDatasOptions : DirectoryNamesOptions
    {
        /// <summary>
        /// Gets or sets the range of years to be considered for orthophoto data.
        /// </summary>
        [JsonInclude, JsonPropertyName("Years")]
        public Range<int> Years { get; set; } = new Range<int>(2008, DateTime.Now.Year);

        /// <summary>
        /// Gets or sets a value indicating whether to reduce the data size or resolution.
        /// </summary>
        [JsonInclude, JsonPropertyName("Reduce")]
        public bool Reduce { get; set; } = true;

        /// <summary>
        /// Max file size in bytes. ulong.MaxValue value will keep one file
        /// </summary>
        [JsonInclude, JsonPropertyName("MaxFileSize")]
        public ulong MaxFileSize { get; set; } = ulong.MaxValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoDatasOptions"/> class with specified years, reduction flag, and maximum file size.
        /// </summary>
        /// <param name="years">The range of years to be considered.</param>
        /// <param name="reduce">A value indicating whether to reduce data.</param>
        /// <param name="maxFileSize">The maximum allowed file size in bytes.</param>
        public OrtoDatasOptions(Range<int> years, bool reduce, ulong maxFileSize)
            : base()
        {
            Years = years;
            Reduce = reduce;
            MaxFileSize = maxFileSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoDatasOptions"/> class.
        /// </summary>
        public OrtoDatasOptions()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoDatasOptions"/> class by copying values from an existing <see cref="OrtoDatasOptions"/> instance.
        /// </summary>
        /// <param name="ortoDatasOptions">The source options instance to copy from.</param>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoDatasOptions"/> class using a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing configuration data.</param>
        public OrtoDatasOptions(JsonObject jsonObject)
            : base(jsonObject)
        {
        }
    }
}