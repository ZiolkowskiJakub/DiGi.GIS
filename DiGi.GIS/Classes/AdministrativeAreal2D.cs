using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Geometry.Planar.Classes;

namespace DiGi.GIS.Classes
{
    public abstract class AdministrativeAreal2D : Areal2D
    {
        [JsonInclude, JsonPropertyName("Name")]
        private string name;

        public AdministrativeAreal2D(Guid guid, string reference, PolygonalFace2D polygonalFace2D, string name)
            : base(guid, reference, polygonalFace2D)
        {
            this.name = name;
        }

        public AdministrativeAreal2D(AdministrativeAreal2D administrativeArea2D)
            : base(administrativeArea2D)
        {
            if(administrativeArea2D != null)
            {
                name = administrativeArea2D.name;
            }
        }

        public AdministrativeAreal2D(JsonObject jsonObject)
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

    }
}
