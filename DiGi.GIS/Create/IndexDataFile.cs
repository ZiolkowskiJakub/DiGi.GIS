using DiGi.GIS.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.GIS
{
    public static partial class Create
    {
        public static IndexDataFile IndexDataFile<TAdministrativeAreal2D>(this IEnumerable<TAdministrativeAreal2D> administrativeAreal2Ds) where TAdministrativeAreal2D : AdministrativeAreal2D
        {
            if(administrativeAreal2Ds == null)
            {
                return null;
            }

            Dictionary<string, TAdministrativeAreal2D> dictionary = new Dictionary<string, TAdministrativeAreal2D>();
            for (int i = 0; i < administrativeAreal2Ds.Count(); i++)
            {
                TAdministrativeAreal2D administrativeAreal2D = administrativeAreal2Ds.ElementAt(i);
                if(administrativeAreal2D?.Reference == null)
                {
                    continue;
                }

                dictionary[administrativeAreal2D?.Reference] = administrativeAreal2D;
            }

            List<TAdministrativeAreal2D> administrativeAreal2Ds_Temp = dictionary.Values.ToList();

            IndexDataFile result = new IndexDataFile();
            for(int i=0; i < administrativeAreal2Ds_Temp.Count; i++)
            {
                AdministrativeAreal2D administrativeAreal2D = administrativeAreal2Ds_Temp[i];

                result.Add(new IndexData(i, administrativeAreal2D.Reference, administrativeAreal2D.Name));
            }

            return result;
        }
    }
}
