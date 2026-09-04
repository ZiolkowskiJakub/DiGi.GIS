using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary> Represents a reference to a GUID object within a GIS model file </summary>
    /// <example>
    /// Renders and parses (via <see cref="Core.Query.TryParse(string?, out IReference?)"/>) as the discriminator, the
    /// nested GIS model file reference, then the nested object reference:
    /// <code>GISModelFileGuidObject::(GuidExternal::Revit::(Guid::(Type::DiGi.GIS.Classes.Building2D,DiGi.GIS)::0f8fad5bd9cb469fa16570867728950e))::(Guid::(Type::DiGi.GIS.Classes.Building2D,DiGi.GIS)::a63dd7bf98e344deb0070e326ea0384c)</code>
    /// </example>
    /// <remarks>
    /// TODO [ReferenceFormat]: This type previously had no ToString override at all, so it rendered as its type name.
    /// Because equality and hashing are built on the rendered string, EVERY instance compared equal to every other
    /// regardless of its GUIDs. It also declared no serialization members, so it did not round-trip. Both are fixed
    /// here, and there is no earlier rendered form to stay compatible with.
    /// </remarks>
    public class GISModelFileGuidObjectReference : SerializableReference, IComplexReference
    {
        [JsonInclude, JsonPropertyName(nameof(GuidExternalReference))]
        private readonly GuidExternalReference? guidExternalReference;

        [JsonInclude, JsonPropertyName(nameof(GuidReference))]
        private readonly GuidReference? guidReference;

        /// <summary>Initializes a new instance of the <see cref="GISModelFileGuidObjectReference"/> class.</summary>
        /// <param name="guidExternalReference">The reference to the GIS model file.</param>
        /// <param name="guidReference">The reference to the object within that file.</param>
        public GISModelFileGuidObjectReference(GuidExternalReference? guidExternalReference, GuidReference? guidReference)
            : base()
        {
            this.guidExternalReference = guidExternalReference;
            this.guidReference = guidReference;
        }

        /// <summary>Initializes a new instance of the <see cref="GISModelFileGuidObjectReference"/> class by copying an existing reference.</summary>
        /// <param name="gISModelFileGuidObjectReference">The existing reference to copy.</param>
        public GISModelFileGuidObjectReference(GISModelFileGuidObjectReference? gISModelFileGuidObjectReference)
            : base(gISModelFileGuidObjectReference)
        {
            if (gISModelFileGuidObjectReference is not null)
            {
                guidExternalReference = Core.Query.Clone(gISModelFileGuidObjectReference.guidExternalReference);
                guidReference = Core.Query.Clone(gISModelFileGuidObjectReference.guidReference);
            }
        }

        /// <summary>Initializes a new instance of the <see cref="GISModelFileGuidObjectReference"/> class from a JSON object.</summary>
        /// <param name="jsonObject">The JSON object to initialize from.</param>
        public GISModelFileGuidObjectReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary> External GUID reference </summary>
        [JsonIgnore]
        public GuidExternalReference? GuidExternalReference
        {
            get
            {
                return guidExternalReference;
            }
        }

        /// <summary> Internal GUID reference within the GIS model </summary>
        [JsonIgnore]
        public GuidReference? GuidReference
        {
            get
            {
                return guidReference;
            }
        }

        /// <summary>Gets the segments of this reference's string form: the file reference, then the object reference.</summary>
        [JsonIgnore]
        protected override IEnumerable<string?> Segments
        {
            get
            {
                return [Core.Query.Segment(guidExternalReference), Core.Query.Segment(guidReference)];
            }
        }

        /// <summary>Creates a deep copy of the current object.</summary>
        /// <returns>A deep copy of the current object.</returns>
        public override ISerializableObject? Clone()
        {
            return new GISModelFileGuidObjectReference(this);
        }
    }
}