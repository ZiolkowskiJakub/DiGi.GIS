using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static Dictionary<string, Building2DYearBuiltPredictions> Building2DYearBuiltPredictionsDictionary(GISModelFile gISModelFile, IEnumerable<string> references)
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

            path = System.IO.Path.Combine(directory, string.Format("{0}.{1}", System.IO.Path.GetFileNameWithoutExtension(path), Constans.FileExtension.Building2DYearBuiltPredictionsFile));

            if (!System.IO.File.Exists(path))
            {
                return null;
            }

            using (Building2DYearBuiltPredictionsFile building2DYearBuiltPredictionsFile = new Building2DYearBuiltPredictionsFile(path))
            {
                return Building2DYearBuiltPredictionsDictionary(building2DYearBuiltPredictionsFile, references);
            }
        }

        public static Dictionary<string, Building2DYearBuiltPredictions> Building2DYearBuiltPredictionsDictionary(Building2DYearBuiltPredictionsFile building2DYearBuiltPredictionsFile, IEnumerable<string> references)
        {
            if (building2DYearBuiltPredictionsFile == null || references == null)
            {
                return null;
            }

            HashSet<UniqueReference> uniqueReferences = new HashSet<UniqueReference>();
            foreach (string reference in references)
            {
                UniqueReference uniqueReference = Building2DYearBuiltPredictionsFile.GetUniqueReference(reference);
                if (uniqueReference == null)
                {
                    continue;
                }

                uniqueReferences.Add(uniqueReference);
            }

            Dictionary<string, Building2DYearBuiltPredictions> result = new Dictionary<string, Building2DYearBuiltPredictions>();

            if (uniqueReferences.Count == 0)
            {
                return result;
            }

            List<Building2DYearBuiltPredictions> building2DYearBuiltPredictions = building2DYearBuiltPredictionsFile.GetValues(uniqueReferences)?.ToList();
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

                UniqueReference uniqueReference = uniqueReferences.ElementAt(i);

                result[uniqueReference.UniqueId] = building2DYearBuiltPredictions[i];
                uniqueReferences.Remove(uniqueReference);

                if (uniqueReferences.Count == 0)
                {
                    return result;
                }
            }

            return result;
        }

        public static Dictionary<string, Building2DYearBuiltPredictions> Building2DYearBuiltPredictionsDictionary(string directory, IEnumerable<string> references)
        {
            if (string.IsNullOrWhiteSpace(directory) || !System.IO.Directory.Exists(directory) || references == null)
            {
                return null;
            }

            HashSet<UniqueReference> uniqueReferences = new HashSet<UniqueReference>();
            foreach (string reference in references)
            {
                UniqueReference uniqueReference = Building2DYearBuiltPredictionsFile.GetUniqueReference(reference);
                if (uniqueReference == null)
                {
                    continue;
                }

                uniqueReferences.Add(uniqueReference);
            }

            Dictionary<string, Building2DYearBuiltPredictions> result = new Dictionary<string, Building2DYearBuiltPredictions>();

            if (uniqueReferences.Count == 0)
            {
                return result;
            }

            string[] paths = System.IO.Directory.GetFiles(directory, string.Format("*.{0}", Constans.FileExtension.Building2DYearBuiltPredictionsFile));
            if (paths == null || paths.Length == 0)
            {
                return result;
            }

            foreach (string path in paths)
            {
                using (Building2DYearBuiltPredictionsFile building2DYearBuiltPredictionsFile = new Building2DYearBuiltPredictionsFile(path))
                {
                    Dictionary<string, Building2DYearBuiltPredictions> building2DYearBuiltPredictionsDictionary = Building2DYearBuiltPredictionsDictionary(building2DYearBuiltPredictionsFile, references);
                    if(building2DYearBuiltPredictionsDictionary != null)
                    {
                        foreach(KeyValuePair<string, Building2DYearBuiltPredictions> keyValuePair in building2DYearBuiltPredictionsDictionary)
                        {
                            result[keyValuePair.Key] = keyValuePair.Value;
                        }
                    }
                }
            }

            return result;
        }

        public static Dictionary<GuidReference, Building2DYearBuiltPredictions> Building2DYearBuiltPredictionsDictionary(string directory, IEnumerable<Building2D> building2Ds)
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

            Dictionary<string, Building2DYearBuiltPredictions> building2DYearBuiltPredictionsDictionary = Building2DYearBuiltPredictionsDictionary(directory, dictionary.Keys);
            if(building2DYearBuiltPredictionsDictionary == null)
            {
                return null;
            }

            Dictionary<GuidReference, Building2DYearBuiltPredictions> result = new Dictionary<GuidReference, Building2DYearBuiltPredictions>();
            foreach(KeyValuePair<string, GuidReference> keyValuePair in dictionary)
            {
                string reference = keyValuePair.Key;

                if(building2DYearBuiltPredictionsDictionary.TryGetValue(reference, out Building2DYearBuiltPredictions building2DYearBuiltPredictions))
                {
                    result[dictionary[reference]] = building2DYearBuiltPredictions;
                }
            }

            return result;
        }
    }
}

