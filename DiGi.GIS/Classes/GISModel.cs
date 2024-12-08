using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;
using DiGi.Core.Relation.Classes;
using System.Collections.Generic;
using System.Linq;

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
            return Update((IGISUniqueObject)building2D);
        }

        public bool Update(AdministrativeAreal2D administrativeAreal2D)
        {
            return Update((IGISUniqueObject)administrativeAreal2D);
        }

        private bool Update(IGISUniqueObject gISUniqueObject)
        {
            if (gISUniqueObject == null)
            {
                return false;
            }

            return uniqueObjectRelationCluster.Add(gISUniqueObject?.Clone<IGISUniqueObject>());
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

        public bool Update(Building2D building2D, Building2DGeometryCalculationResult building2DGeometryCalculationResult)
        {
            if(building2D == null || building2DGeometryCalculationResult == null)
            {
                return false;
            }

            Update(building2D);
            Update(building2DGeometryCalculationResult);

            Building2DGeometryCalculationResult building2DGeometryCalculationResult_Old = GetRelatedObject<Building2DGeometryCalculationResult>(building2D);
            if(building2DGeometryCalculationResult_Old != null)
            {
                uniqueObjectRelationCluster.Remove(building2DGeometryCalculationResult_Old);
            }

            uniqueObjectRelationCluster.AddRelation(new Building2DGeometryCalculationResultRelation(building2D, building2DGeometryCalculationResult));
            return true;
        }

        public bool Update(AdministrativeAreal2D administrativeAreal2D, AdministrativeAreal2DGeometryCalculationResult administrativeAreal2DGeometryCalculationResult)
        {
            if (administrativeAreal2D == null || administrativeAreal2DGeometryCalculationResult == null)
            {
                return false;
            }

            Update(administrativeAreal2D);
            Update(administrativeAreal2DGeometryCalculationResult);

            AdministrativeAreal2DGeometryCalculationResult administrativeAreal2DGeometryCalculationResult_Old = GetRelatedObject<AdministrativeAreal2DGeometryCalculationResult>(administrativeAreal2D);
            if (administrativeAreal2DGeometryCalculationResult_Old != null)
            {
                uniqueObjectRelationCluster.Remove(administrativeAreal2DGeometryCalculationResult_Old);
            }

            uniqueObjectRelationCluster.AddRelation(new AdministrativeAreal2DGeometryCalculationResultRelation(administrativeAreal2D, administrativeAreal2DGeometryCalculationResult));
            return true;
        }

        public bool Update(AdministrativeAreal2D administrativeAreal2D, OccupancyCalculationResult occupancyCalculationResult)
        {
            if (administrativeAreal2D == null || occupancyCalculationResult == null)
            {
                return false;
            }

            Update(administrativeAreal2D);
            Update(occupancyCalculationResult);

            OccupancyCalculationResult occupancyCalculationResult_Old = GetRelatedObject<OccupancyCalculationResult>(administrativeAreal2D);
            if (occupancyCalculationResult_Old != null)
            {
                uniqueObjectRelationCluster.Remove(occupancyCalculationResult_Old);
            }

            uniqueObjectRelationCluster.AddRelation(new AdministrativeAreal2DOccupancyCalculationResultRelation(administrativeAreal2D, occupancyCalculationResult));
            return true;
        }

        public bool Update(Building2D building2D, OccupancyCalculationResult occupancyCalculationResult)
        {
            if (building2D == null || occupancyCalculationResult == null)
            {
                return false;
            }

            Update(building2D);
            Update(occupancyCalculationResult);

            OccupancyCalculationResult occupancyCalculationResult_Old = GetRelatedObject<OccupancyCalculationResult>(building2D);
            if (occupancyCalculationResult_Old != null)
            {
                uniqueObjectRelationCluster.Remove(occupancyCalculationResult_Old);
            }

            uniqueObjectRelationCluster.AddRelation(new Building2DOccupancyCalculationResultRelation(building2D, occupancyCalculationResult));
            return true;
        }

        public bool Update(AdministrativeAreal2D administrativeAreal2D, IEnumerable<AdministrativeAreal2D> administrativeAreal2Ds)
        {
            if (administrativeAreal2D == null || administrativeAreal2Ds == null)
            {
                return false;
            }

            GuidReference guidReference = new GuidReference(administrativeAreal2D);

            AdministrativeAreal2DAdministrativeAreal2DsRelation administrativeAreal2DAdministrativeAreal2DsRelation_Old = uniqueObjectRelationCluster.GetRelation<AdministrativeAreal2DAdministrativeAreal2DsRelation>(guidReference, x => x.UniqueReference_From == guidReference);
            if (administrativeAreal2DAdministrativeAreal2DsRelation_Old != null)
            {
                uniqueObjectRelationCluster.Remove(administrativeAreal2DAdministrativeAreal2DsRelation_Old);
            }

            if (administrativeAreal2Ds == null || administrativeAreal2Ds.Count() == 0)
            {
                return true;
            }

            uniqueObjectRelationCluster.AddRelation(new AdministrativeAreal2DAdministrativeAreal2DsRelation(administrativeAreal2D, administrativeAreal2Ds));
            return true;
        }

        public bool Update(AdministrativeAreal2D administrativeAreal2D, IEnumerable<Building2D> building2Ds)
        {
            if (administrativeAreal2D == null || building2Ds == null)
            {
                return false;
            }

            AdministrativeAreal2DBuilding2DsRelation administrativeAreal2DBuilding2DsRelation_Old = uniqueObjectRelationCluster.GetRelation<AdministrativeAreal2DBuilding2DsRelation>(new GuidReference(administrativeAreal2D));
            if (administrativeAreal2DBuilding2DsRelation_Old != null)
            {
                uniqueObjectRelationCluster.Remove(administrativeAreal2DBuilding2DsRelation_Old);
            }

            if(building2Ds == null || building2Ds.Count() == 0)
            {
                return true;
            }

            uniqueObjectRelationCluster.AddRelation(new AdministrativeAreal2DBuilding2DsRelation(administrativeAreal2D, building2Ds));
            return true;
        }

        public bool Update(Building2D building2D, OrtoDatasCalculationResult ortoDatasCalculationResult)
        {
            if (building2D == null || ortoDatasCalculationResult == null)
            {
                return false;
            }

            Update(building2D);
            Update(ortoDatasCalculationResult);

            OrtoDatasCalculationResult ortoDatasCalculationResult_Old = GetRelatedObject<OrtoDatasCalculationResult>(building2D);
            if (ortoDatasCalculationResult_Old != null)
            {
                uniqueObjectRelationCluster.Remove(ortoDatasCalculationResult_Old);
            }

            uniqueObjectRelationCluster.AddRelation(new OrtoDatasCalculationResultRelation(building2D, ortoDatasCalculationResult));
            return true;
        }

        public bool Update(Building2D building2D, ConstructionDateCalculationResult constructionDateCalculationResult)
        {
            if (building2D == null || constructionDateCalculationResult == null)
            {
                return false;
            }

            Update(building2D);
            Update(constructionDateCalculationResult);

            ConstructionDateCalculationResultRelation constructionDateCalculationResultRelation = GetRelation<ConstructionDateCalculationResultRelation>(building2D);
            if(constructionDateCalculationResultRelation == null)
            {
                constructionDateCalculationResultRelation = new ConstructionDateCalculationResultRelation(building2D, new ConstructionDateCalculationResult[] { constructionDateCalculationResult });
                uniqueObjectRelationCluster.AddRelation(constructionDateCalculationResultRelation);
                return true;
            }
            else
            {
                List<ConstructionDateCalculationResult> constructionDateCalculationResults =  GetObjects<ConstructionDateCalculationResult>( );
            }

            //TODO: Finish Implementation
            throw new System.NotImplementedException();
            
            return true;
        }
    }
}
