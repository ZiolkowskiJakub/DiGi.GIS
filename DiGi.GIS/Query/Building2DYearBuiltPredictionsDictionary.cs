using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.GIS
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves a dictionary of building 2D year built predictions based on the provided GIS model file and references.
        /// </summary>
        /// <param name="gISModelFile">The GIS model file used to determine the location of the prediction data.</param>
        /// <param name="references">A collection of reference strings to look up.</param>
        /// <returns>A dictionary mapping unique IDs to building 2D year built predictions, or null if inputs are invalid or files are missing.</returns>
        public static Dictionary<string, Building2DYearBuiltPredictions>? Building2DYearBuiltPredictionsDictionary(GISModelFile? gISModelFile, IEnumerable<string>? references)
        {
            if (gISModelFile == null || references == null || references.Count() == 0)
            {
                return null;
            }

            string? path = gISModelFile.Path;
            if (string.IsNullOrWhiteSpace(path))
            {
                return null;
            }

            string directory = System.IO.Path.GetDirectoryName(path);
            if (!System.IO.Directory.Exists(directory))
            {
                return null;
            }

            path = System.IO.Path.Combine(directory, string.Format("{0}.{1}", System.IO.Path.GetFileNameWithoutExtension(path), Constants.FileExtension.Building2DYearBuiltPredictionsFile));

            if (!System.IO.File.Exists(path))
            {
                return null;
            }

            using Building2DYearBuiltPredictionsFile building2DYearBuiltPredictionsFile = new(path);

            return Building2DYearBuiltPredictionsDictionary(building2DYearBuiltPredictionsFile, references);
        }

        /// <summary>
        /// Retrieves a dictionary of building 2D year built predictions from a specific prediction file for the given references.
        /// </summary>
        /// <param name="building2DYearBuiltPredictionsFile">The prediction file instance to read data from.</param>
        /// <param name="references">A collection of reference strings to look up.</param>
        /// <returns>A dictionary mapping unique IDs to building 2D year built predictions, or null if inputs are invalid.</returns>
        public static Dictionary<string, Building2DYearBuiltPredictions>? Building2DYearBuiltPredictionsDictionary(Building2DYearBuiltPredictionsFile? building2DYearBuiltPredictionsFile, IEnumerable<string>? references)
        {
            if (building2DYearBuiltPredictionsFile == null || references == null)
            {
                return null;
            }

            HashSet<UniqueReference> uniqueReferences_HashSet = [];
            List<UniqueReference> uniqueReferences = [];
            foreach (string reference in references)
            {
                UniqueReference? uniqueReference = Building2DYearBuiltPredictionsFile.GetUniqueReference(reference);
                if (uniqueReference is null)
                {
                    continue;
                }

                if (uniqueReferences_HashSet.Add(uniqueReference))
                {
                    uniqueReferences.Add(uniqueReference);
                }
            }

            Dictionary<string, Building2DYearBuiltPredictions> result = [];

            if (uniqueReferences.Count == 0)
            {
                return result;
            }

            List<Building2DYearBuiltPredictions?>? building2DYearBuiltPredictions = building2DYearBuiltPredictionsFile.GetValues(uniqueReferences)?.ToList();
            if (building2DYearBuiltPredictions == null || building2DYearBuiltPredictions.Count == 0)
            {
                return result;
            }

            for (int i = building2DYearBuiltPredictions.Count - 1; i >= 0; i--)
            {
                if (building2DYearBuiltPredictions[i] == null)
                {
                    continue;
                }

                UniqueReference uniqueReference = uniqueReferences[i];

                string? uniqueId = uniqueReference?.UniqueId;
                if (uniqueId is not null)
                {
                    result[uniqueId] = building2DYearBuiltPredictions[i]!;
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves a dictionary of building 2D year built predictions by searching all prediction files within a specified directory for the given references.
        /// </summary>
        /// <param name="directory">The directory path containing the prediction files.</param>
        /// <param name="references">A collection of reference strings to look up.</param>
        /// <returns>A dictionary mapping unique IDs to building 2D year built predictions, or null if inputs are invalid.</returns>
        public static Dictionary<string, Building2DYearBuiltPredictions>? Building2DYearBuiltPredictionsDictionary(string? directory, IEnumerable<string>? references)
        {
            if (string.IsNullOrWhiteSpace(directory) || !System.IO.Directory.Exists(directory) || references == null)
            {
                return null;
            }

            HashSet<UniqueReference> uniqueReferences = [];
            foreach (string reference in references)
            {
                UniqueReference? uniqueReference = Building2DYearBuiltPredictionsFile.GetUniqueReference(reference);
                if (uniqueReference is null)
                {
                    continue;
                }

                uniqueReferences.Add(uniqueReference);
            }

            Dictionary<string, Building2DYearBuiltPredictions> result = [];

            if (uniqueReferences.Count == 0)
            {
                return result;
            }

            string[] paths = System.IO.Directory.GetFiles(directory, string.Format("*.{0}", Constants.FileExtension.Building2DYearBuiltPredictionsFile));
            if (paths == null || paths.Length == 0)
            {
                return result;
            }

            foreach (string path in paths)
            {
                using Building2DYearBuiltPredictionsFile building2DYearBuiltPredictionsFile = new(path);

                Dictionary<string, Building2DYearBuiltPredictions>? building2DYearBuiltPredictionsDictionary = Building2DYearBuiltPredictionsDictionary(building2DYearBuiltPredictionsFile, references);
                if (building2DYearBuiltPredictionsDictionary != null)
                {
                    foreach (KeyValuePair<string, Building2DYearBuiltPredictions> keyValuePair in building2DYearBuiltPredictionsDictionary)
                    {
                        result[keyValuePair.Key] = keyValuePair.Value;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves a dictionary of building 2D year built predictions for a set of building objects by searching the specified directory.
        /// </summary>
        /// <param name="directory">The directory path containing the prediction files.</param>
        /// <param name="building2Ds">A collection of Building2D objects to retrieve predictions for.</param>
        /// <returns>A dictionary mapping GuidReferences to building 2D year built predictions, or null if inputs are invalid.</returns>
        public static Dictionary<GuidReference, Building2DYearBuiltPredictions>? Building2DYearBuiltPredictionsDictionary(string? directory, IEnumerable<Building2D>? building2Ds)
        {
            if (string.IsNullOrWhiteSpace(directory) || !System.IO.Directory.Exists(directory) || building2Ds == null)
            {
                return null;
            }

            Dictionary<string, GuidReference> dictionary = [];
            foreach (Building2D building2D in building2Ds)
            {
                string? reference = building2D?.Reference;
                if (reference == null)
                {
                    continue;
                }

                dictionary[reference] = new GuidReference(building2D);
            }

            Dictionary<string, Building2DYearBuiltPredictions>? building2DYearBuiltPredictionsDictionary = Building2DYearBuiltPredictionsDictionary(directory, dictionary.Keys);
            if (building2DYearBuiltPredictionsDictionary == null)
            {
                return null;
            }

            Dictionary<GuidReference, Building2DYearBuiltPredictions> result = [];
            foreach (KeyValuePair<string, GuidReference> keyValuePair in dictionary)
            {
                string reference = keyValuePair.Key;

                if (building2DYearBuiltPredictionsDictionary.TryGetValue(reference, out Building2DYearBuiltPredictions building2DYearBuiltPredictions))
                {
                    result[dictionary[reference]] = building2DYearBuiltPredictions;
                }
            }

            return result;
        }
    }
}