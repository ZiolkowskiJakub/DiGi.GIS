using DiGi.Geometry.Planar.Classes;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents an abstract base class for administrative areas in a 2D coordinate system.
    /// </summary>
    public abstract class AdministrativeAreal2D : Areal2D
    {
        [JsonInclude, JsonPropertyName("Name")]
        private readonly string? name;

        [JsonInclude, JsonPropertyName("Code")]
        private readonly string? code;

        /// <summary>
        /// Initializes a new instance of the AdministrativeAreal2D class.
        /// </summary>
        /// <param name="guid">The unique identifier for the administrative area.</param>
        /// <param name="reference">The reference string associated with the administrative area.</param>
        /// <param name="code">The identification code of the administrative area.</param>
        /// <param name="polygonalFace2D">The polygonal face defining the geometry of the administrative area.</param>
        /// <param name="name">The descriptive name of the administrative area.</param>
        public AdministrativeAreal2D(Guid guid, string? reference, string? code, PolygonalFace2D? polygonalFace2D, string? name)
            : base(guid, reference, polygonalFace2D)
        {
            this.name = name;
            this.code = code;
        }

        /// <summary>
        /// Initializes a new instance of the AdministrativeAreal2D class as a copy of another AdministrativeAreal2D.
        /// </summary>
        /// <param name="administrativeArea2D">The source administrative area instance to copy from.</param>
        public AdministrativeAreal2D(AdministrativeAreal2D? administrativeArea2D)
            : base(administrativeArea2D)
        {
            if (administrativeArea2D != null)
            {
                name = administrativeArea2D.name;
                code = administrativeArea2D.code;
            }
        }

        /// <summary>
        /// Initializes a new instance of the AdministrativeAreal2D class as a copy of another AdministrativeAreal2D with a new code.
        /// </summary>
        /// <param name="administrativeArea2D">The source administrative area instance to copy from.</param>
        /// <param name="code">The new identification code to assign to the copied administrative area.</param>
        public AdministrativeAreal2D(AdministrativeAreal2D? administrativeArea2D, string? code)
            : this(administrativeArea2D)
        {
            this.code = code;
        }

        /// <summary>
        /// Initializes a new instance of the AdministrativeAreal2D class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the administrative area data.</param>
        public AdministrativeAreal2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the name of the administrative area.
        /// </summary>
        [JsonIgnore]
        public string? Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Gets the code of the administrative area.
        /// </summary>
        [JsonIgnore]
        public string? Code
        {
            get
            {
                return code;
            }
        }
    }
}