using DiGi.Core.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents the options used for filtering and retrieving orthodata within a specific range, including scale settings.
    /// </summary>
    public class OrtoDatasOrtoRangeOptions : OrtoDatasOptions
    {
        /// <summary>
        /// Gets or sets the scale factor applied to the orthodata range.
        /// </summary>
        [JsonInclude, JsonPropertyName("Scale")]
        public double Scale { get; set; } = 3;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoDatasOrtoRangeOptions"/> class with specified year range, scale, reduction preference, and maximum file size.
        /// </summary>
        /// <param name="years">The range of years to filter the orthodata.</param>
        /// <param name="scale">The scale factor for the orthodata.</param>
        /// <param name="reduce">A value indicating whether to reduce the data.</param>
        /// <param name="maxFileSize">The maximum allowed file size.</param>
        public OrtoDatasOrtoRangeOptions(Range<int> years, double scale, bool reduce, ulong maxFileSize)
            : base(years, reduce, maxFileSize)
        {
            Scale = scale;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoDatasOrtoRangeOptions"/> class with default values and initializes directory names.
        /// </summary>
        public OrtoDatasOrtoRangeOptions()
            : base()
        {
            DirectoryNames = Query.OrtoDatasDirectoryNames_OrtoRange();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoDatasOrtoRangeOptions"/> class by copying values from an existing options instance.
        /// </summary>
        /// <param name="ortoDatasOrtoRangeOptions">The source options instance to copy from.</param>
        public OrtoDatasOrtoRangeOptions(OrtoDatasOrtoRangeOptions ortoDatasOrtoRangeOptions)
            : base(ortoDatasOrtoRangeOptions)
        {
            if (ortoDatasOrtoRangeOptions != null)
            {
                Scale = ortoDatasOrtoRangeOptions.Scale;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoDatasOrtoRangeOptions"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the options data.</param>
        public OrtoDatasOrtoRangeOptions(JsonObject jsonObject)
            : base(jsonObject)
        {
        }
    }
}