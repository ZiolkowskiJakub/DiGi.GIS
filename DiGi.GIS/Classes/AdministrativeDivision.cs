using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Enums;

namespace DiGi.GIS.Classes
{
    public class AdministrativeDivision : AdministrativeAreal2D
    {

        [JsonInclude, JsonPropertyName("AdministrativeDivisionType")]
        private AdministrativeDivisionType administrativeDivisionType;

        public AdministrativeDivision(Guid guid, string reference, PolygonalFace2D polygonalFace2D, AdministrativeDivisionType administrativeDivisionType, string name)
            : base(guid, reference, polygonalFace2D, name)
        {
            this.administrativeDivisionType = administrativeDivisionType;
        }

        public AdministrativeDivision(AdministrativeDivision administrativeDivision)
            : base(administrativeDivision)
        {
            if(administrativeDivision != null)
            {
                administrativeDivisionType = administrativeDivision.administrativeDivisionType;
            }
        }

        public AdministrativeDivision(JsonObject jsonObject)
            :base(jsonObject)
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
