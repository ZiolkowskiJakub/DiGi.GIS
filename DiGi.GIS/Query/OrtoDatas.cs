using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static OrtoDatas OrtoDatas(this GISModelFile gISModelFile, Building2D building2D)
        {
            if(gISModelFile == null || building2D == null)
            {
                return null;
            }

            Dictionary<GuidReference, OrtoDatas> dictionary = OrtoDatasDictionary(gISModelFile, new Building2D[] { building2D });
            if(dictionary == null || dictionary.Count == 0)
            {
                return null;
            }

            if(!dictionary.TryGetValue(new GuidReference(building2D), out OrtoDatas result))
            {
                return null;
            }

            return result;
        }
    }
}

