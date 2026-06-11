using DiGi.Core.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Provides configuration options for 2D building ortho data.
    /// </summary>
    public class OrtoDatasBuilding2DOptions : OrtoDatasOptions
    {
        /// <summary>
        /// Gets or sets the offset value for the 2D building ortho data.
        /// </summary>
        [JsonInclude, JsonPropertyName("Offset")]
        public double Offset { get; set; } = 5;

        /// <summary>
        /// Gets or sets the width value for the 2D building ortho data.
        /// </summary>
        [JsonInclude, JsonPropertyName("Width")]
        public double Width { get; set; } = 320;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoDatasBuilding2DOptions"/> class with specified parameters.
        /// </summary>
        /// <param name="years">The range of years to consider.</param>
        /// <param name="offset">The offset value.</param>
        /// <param name="width">The width value.</param>
        /// <param name="reduce">A value indicating whether to reduce the data.</param>
        /// <param name="maxFileSize">The maximum allowed file size.</param>
        public OrtoDatasBuilding2DOptions(Range<int> years, double offset, double width, bool reduce, ulong maxFileSize)
            : base(years, reduce, maxFileSize)
        {
            Width = width;
            Offset = offset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoDatasBuilding2DOptions"/> class using default settings and building-specific directory names.
        /// </summary>
        public OrtoDatasBuilding2DOptions()
            : base()
        {
            DirectoryNames = Query.OrtoDatasDirectoryNames_Building2D();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoDatasBuilding2DOptions"/> class by copying values from another instance.
        /// </summary>
        /// <param name="ortoDatasBuilding2DOptions">The source options instance to copy from.</param>
        public OrtoDatasBuilding2DOptions(OrtoDatasBuilding2DOptions ortoDatasBuilding2DOptions)
            : base(ortoDatasBuilding2DOptions)
        {
            if (ortoDatasBuilding2DOptions != null)
            {
                Width = ortoDatasBuilding2DOptions.Width;
                Offset = ortoDatasBuilding2DOptions.Offset;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoDatasBuilding2DOptions"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the configuration data.</param>
        public OrtoDatasBuilding2DOptions(JsonObject jsonObject)
            : base(jsonObject)
        {
        }
    }
}