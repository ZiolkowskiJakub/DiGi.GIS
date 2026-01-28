using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public class YearBuiltPrediction : SerializableObject
    {
        [JsonInclude, JsonPropertyName("BoundingBox")]
        private readonly BoundingBox2D? boundingBox;

        [JsonInclude, JsonPropertyName("Confidence")]
        private readonly double confidence;

        [JsonInclude, JsonPropertyName("Year")]
        private readonly ushort year;

        public YearBuiltPrediction(ushort year, BoundingBox2D? boundingBox, double confidence)
        {
            this.year = year;
            this.boundingBox = Core.Query.Clone(boundingBox);
            this.confidence = confidence;
        }

        public YearBuiltPrediction(YearBuiltPrediction? yearBuiltPrediction)
        {
            if (yearBuiltPrediction != null)
            {
                boundingBox = Core.Query.Clone(yearBuiltPrediction.boundingBox);
                year = yearBuiltPrediction.year;
                confidence = yearBuiltPrediction.confidence;
            }
        }

        public YearBuiltPrediction(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        [JsonIgnore]
        public BoundingBox2D? BoundingBox
        {
            get
            {
                return Core.Query.Clone(boundingBox);
            }
        }

        [JsonIgnore]
        public double Confidence
        {
            get
            {
                return confidence;
            }
        }

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