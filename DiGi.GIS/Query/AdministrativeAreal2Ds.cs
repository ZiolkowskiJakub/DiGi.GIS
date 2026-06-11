using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves a list of administrative areal objects associated with the specified building within the GIS model.
        /// </summary>
        /// <typeparam name="UAdministrativeAreal2D">The type of the administrative areal object, which must derive from <see cref="AdministrativeAreal2D"/>.</typeparam>
        /// <param name="gISModel">The GIS model instance used to query relations and objects.</param>
        /// <param name="building2D">The building object for which associated administrative areals are retrieved.</param>
        /// <returns>A list of <typeparamref name="UAdministrativeAreal2D"/> objects if associations exist; otherwise, null.</returns>
        public static List<UAdministrativeAreal2D>? AdministrativeAreal2Ds<UAdministrativeAreal2D>(this GISModel? gISModel, Building2D? building2D) where UAdministrativeAreal2D : AdministrativeAreal2D
        {
            if (gISModel == null || building2D == null)
            {
                return null;
            }

            GuidReference guidReference = new(building2D);

            List<AdministrativeAreal2DBuilding2DsRelation>? administrativeAreal2DBuilding2DsRelations = gISModel.GetRelations<AdministrativeAreal2DBuilding2DsRelation>(x => x is not null && x.Contains(Core.Relation.Enums.RelationSide.To, guidReference));
            if (administrativeAreal2DBuilding2DsRelations == null)
            {
                return null;
            }

            List<UAdministrativeAreal2D> result = [];
            foreach (AdministrativeAreal2DBuilding2DsRelation administrativeAreal2DBuilding2DsRelation in administrativeAreal2DBuilding2DsRelations)
            {
                List<UAdministrativeAreal2D>? administrativeAreal2Ds = gISModel.GetObjects<UAdministrativeAreal2D>(administrativeAreal2DBuilding2DsRelation, Core.Relation.Enums.RelationSide.From);
                if (administrativeAreal2Ds != null)
                {
                    result.AddRange(administrativeAreal2Ds);
                }
            }

            return result;
        }
    }
}