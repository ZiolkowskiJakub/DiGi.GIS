using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using DiGi.GIS.Interfaces;

namespace DiGi.GIS
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a unique object reference for a GIS model file using the provided GUID object.
        /// </summary>
        /// <param name="gISModelFile">The GIS model file instance.</param>
        /// <param name="gISGuidObject">The GUID object to be used as a reference.</param>
        /// <returns>A <see cref="GISModelFileGuidObjectReference"/> if both inputs and the external reference are valid; otherwise, null.</returns>
        public static GISModelFileGuidObjectReference? GISModelFileUniqueObjectReference(this GISModelFile? gISModelFile, IGISGuidObject? gISGuidObject)
        {
            if (gISModelFile == null || gISGuidObject == null)
            {
                return null;
            }

            GuidExternalReference? guidExternalReference = gISModelFile.GuidExternalReference;
            if (guidExternalReference is null)
            {
                return null;
            }

            return new GISModelFileGuidObjectReference(guidExternalReference, new GuidReference(gISGuidObject));
        }
    }
}