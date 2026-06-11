using DiGi.Core.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Provides options for specifying the range of an orthophoto, including width and height dimensions.
    /// </summary>
    public class OrtoRangeOptions : SerializableOptions
    {
        /// <summary>
        /// Gets or sets the width of the orthophoto range.
        /// </summary>
        [JsonInclude, JsonPropertyName("Width")]
        public double Width { get; set; } = 300;

        /// <summary>
        /// Gets or sets the height of the orthophoto range.
        /// </summary>
        [JsonInclude, JsonPropertyName("Height")]
        public double Height { get; set; } = 300;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoRangeOptions"/> class with specified width and height.
        /// </summary>
        /// <param name="width">The width of the orthophoto range.</param>
        /// <param name="height">The height of the orthophoto range.</param>
        public OrtoRangeOptions(double width, double height)
            : base()
        {
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoRangeOptions"/> class.
        /// </summary>
        public OrtoRangeOptions()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoRangeOptions"/> class by copying values from an existing <see cref="OrtoRangeOptions"/> instance.
        /// </summary>
        /// <param name="ortoRangeOptions">The source options instance to copy from.</param>
        public OrtoRangeOptions(OrtoRangeOptions ortoRangeOptions)
            : base(ortoRangeOptions)
        {
            if (ortoRangeOptions != null)
            {
                Width = ortoRangeOptions.Width;
                Height = ortoRangeOptions.Height;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoRangeOptions"/> class using a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the range options data.</param>
        public OrtoRangeOptions(JsonObject jsonObject)
            : base(jsonObject)
        {
        }
    }
}