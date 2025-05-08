using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static OrtoDatas OrtoDatas(this Building2D building2D, string directory)
        {
            if (string.IsNullOrWhiteSpace(directory) || !System.IO.Directory.Exists(directory) || building2D == null)
            {
                return null;
            }

            Dictionary<GuidReference, OrtoDatas> dictionary = OrtoDatasDictionary(directory, new Building2D[] { building2D });
            if (dictionary == null || dictionary.Count == 0)
            {
                return null;
            }

            if (!dictionary.TryGetValue(new GuidReference(building2D), out OrtoDatas result))
            {
                return null;
            }

            return result;
        }

        public static OrtoDatas OrtoDatas(this OrtoRange ortoRange, string directory)
        {
            if (string.IsNullOrWhiteSpace(directory) || !System.IO.Directory.Exists(directory) || ortoRange == null)
            {
                return null;
            }

            Dictionary<GuidReference, OrtoDatas> dictionary = OrtoDatasDictionary(directory, new OrtoRange[] { ortoRange });
            if (dictionary == null || dictionary.Count == 0)
            {
                return null;
            }

            if (!dictionary.TryGetValue(new GuidReference(ortoRange), out OrtoDatas result))
            {
                return null;
            }

            return result;
        }
    }
}

