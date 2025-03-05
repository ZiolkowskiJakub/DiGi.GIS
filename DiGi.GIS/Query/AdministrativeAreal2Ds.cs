using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static List<UAdministrativeAreal2D> AdministrativeAreal2Ds<UAdministrativeAreal2D>(this GISModel gISModel, Building2D building2D) where UAdministrativeAreal2D : AdministrativeAreal2D
        {
            if(gISModel == null || building2D == null)
            {
                return null;
            }

            GuidReference guidReference = new GuidReference(building2D);

            List<AdministrativeAreal2DBuilding2DsRelation> administrativeAreal2DBuilding2DsRelations = gISModel.GetRelations<AdministrativeAreal2DBuilding2DsRelation>(x => x.Contains(Core.Relation.Enums.RelationSide.To, guidReference));
            if(administrativeAreal2DBuilding2DsRelations == null)
            {
                return null;
            }

            List<UAdministrativeAreal2D> result = new List<UAdministrativeAreal2D>();
            foreach (AdministrativeAreal2DBuilding2DsRelation administrativeAreal2DBuilding2DsRelation in administrativeAreal2DBuilding2DsRelations)
            {
                List<UAdministrativeAreal2D> administrativeAreal2Ds = gISModel.GetObjects<UAdministrativeAreal2D>(administrativeAreal2DBuilding2DsRelation, Core.Relation.Enums.RelationSide.From);
                if(administrativeAreal2Ds != null)
                {
                    result.AddRange(administrativeAreal2Ds);
                }
            }

            return result;
        }
    }
}