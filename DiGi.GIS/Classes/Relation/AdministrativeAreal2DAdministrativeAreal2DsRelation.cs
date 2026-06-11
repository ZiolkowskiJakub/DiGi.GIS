using DiGi.Core.Relation.Classes;
using DiGi.GIS.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a one-to-many bidirectional relation between administrative areal 2D entities.
    /// </summary>
    public class AdministrativeAreal2DAdministrativeAreal2DsRelation : OneToManyBidirectionalRelation<AdministrativeAreal2D, AdministrativeAreal2D>, IGISRelation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrativeAreal2DAdministrativeAreal2DsRelation"/> class.
        /// </summary>
        /// <param name="administrativeAreal2D">The parent administrative areal 2D entity.</param>
        /// <param name="administrativeAreal2Ds">The collection of related administrative areal 2D entities.</param>
        public AdministrativeAreal2DAdministrativeAreal2DsRelation(AdministrativeAreal2D administrativeAreal2D, IEnumerable<AdministrativeAreal2D> administrativeAreal2Ds)
            : base(administrativeAreal2D, administrativeAreal2Ds)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrativeAreal2DAdministrativeAreal2DsRelation"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the relation data.</param>
        public AdministrativeAreal2DAdministrativeAreal2DsRelation(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrativeAreal2DAdministrativeAreal2DsRelation"/> class by copying an existing relation.
        /// </summary>
        /// <param name="administrativeAreal2DAdministrativeAreal2DsRelation">The source relation instance to copy.</param>
        public AdministrativeAreal2DAdministrativeAreal2DsRelation(AdministrativeAreal2DAdministrativeAreal2DsRelation administrativeAreal2DAdministrativeAreal2DsRelation)
            : base(administrativeAreal2DAdministrativeAreal2DsRelation)
        {
        }
    }
}