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

        public AdministrativeAreal2D(Guid guid, string? reference, string? code, PolygonalFace2D? polygonalFace2D, string? name)
            : base(guid, reference, polygonalFace2D)
        {
            this.name = name;
            this.code = code;
        }

        public AdministrativeAreal2D(AdministrativeAreal2D? administrativeArea2D)
            : base(administrativeArea2D)
        {
            if (administrativeArea2D != null)
            {
                name = administrativeArea2D.name;
                code = administrativeArea2D.code;
            }
        }

        public AdministrativeAreal2D(AdministrativeAreal2D? administrativeArea2D, string? code)
            : this(administrativeArea2D)
        {
            this.code = code;
        }

        public AdministrativeAreal2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        [JsonIgnore]
        public string? Name
        {
            get
            {
                return name;
            }
        }

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