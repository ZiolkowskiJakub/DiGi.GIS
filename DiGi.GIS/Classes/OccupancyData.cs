using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents occupancy data with occupancy count, area, and reference information
    /// </summary>
    public class OccupancyData : GuidObject, IOccupancyData
    {
        [JsonInclude, JsonPropertyName("Occupancy")]
        private readonly uint? occupancy = null;

        [JsonInclude, JsonPropertyName("OccupancyArea")]
        private readonly double? occupancyArea = null;

        [JsonInclude, JsonPropertyName("Reference")]
        private readonly string? reference = null;

        /// <summary>
        /// Initializes a new instance of the OccupancyData class with the specified reference, occupancy area, and occupancy
        /// </summary>
        /// <param name="reference">The reference identifier for the occupancy data.</param>
        /// <param name="occupancyArea">The total area associated with the occupancy.</param>
        /// <param name="occupancy">The count of occupants.</param>
        public OccupancyData(string? reference, double? occupancyArea, uint? occupancy)
            : base()
        {
            this.reference = reference;
            this.occupancyArea = occupancyArea;
            this.occupancy = occupancy;
        }

        /// <summary>
        /// Initializes a new instance of the OccupancyData class by copying another instance
        /// </summary>
        /// <param name="occupancyData">The source instance to copy data from.</param>
        public OccupancyData(OccupancyData occupancyData)
            : base(occupancyData)
        {
            if (occupancyData != null)
            {
                occupancyArea = occupancyData.occupancyArea;
                occupancy = occupancyData.occupancy;
            }
        }

        /// <summary>
        /// Initializes a new instance of the OccupancyData class from a JSON object
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data to initialize the instance.</param>
        public OccupancyData(JsonObject jsonObject)
        : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the occupancy count
        /// </summary>
        [JsonIgnore]
        public uint? Occupancy
        {
            get
            {
                return occupancy;
            }
        }

        /// <summary>
        /// Gets the occupancy area
        /// </summary>
        [JsonIgnore]
        public double? OccupancyArea
        {
            get
            {
                return occupancyArea;
            }
        }

        /// <summary>
        /// Gets the reference string
        /// </summary>
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