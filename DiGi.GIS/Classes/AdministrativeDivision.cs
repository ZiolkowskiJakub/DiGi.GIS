using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Enums;

namespace DiGi.GIS.Classes
{
    public class AdministrativeDivision : Areal2D
    {
        [JsonInclude, JsonPropertyName("Name")]
        private string name;

        [JsonInclude, JsonPropertyName("AdministrativeDivisionType")]
        private AdministrativeDivisionType administrativeDivisionType;

        public AdministrativeDivision(Guid guid, string reference, PolygonalFace2D polygonalFace2D, AdministrativeDivisionType administrativeDivisionType, string name)
            : base(guid, reference, polygonalFace2D)
        {
            this.administrativeDivisionType = administrativeDivisionType;
            this.name = name;
        }

        public AdministrativeDivision(AdministrativeDivision administrativeDivision)
            : base(administrativeDivision)
        {
            if(administrativeDivision != null)
            {
                administrativeDivisionType = administrativeDivision.administrativeDivisionType;
                name = administrativeDivision.name;
            }
        }

        public AdministrativeDivision(JsonObject jsonObject)
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
        public AdministrativeDivisionType AdministrativeDivisionType
        {
            get
            {
                return administrativeDivisionType;
            }
        }

    }
}
