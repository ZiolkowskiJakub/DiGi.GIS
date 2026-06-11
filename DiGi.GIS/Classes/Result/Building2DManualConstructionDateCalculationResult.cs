using System;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents the result of a manual construction date calculation for a 2D building.
    /// </summary>
    public class Building2DManualConstructionDateCalculationResult : Building2DConstructionDateCalculationResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Building2DManualConstructionDateCalculationResult"/> class.
        /// </summary>
        public Building2DManualConstructionDateCalculationResult()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Building2DManualConstructionDateCalculationResult"/> class using the specified date and time.
        /// </summary>
        /// <param name="dateTime">The date and time to be used for the construction date calculation result.</param>
        public Building2DManualConstructionDateCalculationResult(DateTime dateTime)
            : base(dateTime)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Building2DManualConstructionDateCalculationResult"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the construction date calculation result data.</param>
        public Building2DManualConstructionDateCalculationResult(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Building2DManualConstructionDateCalculationResult"/> class by copying an existing instance.
        /// </summary>
        /// <param name="building2DManualConstructionDateCalculationResult">The source instance to copy from.</param>
        public Building2DManualConstructionDateCalculationResult(Building2DManualConstructionDateCalculationResult building2DManualConstructionDateCalculationResult)
            : base(building2DManualConstructionDateCalculationResult)
        {
        }
    }
}