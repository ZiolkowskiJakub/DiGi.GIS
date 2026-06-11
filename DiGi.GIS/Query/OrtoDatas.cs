using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the orthodata associated with the specified building from the provided directory.
        /// </summary>
        /// <param name="building2D">The building for which to retrieve orthodata.</param>
        /// <param name="directory">The path to the directory containing the orthodata files.</param>
        /// <returns>The OrtoDatas object if found; otherwise, null.</returns>
        public static OrtoDatas? OrtoDatas(this Building2D? building2D, string? directory)
        {
            if (string.IsNullOrWhiteSpace(directory) || !System.IO.Directory.Exists(directory) || building2D == null)
            {
                return null;
            }

            Dictionary<GuidReference, OrtoDatas>? dictionary = OrtoDatasDictionary(directory, [building2D]);
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

        /// <summary>
        /// Retrieves the orthodata associated with the specified ortho range from the provided directory.
        /// </summary>
        /// <param name="ortoRange">The ortho range for which to retrieve orthodata.</param>
        /// <param name="directory">The path to the directory containing the orthodata files.</param>
        /// <returns>The OrtoDatas object if found; otherwise, null.</returns>
        public static OrtoDatas? OrtoDatas(this OrtoRange? ortoRange, string? directory)
        {
            if (string.IsNullOrWhiteSpace(directory) || !System.IO.Directory.Exists(directory) || ortoRange == null)
            {
                return null;
            }

            Dictionary<GuidReference, OrtoDatas>? dictionary = OrtoDatasDictionary(directory, [ortoRange]);
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