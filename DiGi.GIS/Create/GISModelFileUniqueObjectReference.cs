using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using DiGi.GIS.Interfaces;

namespace DiGi.GIS
{
    public static partial class Create
    {
        public static GISModelFileGuidObjectReference GISModelFileUniqueObjectReference(this GISModelFile gISModelFile, IGISGuidObject gISGuidObject)
        {
            if(gISModelFile == null || gISGuidObject == null)
            {
                return null;
            }

            GuidExternalReference guidExternalReference = gISModelFile.GuidExternalReference;
            if(guidExternalReference == null)
            {
                return null;
            }

            return new GISModelFileGuidObjectReference(guidExternalReference, new GuidReference(gISGuidObject));
        }
    }
}
