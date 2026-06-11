using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents an abstract base class for 2D GIS objects that are identified by a GUID.
    /// </summary>
    public abstract class GISGuidObject2D : GuidObject, IGISGuidObject2D
    {
        [JsonInclude, JsonPropertyName("Reference")]
        private readonly string? reference = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="GISGuidObject2D"/> class.
        /// </summary>
        /// <param name="guid">The unique identifier for the object.</param>
        /// <param name="reference">The reference string associated with the object.</param>
        public GISGuidObject2D(Guid guid, string? reference)
            : base(guid)
        {
            this.reference = reference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GISGuidObject2D"/> class as a copy of an existing object.
        /// </summary>
        /// <param name="gISGuidObject2D">The source object to copy from.</param>
        public GISGuidObject2D(GISGuidObject2D? gISGuidObject2D)
            : base(gISGuidObject2D == null ? Guid.Empty : gISGuidObject2D.Guid)
        {
            if (gISGuidObject2D != null)
            {
                reference = gISGuidObject2D.reference;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GISGuidObject2D"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data to initialize the instance.</param>
        public GISGuidObject2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the reference identifier.
        /// </summary>
        [JsonIgnore]
        public string? Reference
        {
            get
            {
                return reference;
            }
        }
    }
}