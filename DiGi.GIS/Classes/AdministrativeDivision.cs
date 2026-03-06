using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Enums;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public class AdministrativeDivision : AdministrativeAreal2D
    {
        [JsonInclude, JsonPropertyName("AdministrativeDivisionType")]
        private readonly AdministrativeDivisionType administrativeDivisionType;

        public AdministrativeDivision(Guid guid, string? reference, string? code, PolygonalFace2D? polygonalFace2D, AdministrativeDivisionType administrativeDivisionType, string name)
            : base(guid, reference, code, polygonalFace2D, name)
        {
            this.administrativeDivisionType = administrativeDivisionType;
        }

        public AdministrativeDivision(AdministrativeDivision? administrativeDivision)
            : base(administrativeDivision)
        {
            if (administrativeDivision != null)
            {
                administrativeDivisionType = administrativeDivision.administrativeDivisionType;
            }
        }

        public AdministrativeDivision(AdministrativeDivision? administrativeDivision, string? code)
            : base(administrativeDivision, code)
        {
            if (administrativeDivision != null)
            {
                administrativeDivisionType = administrativeDivision.administrativeDivisionType;
            }
        }

        public AdministrativeDivision(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        [JsonIgnore]
        public AdministrativeDivisionType AdministrativeDivisionType
        {
            get
            {
                return administrativeDivisionType;
            }
        }
    }
}