using DiGi.Core.Relation.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a one-to-one directional relation between an administrative areal 2D object and its statistical units calculation result.
    /// </summary>
    public class AdministrativeAreal2DStatisticalUnitsCalculcationRelation : OneToOneDirectionalRelation<AdministrativeAreal2D, AdministrativeAreal2DStatisticalUnitsCalculcationResult>, IGISRelation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrativeAreal2DStatisticalUnitsCalculcationRelation"/> class with specified source and target objects.
        /// </summary>
        /// <param name="administrativeAreal2D">The source administrative areal 2D object.</param>
        /// <param name="administrativeAreal2DStatisticalUnitsCalculcationResult">The target statistical units calculation result object.</param>
        public AdministrativeAreal2DStatisticalUnitsCalculcationRelation(AdministrativeAreal2D administrativeAreal2D, AdministrativeAreal2DStatisticalUnitsCalculcationResult administrativeAreal2DStatisticalUnitsCalculcationResult)
            : base(administrativeAreal2D, administrativeAreal2DStatisticalUnitsCalculcationResult)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrativeAreal2DStatisticalUnitsCalculcationRelation"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing relation data.</param>
        public AdministrativeAreal2DStatisticalUnitsCalculcationRelation(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrativeAreal2DStatisticalUnitsCalculcationRelation"/> class by copying another instance.
        /// </summary>
        /// <param name="administrativeAreal2DStatisticalUnitsCalculcationRelation">The existing relation instance to copy from.</param>
        public AdministrativeAreal2DStatisticalUnitsCalculcationRelation(AdministrativeAreal2DStatisticalUnitsCalculcationRelation administrativeAreal2DStatisticalUnitsCalculcationRelation)
            : base(administrativeAreal2DStatisticalUnitsCalculcationRelation)
        {
        }
    }
}