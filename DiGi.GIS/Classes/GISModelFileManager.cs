using DiGi.GIS.Interfaces;
using System.Collections.Generic;
using DiGi.Core.Classes;

namespace DiGi.GIS.Classes
{
    public class GISModelFileManager : IGISObject
    {
        private Dictionary<GuidExternalReference, GISModelFile> dictionary = new Dictionary<GuidExternalReference, GISModelFile>();

        public GISModelFileManager() 
        { 
        }

        public GuidExternalReference Open(string path)
        {
            if(string.IsNullOrWhiteSpace(path))
            {
                return null;
            }

            GISModelFile gISModelFile = new GISModelFile(path);
            if(gISModelFile.Open())
            {
                GuidExternalReference guidExternalReference = gISModelFile.GuidExternalReference;
                if(guidExternalReference != null)
                {
                    dictionary[guidExternalReference] = gISModelFile;
                    return guidExternalReference;
                }
            }

            return null;
        }

        public bool Save(GuidExternalReference guidExternalReference)
        {
            if(guidExternalReference == null || !dictionary.TryGetValue(guidExternalReference, out GISModelFile gISModelFile))
            {
                return false;
            }

            return gISModelFile.Save();
        }

        public GuidExternalReference SaveAs(GuidExternalReference guidExternalReference, string path)
        {
            if (guidExternalReference == null || !dictionary.TryGetValue(guidExternalReference, out GISModelFile gISModelFile))
            {
                return null;
            }

            bool saved = gISModelFile.SaveAs(path);
            if(!saved)
            {
                return null;
            }

            GuidExternalReference result = gISModelFile.GuidExternalReference;
            if(result == null)
            {
                return null;
            }

            dictionary.Remove(guidExternalReference);
            dictionary[result] = gISModelFile;
            return result;
        }

        public HashSet<GuidExternalReference> GetGuidExternalReferences()
        {
            return new HashSet<GuidExternalReference>(dictionary.Keys);
        }

        public GISModel GetGISModel(GuidExternalReference guidExternalReference)
        {
            if(guidExternalReference == null)
            {
                return null;
            }

            if(!dictionary.TryGetValue(guidExternalReference, out GISModelFile gISModelFile))
            {
                return null;
            }

            return gISModelFile.Value;
        }

        public bool TryGetObject<YIGISUniqueObject>(GISModelFileGuidObjectReference gISModelFileUniqueObjectReference, out YIGISUniqueObject gISUniqueObject) where YIGISUniqueObject : IGISUniqueObject
        {
            gISUniqueObject = default;

            if(gISModelFileUniqueObjectReference == null)
            {
                return false;
            }

            return TryGetObject(gISModelFileUniqueObjectReference.GuidExternalReference, gISModelFileUniqueObjectReference.GuidReference, out gISUniqueObject);
        }

        public bool TryGetObject<YIGISUniqueObject>(GISModelFileGuidObjectReference gISModelFileUniqueObjectReference, out YIGISUniqueObject gISUniqueObject, out GISModel gISModel) where YIGISUniqueObject : IGISUniqueObject
        {
            gISUniqueObject = default;
            gISModel = null;

            if (gISModelFileUniqueObjectReference == null)
            {
                return false;
            }

            return TryGetObject(gISModelFileUniqueObjectReference.GuidExternalReference, gISModelFileUniqueObjectReference.GuidReference, out gISUniqueObject, out gISModel);
        }

        public bool TryGetObject<YIGISUniqueObject>(GuidExternalReference guidExternalReference, GuidReference guidReference, out YIGISUniqueObject gISUniqueObject) where YIGISUniqueObject : IGISUniqueObject
        {
            return TryGetObject(guidExternalReference, guidReference, out gISUniqueObject, out GISModel gISModel);
        }

        public bool TryGetObject<YIGISUniqueObject>(GuidExternalReference guidExternalReference, GuidReference guidReference, out YIGISUniqueObject gISUniqueObject, out GISModel gISModel) where YIGISUniqueObject : IGISUniqueObject
        {
            gISUniqueObject = default;
            gISModel = null;

            if (guidExternalReference == null || guidReference == null)
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
    }
}