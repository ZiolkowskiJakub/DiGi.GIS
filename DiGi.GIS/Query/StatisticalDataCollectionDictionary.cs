using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static Dictionary<string, StatisticalDataCollection> StatisticalDataCollectionDictionary(StatisticalDataCollectionFile statisticalDataCollectionFile, IEnumerable<string> references)
        {
            if (statisticalDataCollectionFile == null || references == null)
            {
                return null;
            }

            HashSet<UniqueReference> uniqueReferences = new HashSet<UniqueReference>();
            foreach (string reference in references)
            {
                UniqueReference uniqueReference = StatisticalDataCollectionFile.GetUniqueReference(reference);
                if (uniqueReference == null)
                {
                    continue;
                }

                uniqueReferences.Add(uniqueReference);
            }

            Dictionary<string, StatisticalDataCollection> result = new Dictionary<string, StatisticalDataCollection>();

            if (uniqueReferences.Count == 0)
            {
                return result;
            }

            List<StatisticalDataCollection> statisticalDataCollectionList = statisticalDataCollectionFile.GetValues(uniqueReferences)?.ToList();
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

                UniqueReference uniqueReference = uniqueReferences.ElementAt(i);

                result[uniqueReference.UniqueId] = statisticalDataCollectionList[i];
                uniqueReferences.Remove(uniqueReference);

                if (uniqueReferences.Count == 0)
                {
                    return result;
                }
            }

            return result;
        }

        public static Dictionary<string, StatisticalDataCollection> StatisticalDataCollectionDictionary(string directory, IEnumerable<string> references)
        {
            if (string.IsNullOrWhiteSpace(directory) || !System.IO.Directory.Exists(directory) || references == null)
            {
                return null;
            }

            HashSet<UniqueReference> uniqueReferences = new HashSet<UniqueReference>();
            foreach (string reference in references)
            {
                UniqueReference uniqueReference = StatisticalDataCollectionFile.GetUniqueReference(reference);
                if (uniqueReference == null)
                {
                    continue;
                }

                uniqueReferences.Add(uniqueReference);
            }

            Dictionary<string, StatisticalDataCollection> result = new Dictionary<string, StatisticalDataCollection>();

            if (uniqueReferences.Count == 0)
            {
                return result;
            }

            string[] paths = System.IO.Directory.GetFiles(directory, string.Format("*.{0}", Constans.FileExtension.StatisticalDataCollectionFile));
            if (paths == null || paths.Length == 0)
            {
                return result;
            }

            foreach (string path in paths)
            {
                using (StatisticalDataCollectionFile statisticalDataCollectionFile = new StatisticalDataCollectionFile(path))
                {
                    Dictionary<string, StatisticalDataCollection> statisticalDataCollectionDictionary = StatisticalDataCollectionDictionary(statisticalDataCollectionFile, references);
                    if(statisticalDataCollectionDictionary != null)
                    {
                        foreach(KeyValuePair<string, StatisticalDataCollection> keyValuePair in statisticalDataCollectionDictionary)
                        {
                            result[keyValuePair.Key] = keyValuePair.Value;
                        }
                    }
                }
            }

            return result;
        }

        public static Dictionary<GuidReference, StatisticalDataCollection> StatisticalDataCollectionDictionary(string directory, IEnumerable<Building2D> building2Ds)
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

            Dictionary<string, StatisticalDataCollection> statisticalDataCollectionDictionary = StatisticalDataCollectionDictionary(directory, dictionary.Keys);
            if(statisticalDataCollectionDictionary == null)
            {
                return null;
            }

            Dictionary<GuidReference, StatisticalDataCollection> result = new Dictionary<GuidReference, StatisticalDataCollection>();
            foreach(KeyValuePair<string, GuidReference> keyValuePair in dictionary)
            {
                string reference = keyValuePair.Key;

                if(statisticalDataCollectionDictionary.TryGetValue(reference, out StatisticalDataCollection statisticalDataCollection))
                {
                    result[dictionary[reference]] = statisticalDataCollection;
                }
            }

            return result;
        }
    }
}

