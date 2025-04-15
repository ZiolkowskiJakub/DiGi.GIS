using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static Dictionary<GuidReference, List<UAdministrativeAreal2D>> AdministrativeAreal2DsDictionary<UAdministrativeAreal2D>(this GISModel gISModel, IEnumerable<Building2D> building2Ds) where UAdministrativeAreal2D : AdministrativeAreal2D
        {
            if(gISModel == null || building2Ds == null || building2Ds.Count() == 0)
            {
                return null;
            }

            Dictionary<GuidReference, List<UAdministrativeAreal2D>> result = new Dictionary<GuidReference, List<UAdministrativeAreal2D>>();

            List<AdministrativeAreal2DBuilding2DsRelation> administrativeAreal2DBuilding2DsRelations = gISModel.GetRelations<AdministrativeAreal2DBuilding2DsRelation>();
            if(administrativeAreal2DBuilding2DsRelations == null || administrativeAreal2DBuilding2DsRelations.Count == 0)
            {
                return result;
            }

            foreach(Building2D building2D in building2Ds)
            {
                if(building2D == null)
                {
                    continue;
                }

                result[new GuidReference(building2D)] = null;
            }

            Parallel.ForEach(building2Ds, building2D => 
            {
                GuidReference guidReference = new GuidReference(building2D);

                foreach (AdministrativeAreal2DBuilding2DsRelation administrativeAreal2DBuilding2DsRelation in administrativeAreal2DBuilding2DsRelations)
                {
                    if(administrativeAreal2DBuilding2DsRelation == null || !administrativeAreal2DBuilding2DsRelation.Contains(Core.Relation.Enums.RelationSide.To, guidReference))
                    {
                        continue;
                    }

                    List<UAdministrativeAreal2D> administrativeAreal2Ds = gISModel.GetObjects<UAdministrativeAreal2D>(administrativeAreal2DBuilding2DsRelation, Core.Relation.Enums.RelationSide.From);
                    if(administrativeAreal2Ds == null || administrativeAreal2Ds.Count == 0)
                    {
                        continue;
                    }

                    if(!result.TryGetValue(guidReference, out List<UAdministrativeAreal2D> administrativeAreal2Ds_Temp) || administrativeAreal2Ds_Temp == null)
                    {
                        administrativeAreal2Ds_Temp = new List<UAdministrativeAreal2D>();
                        result[guidReference] = administrativeAreal2Ds_Temp;
                    }

                    foreach(UAdministrativeAreal2D administrativeAreal2D in administrativeAreal2Ds)
                    {
                        UAdministrativeAreal2D administrativeAreal2D_Temp = administrativeAreal2Ds_Temp.Find(x => x.Guid == administrativeAreal2D.Guid);
                        if(administrativeAreal2D_Temp == null)
                        {
                            administrativeAreal2Ds_Temp.Add(administrativeAreal2D);
                        }
                    }
                }
            });

            return result;
        }
    }
}