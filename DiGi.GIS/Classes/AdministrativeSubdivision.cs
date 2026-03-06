using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Enums;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public class AdministrativeSubdivision : AdministrativeAreal2D
    {
        [JsonInclude, JsonPropertyName("AdministrativeSubdivisionType")]
        private readonly AdministrativeSubdivisionType administrativeSubdivisionType;

        [JsonInclude, JsonPropertyName("Occupancy")]
        private readonly uint? occupancy = 0;

        public AdministrativeSubdivision(Guid guid, string? reference, string code, PolygonalFace2D? polygonalFace2D, AdministrativeSubdivisionType administrativeSubdivisionType, string? name, uint? occupancy)
            : base(guid, reference, code, polygonalFace2D, name)
        {
            this.administrativeSubdivisionType = administrativeSubdivisionType;
            this.occupancy = occupancy;
        }

        public AdministrativeSubdivision(AdministrativeSubdivision? administrativeSubdivision)
            : base(administrativeSubdivision)
        {
            if (administrativeSubdivision != null)
            {
                administrativeSubdivisionType = administrativeSubdivision.administrativeSubdivisionType;
                occupancy = administrativeSubdivision.occupancy;
            }
        }

        public AdministrativeSubdivision(AdministrativeSubdivision? administrativeSubdivision, string? code)
            : base(administrativeSubdivision, code)
        {
            if (administrativeSubdivision != null)
            {
                administrativeSubdivisionType = administrativeSubdivision.administrativeSubdivisionType;
                occupancy = administrativeSubdivision.occupancy;
            }
        }

        public AdministrativeSubdivision(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        [JsonIgnore]
        public uint? Occupancy
        {
            get
            {
                return occupancy;
            }
        }

        [JsonIgnore]
        public AdministrativeSubdivisionType AdministrativeSubdivisionType
        {
            get
            {
                return administrativeSubdivisionType;
            }
        }
    }
}