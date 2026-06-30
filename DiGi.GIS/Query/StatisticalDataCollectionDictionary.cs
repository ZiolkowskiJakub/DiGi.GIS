using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.GIS
{
    public static partial class Query
    {
        /// <summary>
        /// Creates a dictionary of statistical data collections based on the provided file and a collection of references.
        /// </summary>
        /// <param name="statisticalDataCollectionFile">The statistical data collection file to retrieve data from.</param>
        /// <param name="references">A collection of string references used to look up the statistical data.</param>
        /// <returns>A dictionary mapping reference strings to their corresponding <see cref="StatisticalDataCollection"/>, or null if inputs are invalid.</returns>
        public static Dictionary<string, StatisticalDataCollection>? StatisticalDataCollectionDictionary(StatisticalDataCollectionFile? statisticalDataCollectionFile, IEnumerable<string>? references)
        {
            if (statisticalDataCollectionFile == null || references == null)
            {
                return null;
            }

            HashSet<UniqueReference> uniqueReferences_HashSet = [];
            List<UniqueReference> uniqueReferences = [];
            foreach (string reference in references)
            {
                UniqueReference? uniqueReference = StatisticalDataCollectionFile.GetUniqueReference(reference);
                if (uniqueReference is null)
                {
                    continue;
                }

                if (uniqueReferences_HashSet.Add(uniqueReference))
                {
                    uniqueReferences.Add(uniqueReference);
                }
            }

            Dictionary<string, StatisticalDataCollection> result = [];

            if (uniqueReferences.Count == 0)
            {
                return result;
            }

            List<StatisticalDataCollection?>? statisticalDataCollectionList = statisticalDataCollectionFile.GetValues(uniqueReferences)?.ToList();
            if (statisticalDataCollectionList == null || statisticalDataCollectionList.Count == 0)
            {
                return result;
            }

            for (int i = statisticalDataCollectionList.Count - 1; i >= 0; i--)
            {
                if (statisticalDataCollectionList[i] == null)
                {
                    continue;
                }

                UniqueReference uniqueReference = uniqueReferences[i];

                if (uniqueReference.UniqueId is string uniqueId)
                {
                    result[uniqueId] = statisticalDataCollectionList[i]!;
                }
            }

            return result;
        }

        /// <summary>
        /// Creates a dictionary of statistical data collections by searching for relevant files within a specified directory using the provided references.
        /// </summary>
        /// <param name="directory">The path to the directory containing statistical data collection files.</param>
        /// <param name="references">A collection of string references used to look up the statistical data.</param>
        /// <returns>A dictionary mapping reference strings to their corresponding <see cref="StatisticalDataCollection"/>, or null if the directory is invalid or references are null.</returns>
        public static Dictionary<string, StatisticalDataCollection>? StatisticalDataCollectionDictionary(string? directory, IEnumerable<string>? references)
        {
            if (string.IsNullOrWhiteSpace(directory) || !System.IO.Directory.Exists(directory) || references == null)
            {
                return null;
            }

            HashSet<UniqueReference> uniqueReferences = [];
            foreach (string reference in references)
            {
                UniqueReference? uniqueReference = StatisticalDataCollectionFile.GetUniqueReference(reference);
                if (uniqueReference is null)
                {
                    continue;
                }

                uniqueReferences.Add(uniqueReference);
            }

            Dictionary<string, StatisticalDataCollection> result = [];

            if (uniqueReferences.Count == 0)
            {
                return result;
            }

            string[] paths = System.IO.Directory.GetFiles(directory, string.Format("*.{0}", Constants.FileExtension.StatisticalDataCollectionFile));
            if (paths == null || paths.Length == 0)
            {
                return result;
            }

            foreach (string path in paths)
            {
                using StatisticalDataCollectionFile statisticalDataCollectionFile = new(path);

                Dictionary<string, StatisticalDataCollection>? statisticalDataCollectionDictionary = StatisticalDataCollectionDictionary(statisticalDataCollectionFile, references);
                if (statisticalDataCollectionDictionary != null)
                {
                    foreach (KeyValuePair<string, StatisticalDataCollection> keyValuePair in statisticalDataCollectionDictionary)
                    {
                        result[keyValuePair.Key] = keyValuePair.Value;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Creates a dictionary of statistical data collections mapped to <see cref="GuidReference"/> objects derived from the provided building entities.
        /// </summary>
        /// <param name="directory">The path to the directory containing statistical data collection files.</param>
        /// <param name="building2Ds">A collection of <see cref="Building2D"/> objects used to generate references for lookup.</param>
        /// <returns>A dictionary mapping <see cref="GuidReference"/> to their corresponding <see cref="StatisticalDataCollection"/>, or null if the directory is invalid or building list is null.</returns>
        public static Dictionary<GuidReference, StatisticalDataCollection>? StatisticalDataCollectionDictionary(string? directory, IEnumerable<Building2D>? building2Ds)
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

            Dictionary<string, StatisticalDataCollection>? statisticalDataCollectionDictionary = StatisticalDataCollectionDictionary(directory, dictionary.Keys);
            if (statisticalDataCollectionDictionary == null)
            {
                return null;
            }

            Dictionary<GuidReference, StatisticalDataCollection> result = [];
            foreach (KeyValuePair<string, GuidReference> keyValuePair in dictionary)
            {
                string reference = keyValuePair.Key;

                if (statisticalDataCollectionDictionary.TryGetValue(reference, out StatisticalDataCollection statisticalDataCollection))
                {
                    result[dictionary[reference]] = statisticalDataCollection;
                }
            }

            return result;
        }
    }
}