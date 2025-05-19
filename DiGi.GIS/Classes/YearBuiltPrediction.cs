using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;

namespace DiGi.GIS.Classes
{
    public class YearBuiltPrediction : SerializableObject
    {
        [JsonInclude, JsonPropertyName("BoundingBox")]
        private BoundingBox2D boundingBox;

        [JsonInclude, JsonPropertyName("Confidence")]
        private double confidence;

        [JsonInclude, JsonPropertyName("Year")]
        private ushort year;

        public YearBuiltPrediction(ushort year, BoundingBox2D boundingBox, double confidence)
        {
            this.year = year;
            this.boundingBox = Core.Query.Clone(boundingBox);
            this.confidence = confidence;
        }

        public YearBuiltPrediction(YearBuiltPrediction yearBuiltPrediction)
        {
            if (yearBuiltPrediction != null)
            {
                boundingBox = Core.Query.Clone(yearBuiltPrediction.boundingBox);
                year = yearBuiltPrediction.year;
                confidence = yearBuiltPrediction.confidence;
            }
        }

        public YearBuiltPrediction(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public BoundingBox2D BoundingBox
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
