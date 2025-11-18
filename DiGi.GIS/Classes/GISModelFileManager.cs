using DiGi.GIS.Interfaces;
using System.Collections.Generic;
using DiGi.Core.Classes;
using System.Net.Http.Headers;

namespace DiGi.GIS.Classes
{
    public class GISModelFileManager : IGISObject
    {
        private readonly Dictionary<GuidExternalReference, GISModelFile> dictionary = [];

        public GISModelFileManager() 
        { 
        }

        public GISModel? GetGISModel(GuidExternalReference? guidExternalReference)
        {
            if (guidExternalReference is null)
            {
                return null;
            }

            if (!dictionary.TryGetValue(guidExternalReference, out GISModelFile gISModelFile))
            {
                return null;
            }

            return gISModelFile.Value;
        }

        public GuidExternalReference? GetGuidExternalReference(string? path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                return null;
            }

            foreach (KeyValuePair<GuidExternalReference, GISModelFile> keyValuePair in dictionary)
            {
                if (keyValuePair.Value?.Path is not string path_GISModelFile)
                {
                    continue;
                }

                if (path_GISModelFile.Equals(path, System.StringComparison.OrdinalIgnoreCase))
                {
                    return keyValuePair.Key;
                }
            }

            return null;
        }

        public GuidExternalReference? GetGuidExternalReference(GISModel? gISModel)
        {
            if(gISModel is null)
            {
                return null;
            }

            GuidReference guidReference = new (gISModel);

            foreach(GuidExternalReference guidExternalReference in dictionary.Keys)
            {
                if(guidExternalReference.Reference is not GuidReference guidReference_Temp)
                {
                    continue;
                }

                if(!guidReference.Equals(guidReference_Temp))
                {
                    continue;
                }

                return guidExternalReference;
            }

            return null;
        }

        public HashSet<GuidExternalReference>? GetGuidExternalReferences()
        {
            return [.. dictionary.Keys];
        }

        public string? GetPath(GISModel? gISModel)
        {
            if(GetGuidExternalReference(gISModel) is not GuidExternalReference guidExternalReference)
            {
                return null;
            }

            if(!dictionary.TryGetValue(guidExternalReference, out GISModelFile gISModelFile) || gISModelFile is null)
            {
                return null;
            }

            return gISModelFile.Path;
        }
        
        public GuidExternalReference? Open(string? path)
        {
            if(string.IsNullOrWhiteSpace(path))
            {
                return null;
            }

            GISModelFile gISModelFile = new(path);
            if(gISModelFile.Open())
            {
                GuidExternalReference? guidExternalReference = gISModelFile.GuidExternalReference;
                if(guidExternalReference is not null)
                {
                    dictionary[guidExternalReference] = gISModelFile;
                    return guidExternalReference;
                }
            }

            return null;
        }

        public bool Remove(GuidExternalReference? guidExternalReference)
        {
            if (guidExternalReference is null || !dictionary.TryGetValue(guidExternalReference, out _))
            {
                return false;
            }

            return dictionary.Remove(guidExternalReference);
        }

        public bool RemoveAll()
        {
            bool result = false;

            foreach(GuidExternalReference guidExternalReference in dictionary.Keys)
            {
                if(Remove(guidExternalReference))
                {
                    result = true;
                }
            }

            return result;
        }

        public bool Save(GuidExternalReference? guidExternalReference)
        {
            if(guidExternalReference is null || !dictionary.TryGetValue(guidExternalReference, out GISModelFile gISModelFile))
            {
                return false;
            }

            return gISModelFile.Save();
        }
        
        public GuidExternalReference? SaveAs(GuidExternalReference? guidExternalReference, string path)
        {
            if (guidExternalReference is null || !dictionary.TryGetValue(guidExternalReference, out GISModelFile gISModelFile))
            {
                return null;
            }

            bool saved = gISModelFile.SaveAs(path);
            if(!saved)
            {
                return null;
            }

            GuidExternalReference? result = gISModelFile.GuidExternalReference;
            if(result is null)
            {
                return null;
            }

            dictionary.Remove(guidExternalReference);
            dictionary[result] = gISModelFile;
            return result;
        }
        
        public bool TryGetObject<YIGISUniqueObject>(GISModelFileGuidObjectReference? gISModelFileUniqueObjectReference, out YIGISUniqueObject? gISUniqueObject) where YIGISUniqueObject : IGISUniqueObject
        {
            gISUniqueObject = default;

            if(gISModelFileUniqueObjectReference is null)
            {
                return false;
            }

            return TryGetObject(gISModelFileUniqueObjectReference.GuidExternalReference, gISModelFileUniqueObjectReference.GuidReference, out gISUniqueObject);
        }

        public bool TryGetObject<YIGISUniqueObject>(GISModelFileGuidObjectReference? gISModelFileUniqueObjectReference, out YIGISUniqueObject? gISUniqueObject, out GISModel? gISModel) where YIGISUniqueObject : IGISUniqueObject
        {
            gISUniqueObject = default;
            gISModel = null;

            if (gISModelFileUniqueObjectReference is null)
            {
                return false;
            }

            return TryGetObject(gISModelFileUniqueObjectReference.GuidExternalReference, gISModelFileUniqueObjectReference.GuidReference, out gISUniqueObject, out gISModel);
        }

        public bool TryGetObject<YIGISUniqueObject>(GuidExternalReference? guidExternalReference, GuidReference? guidReference, out YIGISUniqueObject? gISUniqueObject) where YIGISUniqueObject : IGISUniqueObject
        {
            return TryGetObject(guidExternalReference, guidReference, out gISUniqueObject, out _);
        }

        public bool TryGetObject<YIGISUniqueObject>(GuidExternalReference? guidExternalReference, GuidReference? guidReference, out YIGISUniqueObject? gISUniqueObject, out GISModel? gISModel) where YIGISUniqueObject : IGISUniqueObject
        {
            gISUniqueObject = default;
            gISModel = null;

            if (guidExternalReference is null || guidReference is null)
            {
                return false;
            }

            gISModel = GetGISModel(guidExternalReference);
            if (gISModel == null)
            {
                return false;
            }

            if (!gISModel.TryGetObject(guidReference, out gISUniqueObject))
            {
                return false;
            }

            return true;
        }

        public bool TryGetObject<TGISGuidObject2D>(GuidExternalReference? guidExternalReference, string reference, out TGISGuidObject2D? gISUniqueObject, out GISModel? gISModel) where TGISGuidObject2D : GISGuidObject2D
        {
            gISUniqueObject = default;
            gISModel = null;

            if (guidExternalReference is null || string.IsNullOrWhiteSpace(reference))
            {
                return false;
            }

            gISModel = GetGISModel(guidExternalReference);
            if (gISModel == null)
            {
                return false;
            }

            if (!gISModel.TryGetObject(reference, out gISUniqueObject))
            {
                return false;
            }

            return true;
        }
    }
}