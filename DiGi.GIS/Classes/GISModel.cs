using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;
using DiGi.Core.Relation.Classes;
using System.Collections.Generic;

namespace DiGi.GIS.Classes
{
    public class GISModel : UniqueObjectRelationClusterModel<IGISUniqueObject, IGISRelation>, IGISUniqueObject
    {
        public GISModel()
        {

        }

        public GISModel(ISource source)
        {
            Update(source);
        }

        public GISModel(GISModel gISModel)
            :base(gISModel)
        {

        }

        public GISModel(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public bool Update(ISource source)
        {
            if (source == null)
            {
                return false;
            }

            List<ISource> sources = uniqueObjectRelationCluster.GetValues<ISource>();
            if(sources != null && sources.Count != 0)
            {
                uniqueObjectRelationCluster.Remove(source);
            }

            return uniqueObjectRelationCluster.Add(source?.Clone<ISource>());
        }

        public bool Update(Building2D building2D)
        {
            if(building2D == null)
            {
                return false;
            }

            return uniqueObjectRelationCluster.Add(building2D?.Clone<Building2D>());
        }

        public bool Update(AdministrativeAreal2D administrativeAreal2D)
        {
            if (administrativeAreal2D == null)
            {
                return false;
            }

            return uniqueObjectRelationCluster.Add(administrativeAreal2D?.Clone<AdministrativeAreal2D>());
        }

        public bool Contains(Building2D building2D)
        {
            if (building2D != null)
            {
                return false;
            }

            return uniqueObjectRelationCluster.Contains(new GuidReference(building2D));
        }

        public bool Contains(AdministrativeAreal2D administrativeAreal2D)
        {
            if (administrativeAreal2D != null)
            {
                return false;
            }

            return uniqueObjectRelationCluster.Contains(new GuidReference(administrativeAreal2D));
        }
    }
}
