using DiGi.Core.Relation.Classes;
using DiGi.GIS.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public class AdministrativeAreal2DAdministrativeAreal2DsRelation : OneToManyBidirectionalRelation<AdministrativeAreal2D, AdministrativeAreal2D>, IGISRelation
    {
        public AdministrativeAreal2DAdministrativeAreal2DsRelation(AdministrativeAreal2D administrativeAreal2D, IEnumerable<AdministrativeAreal2D> administrativeAreal2Ds)
            : base(administrativeAreal2D, administrativeAreal2Ds)
        {
        }

        public AdministrativeAreal2DAdministrativeAreal2DsRelation(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public AdministrativeAreal2DAdministrativeAreal2DsRelation(AdministrativeAreal2DAdministrativeAreal2DsRelation administrativeAreal2DAdministrativeAreal2DsRelation)
            : base(administrativeAreal2DAdministrativeAreal2DsRelation)
        {
        }
    }
}
