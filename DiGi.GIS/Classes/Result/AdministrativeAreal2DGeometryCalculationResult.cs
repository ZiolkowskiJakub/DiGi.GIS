using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents the result of a geometry calculation for an administrative areal 2D object.
    /// </summary>
    public class AdministrativeAreal2DGeometryCalculationResult : GuidResult<AdministrativeAreal2D>, IGISUniqueResult
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

        /// <summary>
        /// Initializes a new instance of the AdministrativeAreal2DGeometryCalculationResult class
        /// </summary>
        /// <param name="boundingBox">The bounding box of the administrative area.</param>
        /// <param name="rectangle">The rectangle representation of the administrative area.</param>
        /// <param name="centroid">The centroid point of the administrative area.</param>
        /// <param name="internalPoint">The internal point within the administrative area.</param>
        /// <param name="thinnessRatio">The thinness ratio of the administrative area.</param>
        /// <param name="rectangularity">The rectangularity measure of the administrative area.</param>
        /// <param name="area">The area of the administrative area.</param>
        public AdministrativeAreal2DGeometryCalculationResult(BoundingBox2D? boundingBox, Rectangle2D? rectangle, Point2D? centroid, Point2D? internalPoint, double thinnessRatio, double rectangularity, double area)
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

        /// <summary>
        /// Initializes a new instance of the AdministrativeAreal2DGeometryCalculationResult class as a copy
        /// </summary>
        /// <param name="administrativeAreal2DGeometryCalculationResult">The source result object to copy from.</param>
        public AdministrativeAreal2DGeometryCalculationResult(AdministrativeAreal2DGeometryCalculationResult? administrativeAreal2DGeometryCalculationResult)
            : base(administrativeAreal2DGeometryCalculationResult)
        {
            if (administrativeAreal2DGeometryCalculationResult != null)
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

        /// <summary>
        /// Initializes a new instance of the AdministrativeAreal2DGeometryCalculationResult class from a JSON object
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the result data.</param>
        public AdministrativeAreal2DGeometryCalculationResult(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the bounding box of the administrative area
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
        /// Gets the rectangle representation of the administrative area
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
        /// Gets the centroid point of the administrative area
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
        /// Gets the internal point within the administrative area
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
        /// Gets the thinness ratio of the administrative area
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
        /// Gets the rectangularity measure of the administrative area
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
        /// Gets the area of the administrative area
        /// </summary>
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