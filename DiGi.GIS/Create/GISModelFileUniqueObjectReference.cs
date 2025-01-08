using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using DiGi.GIS.Interfaces;

namespace DiGi.GIS
{
    public static partial class Create
    {
        public static GISModelFileUniqueObjectReference GISModelFileUniqueObjectReference(this GISModelFile gISModelFile, IGISUniqueObject gISUniqueObject)
        {
            if(gISModelFile == null || gISUniqueObject == null)
            {
                return null;
            }

            GuidExternalReference guidExternalReference = gISModelFile.GuidExternalReference;
            if(guidExternalReference == null)
            {
                return null;
            }

            return new GISModelFileUniqueObjectReference(guidExternalReference, new GuidReference(gISUniqueObject));
        }
    }
}
