using DiGi.Core.Relation.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public class AdministrativeAreal2DStatisticalUnitsCalculcationRelation : OneToOneDirectionalRelation<AdministrativeAreal2D, AdministrativeAreal2DStatisticalUnitsCalculcationResult>, IGISRelation
    {
        public AdministrativeAreal2DStatisticalUnitsCalculcationRelation(AdministrativeAreal2D administrativeAreal2D, AdministrativeAreal2DStatisticalUnitsCalculcationResult administrativeAreal2DStatisticalUnitsCalculcationResult) 
            : base(administrativeAreal2D, administrativeAreal2DStatisticalUnitsCalculcationResult)
        {
        }

        public AdministrativeAreal2DStatisticalUnitsCalculcationRelation(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public AdministrativeAreal2DStatisticalUnitsCalculcationRelation(AdministrativeAreal2DStatisticalUnitsCalculcationRelation administrativeAreal2DStatisticalUnitsCalculcationRelation)
            : base(administrativeAreal2DStatisticalUnitsCalculcationRelation)
        {
        }
    }
}
