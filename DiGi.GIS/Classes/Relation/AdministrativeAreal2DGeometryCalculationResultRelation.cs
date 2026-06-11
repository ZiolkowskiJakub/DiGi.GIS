using DiGi.Core.Relation.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a one-to-one directional relation between an administrative areal 2D object and its geometry calculation result.
    /// </summary>
    public class AdministrativeAreal2DGeometryCalculationResultRelation : OneToOneDirectionalRelation<AdministrativeAreal2D, AdministrativeAreal2DGeometryCalculationResult>, IGISRelation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrativeAreal2DGeometryCalculationResultRelation"/> class using the specified source and target objects.
        /// </summary>
        /// <param name="administrativeAreal2D">The source administrative areal 2D object.</param>
        /// <param name="administrativeAreal2DGeometryCalculationResult">The target geometry calculation result object.</param>
        public AdministrativeAreal2DGeometryCalculationResultRelation(AdministrativeAreal2D administrativeAreal2D, AdministrativeAreal2DGeometryCalculationResult administrativeAreal2DGeometryCalculationResult)
            : base(administrativeAreal2D, administrativeAreal2DGeometryCalculationResult)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrativeAreal2DGeometryCalculationResultRelation"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the relation data.</param>
        public AdministrativeAreal2DGeometryCalculationResultRelation(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrativeAreal2DGeometryCalculationResultRelation"/> class by copying another relation instance.
        /// </summary>
        /// <param name="building2DGeometryCalculationResultRelation">The existing relation instance to copy from.</param>
        public AdministrativeAreal2DGeometryCalculationResultRelation(AdministrativeAreal2DGeometryCalculationResultRelation building2DGeometryCalculationResultRelation)
            : base(building2DGeometryCalculationResultRelation)
        {
        }
    }
}