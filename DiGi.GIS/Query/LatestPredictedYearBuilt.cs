using DiGi.GIS.Classes;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the latest predicted year built for a specific building from the GIS model file.
        /// </summary>
        /// <param name="gISModelFile">The GIS model file containing the data.</param>
        /// <param name="builidng2D">The building object to query.</param>
        /// <returns>The latest predicted year built as a short, or null if not found or inputs are invalid.</returns>
        public static short? LatestPredictedYearBuilt(this GISModelFile? gISModelFile, Building2D? builidng2D)
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

            return yearBuiltData.GetLatestPredictedYearBuilt()?.Year;
        }

        /// <summary>
        /// Retrieves the latest predicted year built for a specific building from a specified directory.
        /// </summary>
        /// <param name="directory">The path to the directory containing the data.</param>
        /// <param name="builidng2D">The building object to query.</param>
        /// <returns>The latest predicted year built as a short, or null if not found or inputs are invalid.</returns>
        public static short? LatestPredictedYearBuilt(string? directory, Building2D? builidng2D)
        {
            if (directory == null || builidng2D == null)
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

            return yearBuiltData.GetLatestPredictedYearBuilt()?.Year;
        }
    }
}