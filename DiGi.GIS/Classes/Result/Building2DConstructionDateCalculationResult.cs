using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents the result of a construction date calculation for a 2D building.
    /// </summary>
    public abstract class Building2DConstructionDateCalculationResult : GuidResult<Building2D>, IConstructionDateCalculationResult
    {
        [JsonInclude, JsonPropertyName("DateTime")]
        private readonly DateTime dateTime;

        /// <summary>
        /// Initializes a new instance of the <see cref="Building2DConstructionDateCalculationResult"/> class.
        /// </summary>
        public Building2DConstructionDateCalculationResult()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Building2DConstructionDateCalculationResult"/> class with a specified date and time.
        /// </summary>
        /// <param name="dateTime">The construction date and time.</param>
        public Building2DConstructionDateCalculationResult(DateTime dateTime)
            : base()
        {
            this.dateTime = dateTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Building2DConstructionDateCalculationResult"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the result data.</param>
        public Building2DConstructionDateCalculationResult(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Building2DConstructionDateCalculationResult"/> class by copying another result instance.
        /// </summary>
        /// <param name="building2DConstructionDateCalculationResult">The source calculation result to copy from.</param>
        public Building2DConstructionDateCalculationResult(Building2DConstructionDateCalculationResult? building2DConstructionDateCalculationResult)
            : base(building2DConstructionDateCalculationResult)
        {
            if (building2DConstructionDateCalculationResult is not null)
            {
                dateTime = building2DConstructionDateCalculationResult.dateTime;
            }
        }

        /// <summary>
        /// Gets the calculated construction date and time.
        /// </summary>
        [JsonIgnore]
        public DateTime DateTime
        {
            get
            {
                return dateTime;
            }
        }
    }
}