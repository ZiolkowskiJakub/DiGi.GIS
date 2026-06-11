using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a prediction for the year a building was constructed, including spatial boundaries and confidence metrics.
    /// </summary>
    public class YearBuiltPrediction : SerializableObject
    {
        [JsonInclude, JsonPropertyName("BoundingBox")]
        private readonly BoundingBox2D? boundingBox;

        [JsonInclude, JsonPropertyName("Confidence")]
        private readonly double confidence;

        [JsonInclude, JsonPropertyName("Year")]
        private readonly ushort year;

        /// <summary>
        /// Initializes a new instance of the <see cref="YearBuiltPrediction"/> class with specified construction year, bounding box, and confidence.
        /// </summary>
        /// <param name="year">The predicted year the building was built.</param>
        /// <param name="boundingBox">The spatial bounding box associated with this prediction.</param>
        /// <param name="confidence">The confidence level of the prediction.</param>
        public YearBuiltPrediction(ushort year, BoundingBox2D? boundingBox, double confidence)
        {
            this.year = year;
            this.boundingBox = Core.Query.Clone(boundingBox);
            this.confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="YearBuiltPrediction"/> class by copying values from an existing prediction.
        /// </summary>
        /// <param name="yearBuiltPrediction">The source prediction object to copy data from.</param>
        public YearBuiltPrediction(YearBuiltPrediction? yearBuiltPrediction)
        {
            if (yearBuiltPrediction != null)
            {
                boundingBox = Core.Query.Clone(yearBuiltPrediction.boundingBox);
                year = yearBuiltPrediction.year;
                confidence = yearBuiltPrediction.confidence;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="YearBuiltPrediction"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing prediction data.</param>
        public YearBuiltPrediction(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the spatial bounding box associated with the year built prediction.
        /// </summary>
        [JsonIgnore]
        public BoundingBox2D? BoundingBox
        {
            get
            {
                return Core.Query.Clone(boundingBox);
            }
        }

        /// <summary>
        /// Gets the confidence score of the prediction.
        /// </summary>
        [JsonIgnore]
        public double Confidence
        {
            get
            {
                return confidence;
            }
        }

        /// <summary>
        /// Gets the predicted year the building was constructed.
        /// </summary>
        [JsonIgnore]
        public ushort Year
        {
            get
            {
                return year;
            }
        }
    }
}