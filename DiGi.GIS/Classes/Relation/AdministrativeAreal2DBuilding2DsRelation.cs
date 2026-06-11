using DiGi.Core.Relation.Classes;
using DiGi.GIS.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a one-to-many bidirectional relation between an administrative areal 2D and building 2D entities.
    /// </summary>
    public class AdministrativeAreal2DBuilding2DsRelation : OneToManyBidirectionalRelation<AdministrativeAreal2D, Building2D>, IGISRelation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrativeAreal2DBuilding2DsRelation"/> class.
        /// </summary>
        /// <param name="administrativeAreal2D">The administrative areal 2D entity.</param>
        /// <param name="building2Ds">The collection of building 2D entities.</param>
        public AdministrativeAreal2DBuilding2DsRelation(AdministrativeAreal2D administrativeAreal2D, IEnumerable<Building2D> building2Ds)
            : base(administrativeAreal2D, building2Ds)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrativeAreal2DBuilding2DsRelation"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the relation data.</param>
        public AdministrativeAreal2DBuilding2DsRelation(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrativeAreal2DBuilding2DsRelation"/> class by copying an existing relation.
        /// </summary>
        /// <param name="administrativeAreal2DBuilding2DsRelation">The source relation to copy from.</param>
        public AdministrativeAreal2DBuilding2DsRelation(AdministrativeAreal2DBuilding2DsRelation administrativeAreal2DBuilding2DsRelation)
            : base(administrativeAreal2DBuilding2DsRelation)
        {
        }
    }
}