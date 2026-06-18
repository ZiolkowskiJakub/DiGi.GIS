using DiGi.Core.Classes;
using DiGi.Core.Interfaces;

namespace DiGi.GIS.Classes
{
    /// <summary> Represents a reference to a GUID object within a GIS model file </summary>
    public class GISModelFileGuidObjectReference(GuidExternalReference? guidExternalReference, GuidReference? guidReference) : SerializableReference, IComplexReference
    {
        private readonly GuidExternalReference? guidExternalReference = guidExternalReference;
        private readonly GuidReference? guidReference = guidReference;

        /// <summary> External GUID reference </summary>
        public GuidExternalReference? GuidExternalReference
        {
            get
            {
                return guidExternalReference;
            }
        }

        /// <summary> Internal GUID reference within the GIS model </summary>
        public GuidReference? GuidReference
        {
            get
            {
                return guidReference;
            }
        }
    }
}
