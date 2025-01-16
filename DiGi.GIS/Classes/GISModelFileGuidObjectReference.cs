using DiGi.Core.Classes;
using DiGi.Core.Interfaces;

namespace DiGi.GIS.Classes
{
    public class GISModelFileGuidObjectReference : SerializableReference, IComplexReference
    {
        private GuidExternalReference guidExternalReference;
        private GuidReference guidReference;

        public GISModelFileGuidObjectReference(GuidExternalReference guidExternalReference, GuidReference guidReference)
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
