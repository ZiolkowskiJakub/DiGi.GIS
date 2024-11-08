using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public class AdministrativeAreal2DGeometryCalculationResult : UniqueResult<AdministrativeAreal2D>, IGISUniqueResult
    {
        [JsonInclude, JsonPropertyName("BoundingBox")]
        private BoundingBox2D boundingBox = null;

        [JsonInclude, JsonPropertyName("Rectangle")]
        private Rectangle2D rectangle = null;

        [JsonInclude, JsonPropertyName("Centroid")]
        private Point2D centroid = null;

        [JsonInclude, JsonPropertyName("InternalPoint")]
        private Point2D internalPoint = null;

        [JsonInclude, JsonPropertyName("ThinnessRatio")]
        private double thinnessRatio = double.NaN;

        [JsonInclude, JsonPropertyName("Rectangularity")]
        private double rectangularity = double.NaN;

        [JsonInclude, JsonPropertyName("Area")]
        private double area = double.NaN;


        public AdministrativeAreal2DGeometryCalculationResult(BoundingBox2D boundingBox, Rectangle2D rectangle, Point2D centroid, Point2D internalPoint, double thinnessRatio, double rectangularity, double area)
            : base()
        {
            this.boundingBox = boundingBox?.Clone<BoundingBox2D>();
            this.rectangle = rectangle?.Clone<Rectangle2D>();
            this.centroid = centroid?.Clone<Point2D>();
            this.internalPoint = internalPoint?.Clone<Point2D>();
            this.thinnessRatio = thinnessRatio;
            this.rectangularity = rectangularity;
            this.area = area;
        }

        public AdministrativeAreal2DGeometryCalculationResult(AdministrativeAreal2DGeometryCalculationResult administrativeAreal2DGeometryCalculationResult)
            :base(administrativeAreal2DGeometryCalculationResult)
        {
            if(administrativeAreal2DGeometryCalculationResult != null)
            {
                boundingBox = administrativeAreal2DGeometryCalculationResult.boundingBox?.Clone<BoundingBox2D>();
                rectangle = administrativeAreal2DGeometryCalculationResult.rectangle?.Clone<Rectangle2D>();
                centroid = administrativeAreal2DGeometryCalculationResult.centroid?.Clone<Point2D>();
                internalPoint = administrativeAreal2DGeometryCalculationResult.internalPoint?.Clone<Point2D>();
                thinnessRatio = administrativeAreal2DGeometryCalculationResult.thinnessRatio;
                rectangularity = administrativeAreal2DGeometryCalculationResult.rectangularity;
                area = administrativeAreal2DGeometryCalculationResult.area;
            }
        }

        public AdministrativeAreal2DGeometryCalculationResult(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public BoundingBox2D BoundingBox
        {
            get
            {
                return boundingBox?.Clone<BoundingBox2D>();
            }
        }

        [JsonIgnore]
        public Rectangle2D Rectangle2D
        {
            get
            {
                return rectangle?.Clone<Rectangle2D>();
            }
        }

        [JsonIgnore]
        public Point2D Centroid
        {
            get
            {
                return centroid?.Clone<Point2D>();
            }
        }

        [JsonIgnore]
        public Point2D InternalPoint
        {
            get
            {
                return internalPoint?.Clone<Point2D>();
            }
        }

        [JsonIgnore]
        public double ThinnessRatio
        {
            get
            {
                return thinnessRatio;
            }
        }

        [JsonIgnore]
        public double Rectangularity
        {
            get
            {
                return rectangularity;
            }
        }

        [JsonIgnore]
        public double Area
        {
            get
            {
                return area;
            }
        }
    }
}
