using DiGi.Core.Relation.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a one-to-one directional relation between a Building2D entity and its associated Building2DGeometryCalculationResult.
    /// </summary>
    public class Building2DGeometryCalculationResultRelation : OneToOneDirectionalRelation<Building2D, Building2DGeometryCalculationResult>, IGISRelation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Building2DGeometryCalculationResultRelation"/> class with the specified building and geometry calculation result.
        /// </summary>
        /// <param name="building2D">The source Building2D entity.</param>
        /// <param name="building2DGeometryCalculationResult">The target Building2DGeometryCalculationResult entity.</param>
        public Building2DGeometryCalculationResultRelation(Building2D building2D, Building2DGeometryCalculationResult building2DGeometryCalculationResult)
            : base(building2D, building2DGeometryCalculationResult)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Building2DGeometryCalculationResultRelation"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the relation data.</param>
        public Building2DGeometryCalculationResultRelation(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Building2DGeometryCalculationResultRelation"/> class by copying an existing relation.
        /// </summary>
        /// <param name="building2DGeometryCalculationResultRelation">The source relation to copy from.</param>
        public Building2DGeometryCalculationResultRelation(Building2DGeometryCalculationResultRelation building2DGeometryCalculationResultRelation)
            : base(building2DGeometryCalculationResultRelation)
        {
        }
    }
}