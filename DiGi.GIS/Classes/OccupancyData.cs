using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public class OccupancyData : GuidObject, IOccupancyData
    {
        [JsonInclude, JsonPropertyName("Occupancy")]
        private readonly uint? occupancy = null;

        [JsonInclude, JsonPropertyName("OccupancyArea")]
        private readonly double? occupancyArea = null;

        [JsonInclude, JsonPropertyName("Reference")]
        private readonly string? reference = null;

        public OccupancyData(string? reference, double? occupancyArea, uint? occupancy)
            : base()
        {
            this.reference = reference;
            this.occupancyArea = occupancyArea;
            this.occupancy = occupancy;
        }

        public OccupancyData(OccupancyData occupancyData)
            : base(occupancyData)
        {
            if (occupancyData != null)
            {
                occupancyArea = occupancyData.occupancyArea;
                occupancy = occupancyData.occupancy;
            }
        }

        public OccupancyData(JsonObject jsonObject)
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
        public double? OccupancyArea
        {
            get
            {
                return occupancyArea;
            }
        }

        [JsonIgnore]
        public string? Reference
        {
            get
            {
                return reference;
            }
        }
    }
}