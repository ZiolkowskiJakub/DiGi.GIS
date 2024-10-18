using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.GIS.Enums;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public class Location : SerializableObject
    {
        [JsonInclude, JsonPropertyName("Name")]
        private string name;

        [JsonInclude, JsonPropertyName("LocationType")]
        private LocationType locationType;

        [JsonInclude, JsonPropertyName("Dwellings")]
        private uint dwellings;

        [JsonInclude, JsonPropertyName("DwellingDensity")]
        private double dwellingDensity;

        public Location(string name, LocationType locationType, uint dwellings, double dwellingDensity)
        {
            this.name = name;
            this.locationType = locationType;
            this.dwellings = dwellings;
            this.dwellingDensity = dwellingDensity;
        }

        public Location(Location location)
            :base()
        {
            if (location != null)
            {
                name = location.name;
                locationType = location.locationType;
                dwellings = location.dwellings;
                dwellingDensity = location.dwellingDensity;
            }
        }

        public Location(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public override ISerializableObject Clone()
        {
            return new Location(this);
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
        public LocationType LocationType
        {
            get
            {
                return locationType;
            }
        }

        [JsonIgnore]
        public double DwellingDensity
        {
            get
            {
                return dwellingDensity;
            }
        }

        [JsonIgnore]
        public uint Dwellings
        {
            get
            {
                return dwellings;
            }
        }

    }
}
