using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Enums;

namespace DiGi.GIS.Classes
{
    public class AdministrativeSubdivision : Areal2D
    {
        [JsonInclude, JsonPropertyName("Name")]
        private string name;

        [JsonInclude, JsonPropertyName("AdministrativeSubdivisionType")]
        private AdministrativeSubdivisionType administrativeSubdivisionType;

        public AdministrativeSubdivision(Guid guid, string reference, PolygonalFace2D polygonalFace2D, AdministrativeSubdivisionType administrativeSubdivisionType, string name)
            : base(guid, reference, polygonalFace2D)
        {
            this.administrativeSubdivisionType = administrativeSubdivisionType;
            this.name = name;
        }

        public AdministrativeSubdivision(AdministrativeSubdivision administrativeSubdivision)
            : base(administrativeSubdivision)
        {
            if(administrativeSubdivision != null)
            {
                administrativeSubdivisionType = administrativeSubdivision.administrativeSubdivisionType;
                name = administrativeSubdivision.name;
            }
        }

        public AdministrativeSubdivision(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        [JsonIgnore]
        public string Name
        {
            get
            {
                return name;
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
