using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Provides options for the conversion of prediction tables.
    /// </summary>
    public class PredictionTableConversionOptions : TableConversionOptions
    {
        /// <summary>
        /// Gets or sets a value indicating whether year built predictions should be included in the conversion process.
        /// </summary>
        [JsonInclude, JsonPropertyName("IncludeYearBuiltPredictions")]
        public bool IncludeYearBuiltPredictions { get; set; } = true;

        /// <summary>
        /// Gets or sets the file path to the administrative areal 2D index data.
        /// </summary>
        [JsonInclude, JsonPropertyName("AdministrativeAreal2DsIndexDataFilePath")]
        public string? AdministrativeAreal2DsIndexDataFilePath { get; set; } = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionTableConversionOptions"/> class.
        /// </summary>
        public PredictionTableConversionOptions()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionTableConversionOptions"/> class using an existing options object.
        /// </summary>
        /// <param name="predictionTableConversionOptions">The source options instance to copy values from.</param>
        public PredictionTableConversionOptions(PredictionTableConversionOptions predictionTableConversionOptions)
            : base(predictionTableConversionOptions)
        {
            if (predictionTableConversionOptions != null)
            {
                IncludeYearBuiltPredictions = predictionTableConversionOptions.IncludeYearBuiltPredictions;
                AdministrativeAreal2DsIndexDataFilePath = predictionTableConversionOptions.AdministrativeAreal2DsIndexDataFilePath;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionTableConversionOptions"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the configuration data.</param>
        public PredictionTableConversionOptions(JsonObject jsonObject)
            : base(jsonObject)
        {
        }
    }
}