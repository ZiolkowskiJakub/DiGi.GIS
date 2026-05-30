using DiGi.Core.Interfaces;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public class GISModelAreal2DReference : Core.Classes.SerializableObject, IGISSerializableObject, ISerializableReference
    {
        /// <summary>
        /// Initializes a new instance of the GISModelAreal2DReference class
        /// </summary>
        public GISModelAreal2DReference(string? gISModelReference, string? areal2DReference)
        {
            GISModelReference = string.IsNullOrWhiteSpace(gISModelReference) ? null : gISModelReference;
            Areal2DReference = string.IsNullOrWhiteSpace(areal2DReference) ? null : areal2DReference;
        }

        /// <summary>
        /// Initializes a new instance of the GISModelAreal2DReference class from a JSON object
        /// </summary>
        public GISModelAreal2DReference(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GISModelAreal2DReference class as a copy
        /// </summary>
        public GISModelAreal2DReference(GISModelAreal2DReference gISModelAreal2DReference)
            : base(gISModelAreal2DReference)
        {
            if (gISModelAreal2DReference is not null)
            {
                GISModelReference = gISModelAreal2DReference.GISModelReference;
                Areal2DReference = gISModelAreal2DReference.Areal2DReference;
            }
        }

        /// <summary>
        /// Reference to the areal 2D object
        /// </summary>
        [JsonInclude, JsonPropertyName("Areal2DReference")]
        public string? Areal2DReference { get; }

        /// <summary>
        /// Reference to the GIS model
        /// </summary>
        [JsonInclude, JsonPropertyName("GISModelReference")]
        public string? GISModelReference { get; }

        public static bool operator !=(GISModelAreal2DReference gISModelAreal2DReference_1, ISerializableReference @object)
        {
            return gISModelAreal2DReference_1?.GetHashCode() != @object?.GetHashCode();
        }

        public static bool operator !=(GISModelAreal2DReference gISModelAreal2DReference_1, object @object)
        {
            return gISModelAreal2DReference_1?.GetHashCode() != @object?.GetHashCode();
        }

        public static bool operator !=(object serializableReference_1, GISModelAreal2DReference gISModelAreal2DReference_2)
        {
            return serializableReference_1?.GetHashCode() != gISModelAreal2DReference_2?.GetHashCode();
        }

        public static bool operator !=(GISModelAreal2DReference gISModelAreal2DReference_1, GISModelAreal2DReference gISModelAreal2DReference_2)
        {
            return gISModelAreal2DReference_1?.GetHashCode() != gISModelAreal2DReference_2?.GetHashCode();
        }

        public static bool operator ==(GISModelAreal2DReference gISModelAreal2DReference_1, ISerializableReference @object)
        {
            return gISModelAreal2DReference_1?.GetHashCode() == @object?.GetHashCode();
        }

        public static bool operator ==(GISModelAreal2DReference gISModelAreal2DReference_1, object @object)
        {
            return gISModelAreal2DReference_1?.GetHashCode() == @object?.GetHashCode();
        }

        public static bool operator ==(object serializableReference_1, GISModelAreal2DReference gISModelAreal2DReference_1)
        {
            return serializableReference_1?.GetHashCode() == gISModelAreal2DReference_1?.GetHashCode();
        }

        public static bool operator ==(GISModelAreal2DReference gISModelAreal2DReference_1, GISModelAreal2DReference gISModelAreal2DReference_2)
        {
            return gISModelAreal2DReference_1?.GetHashCode() == gISModelAreal2DReference_2?.GetHashCode();
        }

        /// <summary>
        /// Creates a clone of this instance
        /// </summary>
        public override ISerializableObject? Clone()
        {
            return new GISModelAreal2DReference(this);
        }

        /// <summary>
        /// Indicates whether this instance equals a given reference
        /// </summary>
        public bool Equals(IReference? reference)
        {
            if (reference is null)
            {
                return false;
            }

            if (GetType() != reference.GetType())
            {
                return false;
            }

            return ToString() == reference.ToString();
        }

        /// <summary>
        /// Indicates whether this instance equals a given object
        /// </summary>
        public override bool Equals(object? obj)
        {
            return Equals(obj as IReference);
        }

        /// <summary>
        /// Returns the hash code for this instance
        /// </summary>
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        /// <summary>
        /// Returns the string representation of this instance
        /// </summary>
        public override string ToString()
        {
            return Convert.ToSystem_String(GISModelReference, Areal2DReference) ?? string.Empty;
        }
    }
}