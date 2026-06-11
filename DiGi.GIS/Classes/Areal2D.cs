using DiGi.Core;
using DiGi.Geometry.Planar.Classes;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a two-dimensional areal object within the GIS coordinate system.
    /// </summary>
    public abstract class Areal2D : GISGuidObject2D
    {
        [JsonInclude, JsonPropertyName("PolygonalFace2D")]
        private readonly PolygonalFace2D? polygonalFace2D = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="Areal2D"/> class.
        /// </summary>
        /// <param name="guid">The unique identifier for the object.</param>
        /// <param name="reference">An optional reference string associated with the object.</param>
        /// <param name="polygonalFace2D">The polygonal face that defines the geometry of the area.</param>
        public Areal2D(Guid guid, string? reference, PolygonalFace2D? polygonalFace2D)
            : base(guid, reference)
        {
            this.polygonalFace2D = polygonalFace2D?.Clone<PolygonalFace2D>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Areal2D"/> class by copying an existing <see cref="Areal2D"/> object.
        /// </summary>
        /// <param name="areal2D">The source areal object to copy from.</param>
        public Areal2D(Areal2D? areal2D)
            : base(areal2D)
        {
            if (areal2D != null)
            {
                polygonalFace2D = areal2D.polygonalFace2D?.Clone<PolygonalFace2D>();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Areal2D"/> class using data from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the initialization data.</param>
        public Areal2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the polygonal face associated with this areal object.
        /// </summary>
        [JsonIgnore]
        public PolygonalFace2D? PolygonalFace2D
        {
            get
            {
                return polygonalFace2D?.Clone<PolygonalFace2D>();
            }
        }
    }
}