using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using DiGi.GIS.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.GIS
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves a dictionary of year built data associated with the provided references, based on the GIS model file's location.
        /// </summary>
        /// <typeparam name="TYearBuiltData">The type of year built data, which must implement <see cref="IYearBuiltData"/>.</typeparam>
        /// <param name="gISModelFile">The GIS model file used to determine the path for the year built data file.</param>
        /// <param name="references">A collection of reference strings to look up.</param>
        /// <returns>A dictionary mapping references to their corresponding year built data, or null if inputs are invalid or the associated data file is missing.</returns>
        public static Dictionary<string, TYearBuiltData>? YearBuiltDataDictionary<TYearBuiltData>(GISModelFile? gISModelFile, IEnumerable<string>? references) where TYearBuiltData : IYearBuiltData
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

            path = System.IO.Path.Combine(directory, string.Format("{0}.{1}", System.IO.Path.GetFileNameWithoutExtension(path), Constants.FileExtension.YearBuiltDataFile));

            if (!System.IO.File.Exists(path))
            {
                return null;
            }

            using YearBuiltDataFile yearBuiltDataFile = new(path);

            return YearBuiltDataDictionary<TYearBuiltData>(yearBuiltDataFile, references);
        }

        /// <summary>
        /// Retrieves a dictionary of year built data from a specific year built data file for the provided references.
        /// </summary>
        /// <typeparam name="TYearBuiltData">The type of year built data, which must implement <see cref="IYearBuiltData"/>.</typeparam>
        /// <param name="yearBuiltDataFile">The year built data file to query.</param>
        /// <param name="references">A collection of reference strings to look up.</param>
        /// <returns>A dictionary mapping references to their corresponding year built data, or null if inputs are invalid.</returns>
        public static Dictionary<string, TYearBuiltData>? YearBuiltDataDictionary<TYearBuiltData>(YearBuiltDataFile? yearBuiltDataFile, IEnumerable<string>? references) where TYearBuiltData : IYearBuiltData
        {
            if (yearBuiltDataFile == null || references == null)
            {
                return null;
            }

            HashSet<UniqueReference> uniqueReferences_HashSet = [];
            List<UniqueReference> uniqueReferences = [];
            foreach (string reference in references)
            {
                UniqueReference? uniqueReference = YearBuiltDataFile.GetUniqueReference<TYearBuiltData>(reference);
                if (uniqueReference is null)
                {
                    continue;
                }

                if (uniqueReferences_HashSet.Add(uniqueReference))
                {
                    uniqueReferences.Add(uniqueReference);
                }
            }

            Dictionary<string, TYearBuiltData> result = [];

            if (uniqueReferences.Count == 0)
            {
                return result;
            }

            List<IYearBuiltData?>? yearBuiltDatas = yearBuiltDataFile.GetValues(uniqueReferences)?.ToList();
            if (yearBuiltDatas == null || yearBuiltDatas.Count == 0)
            {
                return result;
            }

            for (int i = yearBuiltDatas.Count - 1; i >= 0; i--)
            {
                if (yearBuiltDatas[i] is not TYearBuiltData yearBuiltData)
                {
                    continue;
                }

                UniqueReference uniqueReference = uniqueReferences[i];

                if (uniqueReference.UniqueId is string uniqueId)
                {
                    result[uniqueId] = yearBuiltData;
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves a dictionary of year built data by searching all compatible files within the specified directory for the provided references.
        /// </summary>
        /// <typeparam name="TYearBuiltData">The type of year built data, which must implement <see cref="IYearBuiltData"/>.</typeparam>
        /// <param name="directory">Directory where YearBuiltDataFile (*.ybdf) is located</param>
        /// <param name="references">Building2D references</param>
        /// <returns>A dictionary mapping references to their corresponding year built data, or null if the directory is invalid or references are null.</returns>
        public static Dictionary<string, TYearBuiltData>? YearBuiltDataDictionary<TYearBuiltData>(string? directory, IEnumerable<string>? references) where TYearBuiltData : IYearBuiltData
        {
            if (string.IsNullOrWhiteSpace(directory) || !System.IO.Directory.Exists(directory) || references == null)
            {
                return null;
            }

            HashSet<UniqueReference> uniqueReferences = [];
            foreach (string reference in references)
            {
                UniqueReference? uniqueReference = YearBuiltDataFile.GetUniqueReference<TYearBuiltData>(reference);
                if (uniqueReference is null)
                {
                    continue;
                }

                uniqueReferences.Add(uniqueReference);
            }

            Dictionary<string, TYearBuiltData> result = [];

            if (uniqueReferences.Count == 0)
            {
                return result;
            }

            string[] paths = System.IO.Directory.GetFiles(directory, string.Format("*.{0}", Constants.FileExtension.YearBuiltDataFile));
            if (paths == null || paths.Length == 0)
            {
                return result;
            }

            foreach (string path in paths)
            {
                using YearBuiltDataFile yearBuiltDataFile = new(path);

                Dictionary<string, TYearBuiltData>? yearBuiltDataDictionary = YearBuiltDataDictionary<TYearBuiltData>(yearBuiltDataFile, references);
                if (yearBuiltDataDictionary != null)
                {
                    foreach (KeyValuePair<string, TYearBuiltData> keyValuePair in yearBuiltDataDictionary)
                    {
                        result[keyValuePair.Key] = keyValuePair.Value;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves a dictionary of year built data keyed by GuidReference for the provided collection of Building2D objects within the specified directory.
        /// </summary>
        /// <typeparam name="TYearBuiltData">The type of year built data, which must implement <see cref="IYearBuiltData"/>.</typeparam>
        /// <param name="directory">The directory where YearBuiltDataFile (*.ybdf) files are located.</param>
        /// <param name="building2Ds">A collection of Building2D objects to retrieve data for.</param>
        /// <returns>A dictionary mapping GuidReferences to their corresponding year built data, or null if inputs are invalid.</returns>
        public static Dictionary<GuidReference, TYearBuiltData>? YearBuiltDataDictionary<TYearBuiltData>(string? directory, IEnumerable<Building2D>? building2Ds) where TYearBuiltData : IYearBuiltData
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

            Dictionary<string, TYearBuiltData>? yearBuiltDataDictionary = YearBuiltDataDictionary<TYearBuiltData>(directory, dictionary.Keys);
            if (yearBuiltDataDictionary == null)
            {
                return null;
            }

            Dictionary<GuidReference, TYearBuiltData> result = [];
            foreach (KeyValuePair<string, GuidReference> keyValuePair in dictionary)
            {
                string reference = keyValuePair.Key;

                if (yearBuiltDataDictionary.TryGetValue(reference, out TYearBuiltData yearBuiltData))
                {
                    result[dictionary[reference]] = yearBuiltData;
                }
            }

            return result;
        }
    }
}