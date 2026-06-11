using System;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents the result of a construction date calculation for a 2D building using machine learning.
    /// </summary>
    public class Building2DMachineLearningConstructionDateCalculationResult : Building2DConstructionDateCalculationResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Building2DMachineLearningConstructionDateCalculationResult"/> class.
        /// </summary>
        public Building2DMachineLearningConstructionDateCalculationResult()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Building2DMachineLearningConstructionDateCalculationResult"/> class with the specified date and time.
        /// </summary>
        /// <param name="dateTime">The construction date and time.</param>
        public Building2DMachineLearningConstructionDateCalculationResult(DateTime dateTime)
            : base(dateTime)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Building2DMachineLearningConstructionDateCalculationResult"/> class from the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the calculation result data.</param>
        public Building2DMachineLearningConstructionDateCalculationResult(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Building2DMachineLearningConstructionDateCalculationResult"/> class by copying another instance.
        /// </summary>
        /// <param name="building2DMachineLearningConstructionDateCalculationResult">The source instance to copy from.</param>
        public Building2DMachineLearningConstructionDateCalculationResult(Building2DMachineLearningConstructionDateCalculationResult building2DMachineLearningConstructionDateCalculationResult)
            : base(building2DMachineLearningConstructionDateCalculationResult)
        {
        }
    }
}