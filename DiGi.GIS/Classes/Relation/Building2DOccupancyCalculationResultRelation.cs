using DiGi.Core.Relation.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a one-to-one directional relation between a Building2D entity and an OccupancyCalculationResult entity.
    /// </summary>
    public class Building2DOccupancyCalculationResultRelation : OneToOneDirectionalRelation<Building2D, OccupancyCalculationResult>, IGISRelation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Building2DOccupancyCalculationResultRelation"/> class with the specified building and occupancy calculation result.
        /// </summary>
        /// <param name="building2D">The Building2D entity involved in the relation.</param>
        /// <param name="occupancyCalculationResult">The OccupancyCalculationResult entity involved in the relation.</param>
        public Building2DOccupancyCalculationResultRelation(Building2D building2D, OccupancyCalculationResult occupancyCalculationResult)
            : base(building2D, occupancyCalculationResult)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Building2DOccupancyCalculationResultRelation"/> class using a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the relation data.</param>
        public Building2DOccupancyCalculationResultRelation(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Building2DOccupancyCalculationResultRelation"/> class by copying an existing relation.
        /// </summary>
        /// <param name="building2DOccupancyCalculationResultRelation">The source relation to copy from.</param>
        public Building2DOccupancyCalculationResultRelation(Building2DOccupancyCalculationResultRelation building2DOccupancyCalculationResultRelation)
            : base(building2DOccupancyCalculationResultRelation)
        {
        }
    }
}