using DiGi.Core.Relation.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a one-to-one directional relation between an administrative areal 2D and an occupancy calculation result.
    /// </summary>
    public class AdministrativeAreal2DOccupancyCalculationResultRelation : OneToOneDirectionalRelation<AdministrativeAreal2D, OccupancyCalculationResult>, IGISRelation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrativeAreal2DOccupancyCalculationResultRelation"/> class.
        /// </summary>
        /// <param name="administrativeAreal2D">The administrative areal 2D entity.</param>
        /// <param name="occupancyCalculationResult">The occupancy calculation result entity.</param>
        public AdministrativeAreal2DOccupancyCalculationResultRelation(AdministrativeAreal2D administrativeAreal2D, OccupancyCalculationResult occupancyCalculationResult)
            : base(administrativeAreal2D, occupancyCalculationResult)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrativeAreal2DOccupancyCalculationResultRelation"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing relation data.</param>
        public AdministrativeAreal2DOccupancyCalculationResultRelation(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrativeAreal2DOccupancyCalculationResultRelation"/> class by copying another instance.
        /// </summary>
        /// <param name="administrativeAreal2DOccupancyCalculationResultRelation">The existing relation instance to copy from.</param>
        public AdministrativeAreal2DOccupancyCalculationResultRelation(AdministrativeAreal2DOccupancyCalculationResultRelation administrativeAreal2DOccupancyCalculationResultRelation)
            : base(administrativeAreal2DOccupancyCalculationResultRelation)
        {
        }
    }
}