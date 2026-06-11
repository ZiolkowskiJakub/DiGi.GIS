using DiGi.Core.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Provides options for table conversion processes.
    /// </summary>
    public abstract class TableConversionOptions : SerializableOptions
    {
        /// <summary>
        /// Gets or sets a value indicating whether the model should be included in the conversion.
        /// </summary>
        [JsonInclude, JsonPropertyName("IncludeModel")]
        public bool IncludeModel { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether statistical data should be included in the conversion.
        /// </summary>
        [JsonInclude, JsonPropertyName("IncludeStatistical")]
        public bool IncludeStatistical { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether year built data should be included in the conversion.
        /// </summary>
        [JsonInclude, JsonPropertyName("IncludeYearBuiltData")]
        public bool IncludeYearBuilt { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether only year built data should be processed.
        /// </summary>
        [JsonInclude, JsonPropertyName("YearBuiltOnly")]
        public bool YearBuiltOnly { get; set; } = true;

        /// <summary>
        /// Gets or sets the range of years to be considered during the conversion process.
        /// </summary>
        [JsonInclude, JsonPropertyName("Years")]
        public Range<int> Years { get; set; } = new Range<int>(2008, System.DateTime.Now.Year);

        /// <summary>
        /// Gets or sets the directory path used for statistical data retrieval.
        /// </summary>
        [JsonInclude, JsonPropertyName("StatisticalDirectory")]
        public string? StatisticalDirectory { get; set; } = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TableConversionOptions"/> class.
        /// </summary>
        public TableConversionOptions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableConversionOptions"/> class by copying values from an existing options object.
        /// </summary>
        /// <param name="tableConversionOptions">The source options object to copy from.</param>
        public TableConversionOptions(TableConversionOptions? tableConversionOptions)
        {
            if (tableConversionOptions != null)
            {
                IncludeModel = tableConversionOptions.IncludeModel;
                IncludeStatistical = tableConversionOptions.IncludeStatistical;
                IncludeYearBuilt = tableConversionOptions.IncludeYearBuilt;
                YearBuiltOnly = tableConversionOptions.YearBuiltOnly;
                if (Core.Query.Clone(tableConversionOptions.Years) is Range<int> range)
                {
                    Years = range;
                }
                StatisticalDirectory = tableConversionOptions.StatisticalDirectory;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableConversionOptions"/> class using data from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the configuration settings.</param>
        public TableConversionOptions(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}