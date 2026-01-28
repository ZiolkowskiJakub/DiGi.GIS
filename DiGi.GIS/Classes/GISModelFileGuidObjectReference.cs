using DiGi.Core.Classes;
using DiGi.Core.Interfaces;

namespace DiGi.GIS.Classes
{
    public class GISModelFileGuidObjectReference(GuidExternalReference? guidExternalReference, GuidReference? guidReference) : SerializableReference, IComplexReference
    {
        private readonly GuidExternalReference? guidExternalReference = guidExternalReference;
        private readonly GuidReference? guidReference = guidReference;

        public GuidExternalReference? GuidExternalReference
        {
            get
            {
                return guidExternalReference;
            }
        }

        public GuidReference? GuidReference
        {
            get
            {
                return guidReference;
            }
        }
    }
}