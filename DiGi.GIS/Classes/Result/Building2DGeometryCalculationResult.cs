using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents the result of geometry calculations for a 2D building.
    /// </summary>
    public class Building2DGeometryCalculationResult : GuidResult<Building2D>, IGISGuidResult
    {
        [JsonInclude, JsonPropertyName("BoundingBox")]
        private readonly BoundingBox2D? boundingBox = null;

        [JsonInclude, JsonPropertyName("Rectangle")]
        private readonly Rectangle2D? rectangle = null;

        [JsonInclude, JsonPropertyName("Centroid")]
        private readonly Point2D? centroid = null;

        [JsonInclude, JsonPropertyName("InternalPoint")]
        private readonly Point2D? internalPoint = null;

        [JsonInclude, JsonPropertyName("ThinnessRatio")]
        private readonly double thinnessRatio = double.NaN;

        [JsonInclude, JsonPropertyName("Rectangularity")]
        private readonly double rectangularity = double.NaN;

        [JsonInclude, JsonPropertyName("Area")]
        private readonly double area = double.NaN;

        [JsonInclude, JsonPropertyName("Perimeter")]
        private readonly double perimeter = double.NaN;

        [JsonInclude, JsonPropertyName("RectangularThinnessRatio")]
        private readonly double rectangularThinnessRatio = double.NaN;

        [JsonInclude, JsonPropertyName("IsoperimetricRatio")]
        private readonly double isoperimetricRatio = double.NaN;

        /// <summary>
        /// Initializes a new instance of the Building2DGeometryCalculationResult class.
        /// </summary>
        /// <param name="boundingBox">The bounding box of the building.</param>
        /// <param name="rectangle">The rectangle representation of the building.</param>
        /// <param name="centroid">The centroid point of the building.</param>
        /// <param name="internalPoint">The internal point within the building.</param>
        /// <param name="thinnessRatio">The thinness ratio of the building.</param>
        /// <param name="rectangularity">The rectangularity measure of the building.</param>
        /// <param name="area">The area of the building.</param>
        /// <param name="perimeter">The perimeter of the building.</param>
        /// <param name="rectangularThinnessRatio">The rectangular thinness ratio of the building.</param>
        /// <param name="isoperimetricRatio">The isoperimetric ratio of the building.</param>
        public Building2DGeometryCalculationResult(BoundingBox2D? boundingBox, Rectangle2D? rectangle, Point2D? centroid, Point2D? internalPoint, double thinnessRatio, double rectangularity, double area, double perimeter, double rectangularThinnessRatio, double isoperimetricRatio)
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

        /// <summary>
        /// Initializes a new instance of the Building2DGeometryCalculationResult class as a copy.
        /// </summary>
        /// <param name="building2DGeometryCalculationResult">The source result object to copy from.</param>
        public Building2DGeometryCalculationResult(Building2DGeometryCalculationResult? building2DGeometryCalculationResult)
            : base(building2DGeometryCalculationResult)
        {
            if (building2DGeometryCalculationResult != null)
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

        /// <summary>
        /// Initializes a new instance of the Building2DGeometryCalculationResult class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the calculation result data.</param>
        public Building2DGeometryCalculationResult(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the bounding box of the building.
        /// </summary>
        [JsonIgnore]
        public BoundingBox2D? BoundingBox
        {
            get
            {
                return boundingBox?.Clone<BoundingBox2D>();
            }
        }

        /// <summary>
        /// Gets the rectangle representation of the building.
        /// </summary>
        [JsonIgnore]
        public Rectangle2D? Rectangle2D
        {
            get
            {
                return rectangle?.Clone<Rectangle2D>();
            }
        }

        /// <summary>
        /// Gets the centroid point of the building.
        /// </summary>
        [JsonIgnore]
        public Point2D? Centroid
        {
            get
            {
                return centroid?.Clone<Point2D>();
            }
        }

        /// <summary>
        /// Gets the internal point within the building.
        /// </summary>
        [JsonIgnore]
        public Point2D? InternalPoint
        {
            get
            {
                return internalPoint?.Clone<Point2D>();
            }
        }

        /// <summary>
        /// Gets the thinness ratio of the building.
        /// </summary>
        [JsonIgnore]
        public double ThinnessRatio
        {
            get
            {
                return thinnessRatio;
            }
        }

        /// <summary>
        /// Gets the rectangularity measure of the building.
        /// </summary>
        [JsonIgnore]
        public double Rectangularity
        {
            get
            {
                return rectangularity;
            }
        }

        /// <summary>
        /// Gets the area of the building.
        /// </summary>
        [JsonIgnore]
        public double Area
        {
            get
            {
                return area;
            }
        }

        /// <summary>
        /// Gets the perimeter of the building.
        /// </summary>
        [JsonIgnore]
        public double Perimeter
        {
            get
            {
                return perimeter;
            }
        }

        /// <summary>
        /// Gets the rectangular thinness ratio of the building.
        /// </summary>
        [JsonIgnore]
        public double RectangularThinnessRatio
        {
            get
            {
                return rectangularThinnessRatio;
            }
        }

        /// <summary>
        /// Gets the isoperimetric ratio of the building.
        /// </summary>
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