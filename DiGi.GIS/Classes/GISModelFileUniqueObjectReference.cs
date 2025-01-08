using DiGi.Core.Classes;
using DiGi.Core.Interfaces;

namespace DiGi.GIS.Classes
{
    public class GISModelFileUniqueObjectReference : SerializableReference, IComplexReference
    {
        private GuidExternalReference guidExternalReference;
        private GuidReference guidReference;

        public GISModelFileUniqueObjectReference(GuidExternalReference guidExternalReference, GuidReference guidReference)
        {
            this.guidExternalReference = guidExternalReference;
            this.guidReference = guidReference;
        }

        public GuidExternalReference GuidExternalReference
        {
            get
            {
                return guidExternalReference;
            }
        }

        public GuidReference GuidReference
        {
            get
            {
                return guidReference;
            }
        }
    }
}
