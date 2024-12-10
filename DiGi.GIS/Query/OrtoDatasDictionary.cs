using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static Dictionary<GuidReference, OrtoDatas> OrtoDatasDictionary(this GISModelFile gISModelFile, IEnumerable<Building2D> building2Ds)
        {
            if(gISModelFile == null || building2Ds == null)
            {
                return null;
            }

            GISModel gISModel = gISModelFile.Value;
            if (gISModel == null)
            {
                return null;
            }

            Dictionary<GuidReference, OrtoDatas> result = new Dictionary<GuidReference, OrtoDatas>();
            if(building2Ds.Count() == 0)
            {
                return result;
            }

            Dictionary<string, Dictionary<GuidReference, InstanceRelatedExternalReference>> dictionary = new Dictionary<string, Dictionary<GuidReference, InstanceRelatedExternalReference>>();
            foreach(Building2D building2D in building2Ds)
            {
                if(!gISModel.TryGetRelatedObject<OrtoDatasCalculationResult, Building2DExternalReferenceUniqueResultRelation>(building2D, out OrtoDatasCalculationResult ortoDatasCalculationResult))
                {
                    continue;
                }

                InstanceRelatedExternalReference instanceRelatedExternalReference = ortoDatasCalculationResult?.Reference;
                if(string.IsNullOrWhiteSpace(instanceRelatedExternalReference?.Source))
                {
                    continue;
                }

                if(!dictionary.TryGetValue(instanceRelatedExternalReference.Source, out Dictionary<GuidReference, InstanceRelatedExternalReference> dictionary_InstanceRelatedExternalReference) || dictionary_InstanceRelatedExternalReference == null)
                {
                    dictionary_InstanceRelatedExternalReference = new Dictionary<GuidReference, InstanceRelatedExternalReference>();
                    dictionary[instanceRelatedExternalReference.Source] = dictionary_InstanceRelatedExternalReference;
                }

                dictionary_InstanceRelatedExternalReference[new GuidReference(building2D)] = instanceRelatedExternalReference;
            }

            string directory = System.IO.Path.GetDirectoryName(gISModelFile.Path);

            foreach (KeyValuePair<string, Dictionary<GuidReference, InstanceRelatedExternalReference>> keyValuePair in dictionary)
            {
                string path = Core.IO.Query.AbsolutePath(directory, keyValuePair.Key);
                if(string.IsNullOrWhiteSpace(path) || !System.IO.File.Exists(path))
                {
                    continue;
                }

                using (OrtoDatasFile ortoDatasFile = new OrtoDatasFile(path)) 
                {
                    ortoDatasFile.Open();

                    foreach(KeyValuePair<GuidReference, InstanceRelatedExternalReference> keyValuePair_instanceRelatedExternalReference in keyValuePair.Value)
                    {
                        UniqueReference uniqueReference = keyValuePair_instanceRelatedExternalReference.Value.Reference as UniqueReference;
                        if(uniqueReference != null)
                        {
                            result[keyValuePair_instanceRelatedExternalReference.Key] = ortoDatasFile.GetValue<OrtoDatas>(uniqueReference);
                        }
                    }
                }

            }

            return result;

        }
    }
}

