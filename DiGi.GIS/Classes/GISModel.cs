using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Core.Relation.Classes;
using DiGi.GIS.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;

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

        public HashSet<string> GetReferences<T>() where T : GISGuidObject2D
        {
            if (uniqueObjectRelationCluster == null)
            {
                return null;
            }

            if (!uniqueObjectRelationCluster.TryGetValues(out List<T> gISGuidObject2Ds, null) || gISGuidObject2Ds == null)
            {
                return null;
            }

            HashSet<string> result = new HashSet<string>();
            foreach(T gISGuidObject2D in gISGuidObject2Ds)
            {
                string reference = gISGuidObject2D?.Reference;
                if(reference == null)
                {
                    continue;
                }

                result.Add(reference);
            }

            return result;
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

        public bool Update(Building2D building2D, Building2DGeometryCalculationResult building2DGeometryCalculationResult)
        {
            if (building2D == null || building2DGeometryCalculationResult == null)
            {
                return false;
            }

            Update(building2D);
            Update(building2DGeometryCalculationResult);

            Building2DGeometryCalculationResult building2DGeometryCalculationResult_Old = GetRelatedObject<Building2DGeometryCalculationResult>(building2D);
            if (building2DGeometryCalculationResult_Old != null)
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

        public bool Update(AdministrativeAreal2D administrativeAreal2D, AdministrativeAreal2DStatisticalUnitsCalculcationResult administrativeAreal2DStatisticalUnitCalculcationResult)
        {
            if (administrativeAreal2D == null || administrativeAreal2DStatisticalUnitCalculcationResult == null)
            {
                return false;
            }

            Update(administrativeAreal2D);
            Update(administrativeAreal2DStatisticalUnitCalculcationResult);

            AdministrativeAreal2DStatisticalUnitsCalculcationResult administrativeAreal2DStatisticalUnitCalculcationResult_Old = GetRelatedObject<AdministrativeAreal2DStatisticalUnitsCalculcationResult>(administrativeAreal2D);
            if (administrativeAreal2DStatisticalUnitCalculcationResult_Old != null)
            {
                uniqueObjectRelationCluster.Remove(administrativeAreal2DStatisticalUnitCalculcationResult_Old);
            }

            uniqueObjectRelationCluster.AddRelation(new AdministrativeAreal2DStatisticalUnitsCalculcationRelation(administrativeAreal2D, administrativeAreal2DStatisticalUnitCalculcationResult));
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

            if (building2Ds == null || building2Ds.Count() == 0)
            {
                return true;
            }

            uniqueObjectRelationCluster.AddRelation(new AdministrativeAreal2DBuilding2DsRelation(administrativeAreal2D, building2Ds));
            return true;
        }

        public bool Update(Building2D building2D, Building2DExternalReferenceGuidResult building2DExternalReferenceUniqueResult)
        {
            if (building2D == null || building2DExternalReferenceUniqueResult == null)
            {
                return false;
            }

            Update(building2D);
            Update(building2DExternalReferenceUniqueResult);

            Building2DExternalReferenceUniqueResultRelation building2DExternalReferenceUniqueResultRelation = uniqueObjectRelationCluster.GetRelation<Building2DExternalReferenceUniqueResultRelation>(new GuidReference(building2D));
            if (building2DExternalReferenceUniqueResultRelation == null)
            {
                building2DExternalReferenceUniqueResultRelation = new Building2DExternalReferenceUniqueResultRelation(building2D, new Building2DExternalReferenceGuidResult[] { building2DExternalReferenceUniqueResult });
                uniqueObjectRelationCluster.AddRelation(building2DExternalReferenceUniqueResultRelation);
                return true;
            }

            if (TryGetObjects(building2DExternalReferenceUniqueResultRelation, Core.Relation.Enums.RelationSide.To, out List<Building2DExternalReferenceGuidResult> building2DExternalReferenceUniqueResults_Relation) && building2DExternalReferenceUniqueResults_Relation != null)
            {
                foreach (Building2DExternalReferenceGuidResult building2DExternalReferenceUniqueResult_Relation in building2DExternalReferenceUniqueResults_Relation)
                {
                    if (building2DExternalReferenceUniqueResult.GetType() == building2DExternalReferenceUniqueResult_Relation.GetType())
                    {
                        uniqueObjectRelationCluster.Remove(building2DExternalReferenceUniqueResult_Relation);
                    }
                }
            }

            building2DExternalReferenceUniqueResultRelation.Add(Core.Relation.Enums.RelationSide.To, Core.Create.UniqueReference(building2DExternalReferenceUniqueResult));
            return true;
        }

        public bool Update(Building2D building2D, Building2DConstructionDateCalculationResult building2DConstructionDateCalculationResult)
        {
            if (building2D == null || building2DConstructionDateCalculationResult == null)
            {
                return false;
            }

            Update(building2D);
            Update(building2DConstructionDateCalculationResult);

            Building2DConstructionDateCalculationResultRelation constructionDateCalculationResultRelation = uniqueObjectRelationCluster.GetRelation<Building2DConstructionDateCalculationResultRelation>(new GuidReference(building2D));
            if (constructionDateCalculationResultRelation == null)
            {
                constructionDateCalculationResultRelation = new Building2DConstructionDateCalculationResultRelation(building2D, new Building2DConstructionDateCalculationResult[] { building2DConstructionDateCalculationResult });
                uniqueObjectRelationCluster.AddRelation(constructionDateCalculationResultRelation);
                return true;
            }

            if (TryGetObjects(constructionDateCalculationResultRelation, Core.Relation.Enums.RelationSide.To, out List<Building2DConstructionDateCalculationResult> constructionDateCalculationResults_Relation) && constructionDateCalculationResults_Relation != null)
            {
                foreach (Building2DConstructionDateCalculationResult constructionDateCalculationResult_Relation in constructionDateCalculationResults_Relation)
                {
                    if (building2DConstructionDateCalculationResult.GetType() == constructionDateCalculationResult_Relation.GetType())
                    {
                        uniqueObjectRelationCluster.Remove(constructionDateCalculationResult_Relation);
                    }
                }
            }

            constructionDateCalculationResultRelation.Add(Core.Relation.Enums.RelationSide.To, Core.Create.UniqueReference(building2DConstructionDateCalculationResult));
            return true;
        }

        private bool Update(IGISUniqueObject gISUniqueObject)
        {
            if (gISUniqueObject == null)
            {
                return false;
            }

            return uniqueObjectRelationCluster.Add(gISUniqueObject?.Clone<IGISUniqueObject>());
        }
    }
}
