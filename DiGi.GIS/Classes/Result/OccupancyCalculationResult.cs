using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public class OccupancyCalculationResult : GuidResult<Areal2D>, IGISGuidResult
    {
        [JsonInclude, JsonPropertyName("OccupancyArea")]
        private readonly double? occupancyArea = null;

        [JsonInclude, JsonPropertyName("Occupancy")]
        private readonly uint? occupancy = null;

        /// <summary>
        /// Initializes a new instance of the OccupancyCalculationResult class
        /// </summary>
        public OccupancyCalculationResult(double? occupancyArea, uint? occupancy)
            : base()
        {
            this.occupancyArea = occupancyArea;
            this.occupancy = occupancy;
        }

        /// <summary>
        /// Initializes a new instance of the OccupancyCalculationResult class as a copy
        /// </summary>
        public OccupancyCalculationResult(OccupancyCalculationResult occupancyCalculationResult)
            : base(occupancyCalculationResult)
        {
            if (occupancyCalculationResult != null)
            {
                occupancyArea = occupancyCalculationResult.occupancyArea;
                occupancy = occupancyCalculationResult.occupancy;
            }
        }

        /// <summary>
        /// Initializes a new instance of the OccupancyCalculationResult class from a JSON object
        /// </summary>
        public OccupancyCalculationResult(JsonObject jsonObject)
        : base(jsonObject)
        {
        }

        /// <summary>
        /// Occupancy count
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
        /// Occupancy area
        /// </summary>
        [JsonIgnore]
        public double? OccupancyArea
        {
            get
            {
                return occupancyArea;
            }
        }
    }
}