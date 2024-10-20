using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Enums;

namespace DiGi.GIS.Classes
{
    public class AdministrativeAreal2D : Areal2D
    {
        [JsonInclude, JsonPropertyName("Occupancy")]
        private uint? occupancy = 0;

        [JsonInclude, JsonPropertyName("Name")]
        private string name;

        [JsonInclude, JsonPropertyName("AdministrativeArealType")]
        private AdministrativeArealType administrativeArealType;

        public AdministrativeAreal2D(Guid guid, string reference, PolygonalFace2D polygonalFace2D, AdministrativeArealType administrativeArealType, string name, uint? occupancy)
            : base(guid, reference, polygonalFace2D)
        {
            this.administrativeArealType = administrativeArealType;
            this.name = name;
            this.occupancy = occupancy;
        }

        public AdministrativeAreal2D(AdministrativeAreal2D administrativeArea2D)
            : base(administrativeArea2D)
        {
            if(administrativeArea2D != null)
            {
                administrativeArealType = administrativeArea2D.administrativeArealType;
                name = administrativeArea2D.name;
                occupancy = administrativeArea2D.occupancy;
            }
        }

        public AdministrativeAreal2D(JsonObject jsonObject)
            :base(jsonObject)
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
        public string Name
        {
            get
            {
                return name;
            }
        }

        [JsonIgnore]
        public AdministrativeArealType AdministrativeArealType
        {
            get
            {
                return administrativeArealType;
            }
        }

    }
}
