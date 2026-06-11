using DiGi.Core.Relation.Classes;
using DiGi.GIS.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a one-to-many directional relation between a Building2D entity and its associated Building2DConstructionDateCalculationResult entities.
    /// </summary>
    public class Building2DConstructionDateCalculationResultRelation : OneToManyDirectionalRelation<Building2D, Building2DConstructionDateCalculationResult>, IGISRelation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Building2DConstructionDateCalculationResultRelation"/> class with a specific building and a collection of calculation results.
        /// </summary>
        /// <param name="building2D">The parent Building2D entity.</param>
        /// <param name="constructionDateCalculationResults">The collection of associated construction date calculation results.</param>
        public Building2DConstructionDateCalculationResultRelation(Building2D building2D, IEnumerable<Building2DConstructionDateCalculationResult> constructionDateCalculationResults)
            : base(building2D, constructionDateCalculationResults)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Building2DConstructionDateCalculationResultRelation"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing relation data.</param>
        public Building2DConstructionDateCalculationResultRelation(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Building2DConstructionDateCalculationResultRelation"/> class by copying another instance.
        /// </summary>
        /// <param name="building2DConstructionDateCalculationResultRelation">The existing relation instance to copy from.</param>
        public Building2DConstructionDateCalculationResultRelation(Building2DConstructionDateCalculationResultRelation building2DConstructionDateCalculationResultRelation)
            : base(building2DConstructionDateCalculationResultRelation)
        {
        }
    }
}