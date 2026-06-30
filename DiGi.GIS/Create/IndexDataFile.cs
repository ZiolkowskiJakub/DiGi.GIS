using DiGi.GIS.Classes;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Create
    {
        /// <summary>
        /// Creates an IndexDataFile from a collection of administrative areal entities.
        /// </summary>
        /// <typeparam name="TAdministrativeAreal2D">The type of the administrative areal entity, which must inherit from AdministrativeAreal2D.</typeparam>
        /// <param name="administrativeAreal2Ds">A collection of administrative areal entities to be indexed.</param>
        /// <returns>An IndexDataFile containing the indexed data, or null if the input collection is null.</returns>
        public static IndexDataFile? IndexDataFile<TAdministrativeAreal2D>(this IEnumerable<TAdministrativeAreal2D>? administrativeAreal2Ds) where TAdministrativeAreal2D : AdministrativeAreal2D
        {
            if (administrativeAreal2Ds == null)
            {
                return null;
            }

            Dictionary<string, TAdministrativeAreal2D> dictionary = [];
            foreach (TAdministrativeAreal2D administrativeAreal2D in administrativeAreal2Ds)
            {
                if (administrativeAreal2D?.Reference == null)
                {
                    continue;
                }

                dictionary[administrativeAreal2D.Reference] = administrativeAreal2D;
            }

            List<TAdministrativeAreal2D> administrativeAreal2Ds_Temp = [.. dictionary.Values];

            IndexDataFile result = [];
            for (int i = 0; i < administrativeAreal2Ds_Temp.Count; i++)
            {
                AdministrativeAreal2D administrativeAreal2D = administrativeAreal2Ds_Temp[i];

                result.Add(new IndexData(i, administrativeAreal2D.Reference, administrativeAreal2D.Name));
            }

            return result;
        }
    }
}