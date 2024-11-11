using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public class Building2DGeometryCalculationResult : UniqueResult<Building2D>, IGISUniqueResult
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

        [JsonInclude, JsonPropertyName("Perimeter")]
        private double perimeter = double.NaN;

        [JsonInclude, JsonPropertyName("RectangularThinnessRatio")]
        private double rectangularThinnessRatio = double.NaN;

        [JsonInclude, JsonPropertyName("IsoperimetricRatio")]
        private double isoperimetricRatio = double.NaN;

        public Building2DGeometryCalculationResult(BoundingBox2D boundingBox, Rectangle2D rectangle, Point2D centroid, Point2D internalPoint, double thinnessRatio, double rectangularity, double area, double perimeter, double rectangularThinnessRatio, double isoperimetricRatio)
            : base()
        {
            this.boundingBox = boundingBox?.Clone<BoundingBox2D>();
            this.rectangle = rectangle?.Clone<Rectangle2D>();
            this.centroid = centroid?.Clone<Point2D>();
            this.internalPoint = internalPoint?.Clone<Point2D>();
            this.thinnessRatio = thinnessRatio;
            this.rectangularity = rectangularity;
            this.area = area;
            this.perimeter = perimeter;
            this.rectangularThinnessRatio = rectangularThinnessRatio;
            this.isoperimetricRatio = isoperimetricRatio;
        }

        public Building2DGeometryCalculationResult(Building2DGeometryCalculationResult building2DGeometryCalculationResult)
            :base(building2DGeometryCalculationResult)
        {
            if(building2DGeometryCalculationResult != null)
            {
                boundingBox = building2DGeometryCalculationResult.boundingBox?.Clone<BoundingBox2D>();
                rectangle = building2DGeometryCalculationResult.rectangle?.Clone<Rectangle2D>();
                centroid = building2DGeometryCalculationResult.centroid?.Clone<Point2D>();
                internalPoint = building2DGeometryCalculationResult.internalPoint?.Clone<Point2D>();
                thinnessRatio = building2DGeometryCalculationResult.thinnessRatio;
                rectangularity = building2DGeometryCalculationResult.rectangularity;
                area = building2DGeometryCalculationResult.area;
                perimeter = building2DGeometryCalculationResult.perimeter;
                rectangularThinnessRatio = building2DGeometryCalculationResult.rectangularThinnessRatio;
                isoperimetricRatio = building2DGeometryCalculationResult.isoperimetricRatio;
            }
        }

        public Building2DGeometryCalculationResult(JsonObject jsonObject)
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

        [JsonIgnore]
        public double Perimeter
        {
            get
            {
                return perimeter;
            }
        }

        [JsonIgnore]
        public double RectangularThinnessRatio
        {
            get
            {
                return rectangularThinnessRatio;
            }
        }

        [JsonIgnore]
        public double IsoperimetricRatio
        {
            get
            {
                return isoperimetricRatio;
            }
        }
    }
}
