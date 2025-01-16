using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public class OccupancyCalculationResult : GuidResult<Areal2D>, IGISGuidResult
    {
        [JsonInclude, JsonPropertyName("OccupancyArea")]
        private double? occupancyArea = null;

        [JsonInclude, JsonPropertyName("Occupancy")]
        private uint? occupancy = null;

        public OccupancyCalculationResult(double? occupancyArea, uint? occupancy)
            :base()
        {
            this.occupancyArea = occupancyArea;
            this.occupancy = occupancy;
        }

        public OccupancyCalculationResult(OccupancyCalculationResult occupancyCalculationResult)
            : base(occupancyCalculationResult)
        {
            if(occupancyCalculationResult != null)
            {
                occupancyArea = occupancyCalculationResult.occupancyArea;
                occupancy = occupancyCalculationResult.occupancy;
            }
        }

        public OccupancyCalculationResult(JsonObject jsonObject)
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
    }
}
