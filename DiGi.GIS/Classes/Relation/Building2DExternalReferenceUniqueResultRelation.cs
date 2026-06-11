using DiGi.Core.Relation.Classes;
using DiGi.GIS.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a one-to-many bidirectional relation between a Building2D entity and its unique external reference results.
    /// </summary>
    public class Building2DExternalReferenceUniqueResultRelation : OneToManyBidirectionalRelation<Building2D, Building2DExternalReferenceGuidResult>, IGISRelation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Building2DExternalReferenceUniqueResultRelation"/> class.
        /// </summary>
        /// <param name="building2D">The building entity associated with this relation.</param>
        /// <param name="building2DExternalReferenceUniqueResults">The collection of unique external reference results associated with the building.</param>
        public Building2DExternalReferenceUniqueResultRelation(Building2D building2D, IEnumerable<Building2DExternalReferenceGuidResult> building2DExternalReferenceUniqueResults)
            : base(building2D, building2DExternalReferenceUniqueResults)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Building2DExternalReferenceUniqueResultRelation"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the relation data.</param>
        public Building2DExternalReferenceUniqueResultRelation(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Building2DExternalReferenceUniqueResultRelation"/> class by copying an existing relation.
        /// </summary>
        /// <param name="ortoDatasCalculationResultRelation">The source relation to copy from.</param>
        public Building2DExternalReferenceUniqueResultRelation(Building2DExternalReferenceUniqueResultRelation ortoDatasCalculationResultRelation)
            : base(ortoDatasCalculationResultRelation)
        {
        }
    }
}