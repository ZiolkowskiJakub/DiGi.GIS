using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using DiGi.GIS.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static Dictionary<string, TYearBuiltData> YearBuiltDataDictionary<TYearBuiltData>(GISModelFile gISModelFile, IEnumerable<string> references) where TYearBuiltData : IYearBuiltData
        {
            if (gISModelFile == null || references == null || references.Count() == 0)
            {
                return null;
            }

            string path = gISModelFile.Path;
            if (string.IsNullOrWhiteSpace(path))
            {
                return null;
            }

            string directory = System.IO.Path.GetDirectoryName(path);
            if (!System.IO.Directory.Exists(directory))
            {
                return null;
            }

            path = System.IO.Path.Combine(directory, string.Format("{0}.{1}", System.IO.Path.GetFileNameWithoutExtension(path), Constans.FileExtension.YearBuiltDataFile));

            if (!System.IO.File.Exists(path))
            {
                return null;
            }

            using (YearBuiltDataFile yearBuiltDataFile = new YearBuiltDataFile(path))
            {
                return YearBuiltDataDictionary<TYearBuiltData>(yearBuiltDataFile, references);
            }
        }

        public static Dictionary<string, TYearBuiltData> YearBuiltDataDictionary<TYearBuiltData>(YearBuiltDataFile yearBuiltDataFile, IEnumerable<string> references) where TYearBuiltData : IYearBuiltData
        {
            if (yearBuiltDataFile == null || references == null)
            {
                return null;
            }

            HashSet<UniqueReference> uniqueReferences = new HashSet<UniqueReference>();
            foreach (string reference in references)
            {
                UniqueReference uniqueReference = YearBuiltDataFile.GetUniqueReference<TYearBuiltData>(reference);
                if (uniqueReference == null)
                {
                    continue;
                }

                uniqueReferences.Add(uniqueReference);
            }

            Dictionary<string, TYearBuiltData> result = new Dictionary<string, TYearBuiltData>();

            if (uniqueReferences.Count == 0)
            {
                return result;
            }

            List<IYearBuiltData> yearBuiltDatas = yearBuiltDataFile.GetValues(uniqueReferences)?.ToList();
            if (yearBuiltDatas == null || yearBuiltDatas.Count == 0)
            {
                return result;
            }

            for (int i = yearBuiltDatas.Count - 1; i >= 0; i--)
            {
                if (!(yearBuiltDatas[i] is TYearBuiltData))
                {
                    continue;
                }

                UniqueReference uniqueReference = uniqueReferences.ElementAt(i);

                result[uniqueReference.UniqueId] = (TYearBuiltData)yearBuiltDatas[i];
                uniqueReferences.Remove(uniqueReference);

                if (uniqueReferences.Count == 0)
                {
                    return result;
                }
            }

            return result;
        }

        public static Dictionary<string, TYearBuiltData> YearBuiltDataDictionary<TYearBuiltData>(string directory, IEnumerable<string> references) where TYearBuiltData : IYearBuiltData
        {
            if (string.IsNullOrWhiteSpace(directory) || !System.IO.Directory.Exists(directory) || references == null)
            {
                return null;
            }

            HashSet<UniqueReference> uniqueReferences = new HashSet<UniqueReference>();
            foreach (string reference in references)
            {
                UniqueReference uniqueReference = YearBuiltDataFile.GetUniqueReference<TYearBuiltData>(reference);
                if (uniqueReference == null)
                {
                    continue;
                }

                uniqueReferences.Add(uniqueReference);
            }

            Dictionary<string, TYearBuiltData> result = new Dictionary<string, TYearBuiltData>();

            if (uniqueReferences.Count == 0)
            {
                return result;
            }

            string[] paths = System.IO.Directory.GetFiles(directory, string.Format("*.{0}", Constans.FileExtension.YearBuiltDataFile));
            if (paths == null || paths.Length == 0)
            {
                return result;
            }

            foreach (string path in paths)
            {
                using (YearBuiltDataFile yearBuiltDataFile = new YearBuiltDataFile(path))
                {
                    Dictionary<string, TYearBuiltData> yearBuiltDataDictionary = YearBuiltDataDictionary<TYearBuiltData>(yearBuiltDataFile, references);
                    if(yearBuiltDataDictionary != null)
                    {
                        foreach(KeyValuePair<string, TYearBuiltData> keyValuePair in yearBuiltDataDictionary)
                        {
                            result[keyValuePair.Key] = keyValuePair.Value;
                        }
                    }
                }
            }

            return result;
        }

        public static Dictionary<GuidReference, TYearBuiltData> YearBuiltDataDictionary<TYearBuiltData>(string directory, IEnumerable<Building2D> building2Ds) where TYearBuiltData : IYearBuiltData
        {
            if (string.IsNullOrWhiteSpace(directory) || !System.IO.Directory.Exists(directory) || building2Ds == null)
            {
                return null;
            }

            Dictionary<string, GuidReference> dictionary = new Dictionary<string, GuidReference>();
            foreach(Building2D building2D in building2Ds)
            {
                string reference = building2D?.Reference;
                if(reference == null)
                {
                    continue;
                }

                dictionary[reference] = new GuidReference(building2D);
            }

            Dictionary<string, TYearBuiltData> yearBuiltDataDictionary = YearBuiltDataDictionary<TYearBuiltData>(directory, dictionary.Keys);
            if(yearBuiltDataDictionary == null)
            {
                return null;
            }

            Dictionary<GuidReference, TYearBuiltData> result = new Dictionary<GuidReference, TYearBuiltData>();
            foreach(KeyValuePair<string, GuidReference> keyValuePair in dictionary)
            {
                string reference = keyValuePair.Key;

                if(yearBuiltDataDictionary.TryGetValue(reference, out TYearBuiltData yearBuiltData))
                {
                    result[dictionary[reference]] = yearBuiltData;
                }
            }

            return result;
        }
    }
}

