using DiGi.GIS.Classes;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the user-defined year built for the specified building using the provided GIS model file.
        /// </summary>
        /// <param name="gISModelFile">The GIS model file containing the data.</param>
        /// <param name="builidng2D">The 2D building object to retrieve the year built for.</param>
        /// <returns>The user-defined year built if found; otherwise, null.</returns>
        public static short? UserYearBuilt(this GISModelFile? gISModelFile, Building2D? builidng2D)
        {
            if (gISModelFile == null || builidng2D == null)
            {
                return null;
            }
            string? reference = builidng2D.Reference;
            if (string.IsNullOrWhiteSpace(reference))
            {
                return null;
            }

            Dictionary<string, YearBuiltData>? dictionary = YearBuiltDataDictionary<YearBuiltData>(gISModelFile, [reference!]);
            if (dictionary == null || !dictionary.TryGetValue(reference!, out YearBuiltData yearBuiltData) || yearBuiltData == null)
            {
                return null;
            }

            return yearBuiltData.GetUserYearBuilt()?.Year;
        }

        /// <summary>
        /// Retrieves the user-defined year built for the specified building using the provided directory path.
        /// </summary>
        /// <param name="directory">The directory path where the data is located.</param>
        /// <param name="builidng2D">The 2D building object to retrieve the year built for.</param>
        /// <returns>The user-defined year built if found; otherwise, null.</returns>
        public static short? UserYearBuilt(string? directory, Building2D? builidng2D)
        {
            if (directory == null || builidng2D == null || string.IsNullOrWhiteSpace(directory))
            {
                return null;
            }
            string? reference = builidng2D.Reference;
            if (string.IsNullOrWhiteSpace(reference))
            {
                return null;
            }

            Dictionary<string, YearBuiltData>? dictionary = YearBuiltDataDictionary<YearBuiltData>(directory, [reference!]);
            if (dictionary == null || !dictionary.TryGetValue(reference!, out YearBuiltData yearBuiltData) || yearBuiltData == null)
            {
                return null;
            }

            return yearBuiltData.GetUserYearBuilt()?.Year;
        }
    }
}