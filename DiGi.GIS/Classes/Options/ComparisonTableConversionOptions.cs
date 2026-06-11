using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Provides options for the conversion of comparison tables.
    /// </summary>
    public class ComparisonTableConversionOptions : TableConversionOptions
    {
        /// <summary>
        /// Gets or sets a value indicating whether to include orthodata comparisons in the table conversion.
        /// </summary>
        [JsonInclude, JsonPropertyName("IncludeOrtoDatasComparison")]
        public bool IncludeOrtoDatasComparison { get; set; } = true;

        /// <summary>
        /// Initializes a new instance of the <see cref="ComparisonTableConversionOptions"/> class.
        /// </summary>
        public ComparisonTableConversionOptions()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComparisonTableConversionOptions"/> class using an existing instance of options.
        /// </summary>
        /// <param name="comparisonTableConversionOptions">The source conversion options to copy values from.</param>
        public ComparisonTableConversionOptions(ComparisonTableConversionOptions comparisonTableConversionOptions)
            : base(comparisonTableConversionOptions)
        {
            if (comparisonTableConversionOptions != null)
            {
                IncludeOrtoDatasComparison = comparisonTableConversionOptions.IncludeOrtoDatasComparison;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComparisonTableConversionOptions"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the conversion options.</param>
        public ComparisonTableConversionOptions(JsonObject jsonObject)
            : base(jsonObject)
        {
        }
    }
}