using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a result object containing the GUID for an external reference of a 2D building.
    /// </summary>
    public abstract class Building2DExternalReferenceGuidResult : ExternalReferenceGuidResult<Building2D, InstanceRelatedExternalReference>, IGISGuidResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Building2DExternalReferenceGuidResult"/> class using the specified external reference.
        /// </summary>
        /// <param name="reference">The external reference used to initialize the result.</param>
        public Building2DExternalReferenceGuidResult(InstanceRelatedExternalReference reference)
            : base(reference)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Building2DExternalReferenceGuidResult"/> class from the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the result data.</param>
        public Building2DExternalReferenceGuidResult(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Building2DExternalReferenceGuidResult"/> class by copying another instance.
        /// </summary>
        /// <param name="building2DExternalReferenceGuidResult">The source result instance to copy from.</param>
        public Building2DExternalReferenceGuidResult(Building2DExternalReferenceGuidResult building2DExternalReferenceGuidResult)
            : base(building2DExternalReferenceGuidResult)
        {
        }
    }
}