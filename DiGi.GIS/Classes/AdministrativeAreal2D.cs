using DiGi.Geometry.Planar.Classes;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public abstract class AdministrativeAreal2D : Areal2D
    {
        [JsonInclude, JsonPropertyName("Name")]
        private readonly string? name;

        [JsonInclude, JsonPropertyName("Code")]
        private readonly string? code;

        /// <summary>
        /// Initializes a new instance of the AdministrativeAreal2D class
        /// </summary>
        public AdministrativeAreal2D(Guid guid, string? reference, string? code, PolygonalFace2D? polygonalFace2D, string? name)
            : base(guid, reference, polygonalFace2D)
        {
            this.name = name;
            this.code = code;
        }

        /// <summary>
        /// Initializes a new instance of the AdministrativeAreal2D class as a copy of another AdministrativeAreal2D
        /// </summary>
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
        /// Initializes a new instance of the AdministrativeAreal2D class as a copy of another AdministrativeAreal2D with a new code
        /// </summary>
        public AdministrativeAreal2D(AdministrativeAreal2D? administrativeArea2D, string? code)
            : this(administrativeArea2D)
        {
            this.code = code;
        }

        /// <summary>
        /// Initializes a new instance of the AdministrativeAreal2D class from a JSON object
        /// </summary>
        public AdministrativeAreal2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Name of the administrative area
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
        /// Code of the administrative area
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