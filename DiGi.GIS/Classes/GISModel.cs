using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Core.Relation.Classes;
using DiGi.GIS.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a GIS model that manages unique objects such as Building2D, AdministrativeAreal2D and their relations
    /// </summary>
    public class GISModel : UniqueObjectRelationClusterModel<IGISUniqueObject, IGISRelation>, IGISUniqueObject
    {
        [JsonInclude, JsonPropertyName("Reference")]
        private readonly string? reference;

        /// <summary>
        /// Initializes a new instance of the GISModel class
        /// </summary>
        public GISModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GISModel class with a reference and source
        /// </summary>
        /// <param name="reference">An optional reference string</param>
        /// <param name="source">An optional source to update from</param>
        public GISModel(string? reference, ISource? source)
        {
            this.reference = reference;

            Update(source);
        }

        /// <summary>
        /// Initializes a new instance of the GISModel class by copying another instance
        /// </summary>
        /// <param name="gISModel">The instance to copy</param>
        public GISModel(GISModel? gISModel)
            : base(gISModel)
        {
            if (gISModel is not null)
            {
                reference = gISModel.reference;
            }
        }

        /// <summary>
        /// Initializes a new instance of the GISModel class with a reference and a source model
        /// </summary>
        /// <param name="reference">An optional reference string</param>
        /// <param name="gISModel">An optional GISModel to copy from</param>
        public GISModel(string? reference, GISModel? gISModel)
            : base(gISModel)
        {
            this.reference = reference;
        }

        /// <summary>
        /// Initializes a new instance of the GISModel class from a JSON object
        /// </summary>
        /// <param name="jsonObject">The JSON object to deserialize from</param>
        public GISModel(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the reference string for this GIS model
        /// </summary>
        [JsonIgnore]
        public string? Reference
        {
            get
            {
                return reference;
            }
        }

        /// <summary>
        /// Determines whether the model contains the specified building
        /// </summary>
        /// <param name="building2D">The building to check</param>
        public bool Contains(Building2D? building2D)
        {
            if (building2D != null)
            {
                return false;
            }

            return uniqueObjectRelationCluster.Contains(new GuidReference(building2D));
        }

        /// <summary>
        /// Determines whether the model contains the specified administrative area
        /// </summary>
        /// <param name="administrativeAreal2D">The administrative area to check</param>
        public bool Contains(AdministrativeAreal2D? administrativeAreal2D)
        {
            if (administrativeAreal2D != null)
            {
                return false;
            }

            return uniqueObjectRelationCluster.Contains(new GuidReference(administrativeAreal2D));
        }

        /// <summary>
        /// Gets an object of the specified type by its reference
        /// </summary>
        /// <typeparam name="TGISGuidObject2D">The type of GIS object to retrieve</typeparam>
        /// <param name="reference">The reference of the object to retrieve</param>
        public TGISGuidObject2D? GetObject<TGISGuidObject2D>(string? reference) where TGISGuidObject2D : GISGuidObject2D
        {
            if (!TryGetObject(reference, out TGISGuidObject2D? result))
            {
                return default;
            }

            return result;
        }

        /// <summary>
        /// Gets a list of objects of the specified type by their references
        /// </summary>
        /// <typeparam name="TGISGuidObject2D">The type of GIS objects to retrieve</typeparam>
        /// <param name="references">The references of the objects to retrieve</param>
        public List<TGISGuidObject2D>? GetObjects<TGISGuidObject2D>(IEnumerable<string?>? references) where TGISGuidObject2D : GISGuidObject2D
        {
            if (!TryGetObjects(references, out List<TGISGuidObject2D>? result))
            {
                return null;
            }

            return result;
        }

        /// <summary>
        /// Gets the references of all objects of the specified type in the model
        /// </summary>
        /// <typeparam name="TGISGuidObject2D">The type of GIS objects to get references for</typeparam>
        public HashSet<string>? GetReferences<TGISGuidObject2D>() where TGISGuidObject2D : GISGuidObject2D
        {
            if (uniqueObjectRelationCluster == null)
            {
                return null;
            }

            if (!uniqueObjectRelationCluster.TryGetValues(out List<TGISGuidObject2D>? gISGuidObject2Ds, null) || gISGuidObject2Ds == null)
            {
                return null;
            }

            HashSet<string> result = [];
            foreach (TGISGuidObject2D gISGuidObject2D in gISGuidObject2Ds)
            {
                string? reference = gISGuidObject2D?.Reference;
                if (reference == null)
                {
                    continue;
                }

                result.Add(reference);
            }

            return result;
        }

        /// <summary>
        /// Tries to get an object of the specified type by its reference
        /// </summary>
        /// <typeparam name="TGISGuidObject2D">The type of GIS object to retrieve</typeparam>
        /// <param name="reference">The reference of the object to retrieve</param>
        /// <param name="gISGuidObject2D">When this method returns, contains the retrieved object, or null if not found</param>
        public bool TryGetObject<TGISGuidObject2D>(string? reference, out TGISGuidObject2D? gISGuidObject2D) where TGISGuidObject2D : GISGuidObject2D
        {
            gISGuidObject2D = null;

            bool result = TryGetObjects([reference], out List<TGISGuidObject2D>? gISGuidObject2Ds, 1);
            if (!result || gISGuidObject2Ds is null || gISGuidObject2Ds.Count == 0)
            {
                return false;
            }
            gISGuidObject2D = gISGuidObject2Ds[0];
            return true;
        }

        /// <summary>
        /// Tries to get a list of objects of the specified type by their references
        /// </summary>
        /// <typeparam name="TGISGuidObject2D">The type of GIS objects to retrieve</typeparam>
        /// <param name="references">The references of the objects to retrieve</param>
        /// <param name="gISGuidObject2Ds">When this method returns, contains the retrieved objects, or null if not found</param>
        /// <param name="maxCount">The maximum number of objects to retrieve</param>
        public virtual bool TryGetObjects<TGISGuidObject2D>(IEnumerable<string?>? references, out List<TGISGuidObject2D>? gISGuidObject2Ds, int maxCount = int.MaxValue) where TGISGuidObject2D : GISGuidObject2D
        {
            gISGuidObject2Ds = null;

            if (references is null || !references.Any())
            {
                return false;
            }

            if (maxCount <= 0)
            {
                return false;
            }

            if (!uniqueObjectRelationCluster.TryGetValues(out List<TGISGuidObject2D>? gISGuidObject2Ds_Temp, null) || gISGuidObject2Ds_Temp == null)
            {
                return false;
            }

            int i = 0;
            gISGuidObject2Ds = [];
            foreach (TGISGuidObject2D gISGuidObject2D_Temp in gISGuidObject2Ds_Temp)
            {
                if (references.Contains(gISGuidObject2D_Temp?.Reference) && gISGuidObject2D_Temp.Clone<TGISGuidObject2D>() is TGISGuidObject2D gISGuidObject2D_Clone)
                {
                    gISGuidObject2Ds.Add(gISGuidObject2D_Clone);
                    i++;

                    if (i >= maxCount)
                    {
                        break;
                    }
                }
            }

            return gISGuidObject2Ds.Count != 0;
        }

        /// <summary>
        /// Updates the model from a source
        /// </summary>
        /// <param name="source">The source to update from</param>
        public bool Update(ISource? source)
        {
            if (source == null)
            {
                return false;
            }

            List<ISource> sources = uniqueObjectRelationCluster.GetValues<ISource>();
            if (sources != null && sources.Count != 0)
            {
                uniqueObjectRelationCluster.Remove(source);
            }

            return uniqueObjectRelationCluster.Add(source?.Clone<ISource>());
        }

        /// <summary>
        /// Updates the model with the specified building
        /// </summary>
        /// <param name="building2D">The building to update with</param>
        public bool Update(Building2D? building2D)
        {
            return Update((IGISUniqueObject?)building2D);
        }

        /// <summary>
        /// Updates the model with the specified administrative area
        /// </summary>
        /// <param name="administrativeAreal2D">The administrative area to update with</param>
        public bool Update(AdministrativeAreal2D? administrativeAreal2D)
        {
            return Update((IGISUniqueObject?)administrativeAreal2D);
        }

        /// <summary>
        /// Updates the model with the specified building and its geometry calculation result
        /// </summary>
        /// <param name="building2D">The building to update with</param>
        /// <param name="building2DGeometryCalculationResult">The geometry calculation result to update with</param>
        public bool Update(Building2D? building2D, Building2DGeometryCalculationResult? building2DGeometryCalculationResult)
        {
            if (building2D == null || building2DGeometryCalculationResult == null)
            {
                return false;
            }

            Update(building2D);
            Update(building2DGeometryCalculationResult);

            Building2DGeometryCalculationResult? building2DGeometryCalculationResult_Old = GetRelatedObject<Building2DGeometryCalculationResult>(building2D);
            if (building2DGeometryCalculationResult_Old != null)
            {
                uniqueObjectRelationCluster.Remove(building2DGeometryCalculationResult_Old);
            }

            uniqueObjectRelationCluster.AddRelation(new Building2DGeometryCalculationResultRelation(building2D, building2DGeometryCalculationResult));
            return true;
        }

        /// <summary>
        /// Updates the model with the specified administrative area and its geometry calculation result
        /// </summary>
        /// <param name="administrativeAreal2D">The administrative area to update with</param>
        /// <param name="administrativeAreal2DGeometryCalculationResult">The geometry calculation result to update with</param>
        public bool Update(AdministrativeAreal2D? administrativeAreal2D, AdministrativeAreal2DGeometryCalculationResult? administrativeAreal2DGeometryCalculationResult)
        {
            if (administrativeAreal2D == null || administrativeAreal2DGeometryCalculationResult == null)
            {
                return false;
            }

            Update(administrativeAreal2D);
            Update(administrativeAreal2DGeometryCalculationResult);

            AdministrativeAreal2DGeometryCalculationResult? administrativeAreal2DGeometryCalculationResult_Old = GetRelatedObject<AdministrativeAreal2DGeometryCalculationResult>(administrativeAreal2D);
            if (administrativeAreal2DGeometryCalculationResult_Old != null)
            {
                uniqueObjectRelationCluster.Remove(administrativeAreal2DGeometryCalculationResult_Old);
            }

            uniqueObjectRelationCluster.AddRelation(new AdministrativeAreal2DGeometryCalculationResultRelation(administrativeAreal2D, administrativeAreal2DGeometryCalculationResult));
            return true;
        }

        /// <summary>
        /// Updates the model with the specified administrative area and its occupancy calculation result
        /// </summary>
        /// <param name="administrativeAreal2D">The administrative area to update with</param>
        /// <param name="occupancyCalculationResult">The occupancy calculation result to update with</param>
        public bool Update(AdministrativeAreal2D? administrativeAreal2D, OccupancyCalculationResult? occupancyCalculationResult)
        {
            if (administrativeAreal2D == null || occupancyCalculationResult == null)
            {
                return false;
            }

            Update(administrativeAreal2D);
            Update(occupancyCalculationResult);

            OccupancyCalculationResult? occupancyCalculationResult_Old = GetRelatedObject<OccupancyCalculationResult>(administrativeAreal2D);
            if (occupancyCalculationResult_Old != null)
            {
                uniqueObjectRelationCluster.Remove(occupancyCalculationResult_Old);
            }

            uniqueObjectRelationCluster.AddRelation(new AdministrativeAreal2DOccupancyCalculationResultRelation(administrativeAreal2D, occupancyCalculationResult));
            return true;
        }

        /// <summary>
        /// Updates the model with the specified administrative area and its statistical units calculation result
        /// </summary>
        /// <param name="administrativeAreal2D">The administrative area to update with</param>
        /// <param name="administrativeAreal2DStatisticalUnitCalculcationResult">The statistical units calculation result to update with</param>
        public bool Update(AdministrativeAreal2D? administrativeAreal2D, AdministrativeAreal2DStatisticalUnitsCalculcationResult? administrativeAreal2DStatisticalUnitCalculcationResult)
        {
            if (administrativeAreal2D == null || administrativeAreal2DStatisticalUnitCalculcationResult == null)
            {
                return false;
            }

            Update(administrativeAreal2D);
            Update(administrativeAreal2DStatisticalUnitCalculcationResult);

            AdministrativeAreal2DStatisticalUnitsCalculcationResult? administrativeAreal2DStatisticalUnitCalculcationResult_Old = GetRelatedObject<AdministrativeAreal2DStatisticalUnitsCalculcationResult>(administrativeAreal2D);
            if (administrativeAreal2DStatisticalUnitCalculcationResult_Old != null)
            {
                uniqueObjectRelationCluster.Remove(administrativeAreal2DStatisticalUnitCalculcationResult_Old);
            }

            uniqueObjectRelationCluster.AddRelation(new AdministrativeAreal2DStatisticalUnitsCalculcationRelation(administrativeAreal2D, administrativeAreal2DStatisticalUnitCalculcationResult));
            return true;
        }

        /// <summary>
        /// Updates the model with the specified building and its occupancy calculation result
        /// </summary>
        /// <param name="building2D">The building to update with</param>
        /// <param name="occupancyCalculationResult">The occupancy calculation result to update with</param>
        public bool Update(Building2D? building2D, OccupancyCalculationResult? occupancyCalculationResult)
        {
            if (building2D == null || occupancyCalculationResult == null)
            {
                return false;
            }

            Update(building2D);
            Update(occupancyCalculationResult);

            OccupancyCalculationResult? occupancyCalculationResult_Old = GetRelatedObject<OccupancyCalculationResult>(building2D);
            if (occupancyCalculationResult_Old != null)
            {
                uniqueObjectRelationCluster.Remove(occupancyCalculationResult_Old);
            }

            uniqueObjectRelationCluster.AddRelation(new Building2DOccupancyCalculationResultRelation(building2D, occupancyCalculationResult));
            return true;
        }

        /// <summary>
        /// Updates the model with the specified administrative area and its related administrative areas
        /// </summary>
        /// <param name="administrativeAreal2D">The administrative area to update with</param>
        /// <param name="administrativeAreal2Ds">The related administrative areas</param>
        public bool Update(AdministrativeAreal2D administrativeAreal2D, IEnumerable<AdministrativeAreal2D> administrativeAreal2Ds)
        {
            if (administrativeAreal2D == null || administrativeAreal2Ds == null)
            {
                return false;
            }

            GuidReference guidReference = new(administrativeAreal2D);

            AdministrativeAreal2DAdministrativeAreal2DsRelation? administrativeAreal2DAdministrativeAreal2DsRelation_Old = uniqueObjectRelationCluster.GetRelation<AdministrativeAreal2DAdministrativeAreal2DsRelation>(guidReference, x => x?.UniqueReference_From is not null && x.UniqueReference_From == guidReference);
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

        /// <summary>
        /// Updates the model with the specified administrative area and its related buildings
        /// </summary>
        /// <param name="administrativeAreal2D">The administrative area to update with</param>
        /// <param name="building2Ds">The related buildings</param>
        public bool Update(AdministrativeAreal2D? administrativeAreal2D, IEnumerable<Building2D>? building2Ds)
        {
            if (administrativeAreal2D == null || building2Ds == null)
            {
                return false;
            }

            AdministrativeAreal2DBuilding2DsRelation? administrativeAreal2DBuilding2DsRelation_Old = uniqueObjectRelationCluster.GetRelation<AdministrativeAreal2DBuilding2DsRelation>(new GuidReference(administrativeAreal2D));
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

        /// <summary>
        /// Updates the model with the specified building and its external reference GUID result
        /// </summary>
        /// <param name="building2D">The building to update with</param>
        /// <param name="building2DExternalReferenceUniqueResult">The external reference GUID result to update with</param>
        public bool Update(Building2D? building2D, Building2DExternalReferenceGuidResult? building2DExternalReferenceUniqueResult)
        {
            if (building2D == null || building2DExternalReferenceUniqueResult == null)
            {
                return false;
            }

            Update(building2D);
            Update(building2DExternalReferenceUniqueResult);

            Building2DExternalReferenceUniqueResultRelation? building2DExternalReferenceUniqueResultRelation = uniqueObjectRelationCluster.GetRelation<Building2DExternalReferenceUniqueResultRelation>(new GuidReference(building2D));
            if (building2DExternalReferenceUniqueResultRelation == null)
            {
                building2DExternalReferenceUniqueResultRelation = new Building2DExternalReferenceUniqueResultRelation(building2D, [building2DExternalReferenceUniqueResult]);
                uniqueObjectRelationCluster.AddRelation(building2DExternalReferenceUniqueResultRelation);
                return true;
            }

            if (TryGetObjects(building2DExternalReferenceUniqueResultRelation, Core.Relation.Enums.RelationSide.To, out List<Building2DExternalReferenceGuidResult>? building2DExternalReferenceUniqueResults_Relation) && building2DExternalReferenceUniqueResults_Relation != null)
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

        /// <summary>
        /// Updates the model with the specified building and its construction date calculation result
        /// </summary>
        /// <param name="building2D">The building to update with</param>
        /// <param name="building2DConstructionDateCalculationResult">The construction date calculation result to update with</param>
        public bool Update(Building2D? building2D, Building2DConstructionDateCalculationResult? building2DConstructionDateCalculationResult)
        {
            if (building2D == null || building2DConstructionDateCalculationResult == null)
            {
                return false;
            }

            Update(building2D);
            Update(building2DConstructionDateCalculationResult);

            Building2DConstructionDateCalculationResultRelation? constructionDateCalculationResultRelation = uniqueObjectRelationCluster.GetRelation<Building2DConstructionDateCalculationResultRelation>(new GuidReference(building2D));
            if (constructionDateCalculationResultRelation == null)
            {
                constructionDateCalculationResultRelation = new Building2DConstructionDateCalculationResultRelation(building2D, [building2DConstructionDateCalculationResult]);
                uniqueObjectRelationCluster.AddRelation(constructionDateCalculationResultRelation);
                return true;
            }

            if (TryGetObjects(constructionDateCalculationResultRelation, Core.Relation.Enums.RelationSide.To, out List<Building2DConstructionDateCalculationResult>? constructionDateCalculationResults_Relation) && constructionDateCalculationResults_Relation != null)
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

        private bool Update(IGISUniqueObject? gISUniqueObject)
        {
            if (gISUniqueObject == null)
            {
                return false;
            }

            return uniqueObjectRelationCluster.Add(gISUniqueObject?.Clone<IGISUniqueObject>());
        }
    }
}