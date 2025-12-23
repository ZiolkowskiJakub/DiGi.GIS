using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static Dictionary<GuidReference, List<UAdministrativeAreal2D>?>? AdministrativeAreal2DsDictionary<UAdministrativeAreal2D>(this GISModel? gISModel, IEnumerable<Building2D>? building2Ds) where UAdministrativeAreal2D : AdministrativeAreal2D
        {
            if (gISModel == null || building2Ds == null || building2Ds.Count() == 0)
            {
                return null;
            }

            List<AdministrativeAreal2DBuilding2DsRelation>? administrativeAreal2DBuilding2DsRelations = gISModel.GetRelations<AdministrativeAreal2DBuilding2DsRelation>();
            if (administrativeAreal2DBuilding2DsRelations == null || administrativeAreal2DBuilding2DsRelations.Count == 0)
            {
                return [];
            }

            Dictionary<string, GuidReference> dictionary_GuidReference = [];

            foreach (Building2D building2D in building2Ds)
            {
                if (building2D == null)
                {
                    continue;
                }

                GuidReference guidReference = new(building2D);

                dictionary_GuidReference[guidReference.ToString()!] = guidReference;
            }

            int count = administrativeAreal2DBuilding2DsRelations.Count;

            HashSet<string>[] hashSets = new HashSet<string>[count];
            List<UAdministrativeAreal2D>?[] administrativeAreal2Ds = new List<UAdministrativeAreal2D>?[count];
            for (int i = 0; i < count; i++)
            {
                HashSet<string> hashSet = [];
                administrativeAreal2DBuilding2DsRelations[i].UniqueReferences_To?.ForEach(x => hashSet.Add(x.ToString()));
                hashSets[i] = hashSet;

                administrativeAreal2Ds[i] = gISModel.GetObjects<UAdministrativeAreal2D>(administrativeAreal2DBuilding2DsRelations[i], Core.Relation.Enums.RelationSide.From);
            }

            ConcurrentDictionary<GuidReference, List<UAdministrativeAreal2D>?> concurrentDictionary = new();

            Parallel.For(0, count, i =>
            {
                HashSet<string> hashSet = hashSets[i];
                List<UAdministrativeAreal2D>? administrativeAreal2Ds_Temp = administrativeAreal2Ds[i];

                if (administrativeAreal2Ds_Temp == null || administrativeAreal2Ds_Temp.Count == 0)
                {
                    return;
                }

                foreach (KeyValuePair<string, GuidReference> pair in dictionary_GuidReference)
                {
                    if (!hashSet.Contains(pair.Key))
                    {
                        continue;
                    }

                    List<UAdministrativeAreal2D>? administrativeAreal2Ds_Current = concurrentDictionary.GetOrAdd(pair.Value, _ => []);
                    if (administrativeAreal2Ds_Current is null)
                    {
                        continue;
                    }

                    lock (administrativeAreal2Ds_Current)
                    {
                        administrativeAreal2Ds_Current.AddRange(administrativeAreal2Ds_Temp);
                    }
                }
            });

            return new Dictionary<GuidReference, List<UAdministrativeAreal2D>?>(concurrentDictionary);
        }
    }
}