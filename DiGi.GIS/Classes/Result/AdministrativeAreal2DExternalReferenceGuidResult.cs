using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a result object that provides the external reference GUID for an administrative areal 2D entity.
    /// </summary>
    public abstract class AdministrativeAreal2DExternalReferenceGuidResult : ExternalReferenceGuidResult<AdministrativeAreal2D, InstanceRelatedExternalReference>, IGISGuidResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrativeAreal2DExternalReferenceGuidResult"/> class using the specified external reference.
        /// </summary>
        /// <param name="reference">The instance-related external reference to initialize with.</param>
        public AdministrativeAreal2DExternalReferenceGuidResult(InstanceRelatedExternalReference reference)
            : base(reference)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrativeAreal2DExternalReferenceGuidResult"/> class from the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data for the result.</param>
        public AdministrativeAreal2DExternalReferenceGuidResult(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrativeAreal2DExternalReferenceGuidResult"/> class by copying another result object.
        /// </summary>
        /// <param name="administrativeAreal2DExternalReferenceGuidResult">The source result object to copy from.</param>
        public AdministrativeAreal2DExternalReferenceGuidResult(AdministrativeAreal2DExternalReferenceGuidResult administrativeAreal2DExternalReferenceGuidResult)
            : base(administrativeAreal2DExternalReferenceGuidResult)
        {
        }
    }
}