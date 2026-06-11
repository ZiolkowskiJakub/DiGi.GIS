using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents the result of an occupancy calculation, containing area and count information.
    /// </summary>
    public class OccupancyCalculationResult : GuidResult<Areal2D>, IGISGuidResult
    {
        [JsonInclude, JsonPropertyName("OccupancyArea")]
        private readonly double? occupancyArea = null;

        [JsonInclude, JsonPropertyName("Occupancy")]
        private readonly uint? occupancy = null;

        /// <summary>
        /// Initializes a new instance of the OccupancyCalculationResult class.
        /// </summary>
        /// <param name="occupancyArea">The calculated occupancy area.</param>
        /// <param name="occupancy">The calculated occupancy count.</param>
        public OccupancyCalculationResult(double? occupancyArea, uint? occupancy)
            : base()
        {
            this.occupancyArea = occupancyArea;
            this.occupancy = occupancy;
        }

        /// <summary>
        /// Initializes a new instance of the OccupancyCalculationResult class as a copy.
        /// </summary>
        /// <param name="occupancyCalculationResult">The source result object to copy from.</param>
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
        /// Initializes a new instance of the OccupancyCalculationResult class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the result data.</param>
        public OccupancyCalculationResult(JsonObject jsonObject)
        : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the occupancy count.
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
        /// Gets the occupancy area.
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