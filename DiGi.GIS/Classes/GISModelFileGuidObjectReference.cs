using DiGi.Core.Classes;
using DiGi.Core.Interfaces;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a reference to a GUID object within a GIS model file
    /// </summary>
    /// <param name="guidExternalReference">The external GUID reference.</param>
    /// <param name="guidReference">The internal GUID reference.</param>
    public class GISModelFileGuidObjectReference(GuidExternalReference? guidExternalReference, GuidReference? guidReference) : SerializableReference, IComplexReference
    {
        private readonly GuidExternalReference? guidExternalReference = guidExternalReference;
        private readonly GuidReference? guidReference = guidReference;

        /// <summary>
        /// External GUID reference
        /// </summary>
        /// <returns>The external GUID reference if available; otherwise, null.</returns>
        public GuidExternalReference? GuidExternalReference
        {
            get
            {
                return guidExternalReference;
            }
        }

        /// <summary>
        /// Internal GUID reference within the GIS model
        /// </summary>
        /// <returns>The internal GUID reference if available; otherwise, null.</returns>
        public GuidReference? GuidReference
        {
            get
            {
                return guidReference;
            }
        }
    }
}