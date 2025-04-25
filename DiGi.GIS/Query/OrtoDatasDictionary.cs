using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static Dictionary<string, OrtoDatas> OrtoDatasDictionary(string directory, IEnumerable<string> references)
        {
            if(string.IsNullOrWhiteSpace(directory) || !System.IO.Directory.Exists(directory) || references == null)
            {
                return null;
            }

            HashSet<UniqueReference> uniqueReferences = new HashSet<UniqueReference>();
            foreach(string reference in references)
            {
                UniqueReference uniqueReference = OrtoDatasFile.GetUniqueReference(reference);
                if(uniqueReference == null)
                {
                    continue;
                }

                uniqueReferences.Add(uniqueReference);
            }

            Dictionary<string, OrtoDatas> result = new Dictionary<string, OrtoDatas>();
            
            if (uniqueReferences.Count == 0)
            {
                return result;
            }

            string[] paths = System.IO.Directory.GetFiles(directory, string.Format("*.{0}", Constans.FileExtension.OrtoDatasFile));
            if(paths == null || paths.Length == 0)
            {
                return result;
            }

            foreach(string path in paths)
            {
                using (OrtoDatasFile ortoDatasFile = new OrtoDatasFile(path))
                {
                    List<OrtoDatas> ortoDatasList = ortoDatasFile.GetValues(uniqueReferences)?.ToList();
                    if(ortoDatasList == null || ortoDatasList.Count == 0)
                    {
                        continue;
                    }

                    for (int i = ortoDatasList.Count - 1; i >= 0; i--)
                    {
                        if (ortoDatasList[i] == null)
                        {
                            continue;
                        }

                        UniqueReference uniqueReference = uniqueReferences.ElementAt(i);

                        result[uniqueReference.UniqueId] = ortoDatasList[i];
                        uniqueReferences.Remove(uniqueReference);

                        if(uniqueReferences.Count == 0)
                        {
                            return result;
                        }
                    }

                }
            }

            return result;
        }

        public static Dictionary<GuidReference, OrtoDatas> OrtoDatasDictionary(string directory, IEnumerable<Building2D> building2Ds)
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

            Dictionary<string, OrtoDatas> ortoDatasDictionary = OrtoDatasDictionary(directory, dictionary.Keys);
            if(ortoDatasDictionary == null)
            {
                return null;
            }

            Dictionary<GuidReference, OrtoDatas> result = new Dictionary<GuidReference, OrtoDatas>();
            if(ortoDatasDictionary != null && ortoDatasDictionary.Count != 0)
            {
                foreach (KeyValuePair<string, GuidReference> keyValuePair in dictionary)
                {
                    string reference = keyValuePair.Key;

                    if (reference == null || !ortoDatasDictionary.TryGetValue(reference, out OrtoDatas ortoDatas))
                    {
                        continue;
                    }

                    result[keyValuePair.Value] = ortoDatas;
                }
            }

            return result;
        }

        public static Dictionary<GuidReference, OrtoDatas> OrtoDatasDictionary(string directory, IEnumerable<OrtoRange> ortoRanges)
        {
            if (string.IsNullOrWhiteSpace(directory) || !System.IO.Directory.Exists(directory) || ortoRanges == null)
            {
                return null;
            }

            Dictionary<string, GuidReference> dictionary = new Dictionary<string, GuidReference>();
            foreach (OrtoRange ortoRange in ortoRanges)
            {
                string reference = ortoRange?.UniqueId;
                if (reference == null)
                {
                    continue;
                }

                dictionary[reference] = new GuidReference(ortoRange);
            }

            Dictionary<string, OrtoDatas> ortoDatasDictionary = OrtoDatasDictionary(directory, dictionary.Keys);
            if (ortoDatasDictionary == null)
            {
                return null;
            }

            Dictionary<GuidReference, OrtoDatas> result = new Dictionary<GuidReference, OrtoDatas>();
            if (ortoDatasDictionary != null && ortoDatasDictionary.Count != 0)
            {
                foreach (KeyValuePair<string, GuidReference> keyValuePair in dictionary)
                {
                    string reference = keyValuePair.Key;

                    if (reference == null || !ortoDatasDictionary.TryGetValue(reference, out OrtoDatas ortoDatas))
                    {
                        continue;
                    }

                    result[keyValuePair.Value] = ortoDatas;
                }
            }

            return result;
        }
    }
}

