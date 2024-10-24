using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Core.Relation.Classes;

namespace DiGi.GIS.Classes
{
    public class GISModel : UniqueObjectRelationClusterModel<IGISUniqueObject, IGISRelation>, IGISUniqueObject
    {
        [JsonInclude, JsonPropertyName("Source")]
        private ISource source;

        public GISModel()
        {

        }

        public GISModel(ISource source)
        {
            this.source = source?.Clone<ISource>();
        }

        public GISModel(GISModel gISModel)
            :base(gISModel)
        {

        }

        public GISModel(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public ISource Source
        {
            get
            {
                return source.Clone<ISource>();
            }
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
