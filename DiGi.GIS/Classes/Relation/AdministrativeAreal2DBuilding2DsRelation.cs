using DiGi.Core.Relation.Classes;
using DiGi.GIS.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public class AdministrativeAreal2DBuilding2DsRelation : OneToManyBidirectionalRelation<AdministrativeAreal2D, Building2D>, IGISRelation
    {
        public AdministrativeAreal2DBuilding2DsRelation(AdministrativeAreal2D administrativeAreal2D, IEnumerable<Building2D> building2Ds)
            : base(administrativeAreal2D, building2Ds)
        {
        }

        public AdministrativeAreal2DBuilding2DsRelation(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public AdministrativeAreal2DBuilding2DsRelation(AdministrativeAreal2DBuilding2DsRelation administrativeAreal2DBuilding2DsRelation)
            : base(administrativeAreal2DBuilding2DsRelation)
        {
        }
    }
}
