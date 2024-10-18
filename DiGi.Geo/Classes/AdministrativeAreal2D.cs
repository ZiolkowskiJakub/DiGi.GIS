using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Core;
using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geo.Classes
{
    public abstract class AdministrativeAreal2D : Areal2D
    {
        [JsonInclude, JsonPropertyName("Occupancy")]
        private ushort occupancy = 0;

        public AdministrativeAreal2D(Guid guid, PolygonalFace2D polygonalFace2D, string reference, ushort occupancy)
            : base(guid, polygonalFace2D, reference)
        {
            this.occupancy = occupancy;
        }

        public AdministrativeAreal2D(AdministrativeAreal2D administrativeArea2D)
            : base(administrativeArea2D)
        {
            if(administrativeArea2D != null)
            {
                occupancy = administrativeArea2D.occupancy;
            }
        }

        public AdministrativeAreal2D(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        [JsonIgnore]
        public ushort Occupancy
        {
            get
            {
                return occupancy;
            }
        }

    }
}
