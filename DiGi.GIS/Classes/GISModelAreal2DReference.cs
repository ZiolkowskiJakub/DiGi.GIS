using DiGi.Core.Interfaces;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a reference to an areal 2D object within a GIS model.
    /// </summary>
    public class GISModelAreal2DReference : Core.Classes.SerializableObject, IGISSerializableObject, ISerializableReference
    {
        /// <summary>
        /// Initializes a new instance of the GISModelAreal2DReference class.
        /// </summary>
        /// <param name="gISModelReference">The reference to the GIS model.</param>
        /// <param name="areal2DReference">The reference to the areal 2D object.</param>
        public GISModelAreal2DReference(string? gISModelReference, string? areal2DReference)
        {
            GISModelReference = string.IsNullOrWhiteSpace(gISModelReference) ? null : gISModelReference;
            Areal2DReference = string.IsNullOrWhiteSpace(areal2DReference) ? null : areal2DReference;
        }

        /// <summary>
        /// Initializes a new instance of the GISModelAreal2DReference class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the reference data.</param>
        public GISModelAreal2DReference(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GISModelAreal2DReference class as a copy of an existing instance.
        /// </summary>
        /// <param name="gISModelAreal2DReference">The source instance to copy from.</param>
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
        /// Gets the reference to the areal 2D object.
        /// </summary>
        [JsonInclude, JsonPropertyName("Areal2DReference")]
        public string? Areal2DReference { get; }

        /// <summary>
        /// Gets the reference to the GIS model.
        /// </summary>
        [JsonInclude, JsonPropertyName("GISModelReference")]
        public string? GISModelReference { get; }

        /// <summary>
        /// Determines whether the specified GISModelAreal2DReference and ISerializableReference are not equal.
        /// </summary>
        /// <param name="gISModelAreal2DReference_1">The first reference.</param>
        /// <param name="object">The second reference.</param>
        /// <returns>True if the references are not equal; otherwise, false.</returns>
        public static bool operator !=(GISModelAreal2DReference gISModelAreal2DReference_1, ISerializableReference @object)
        {
            return gISModelAreal2DReference_1?.GetHashCode() != @object?.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified GISModelAreal2DReference and object are not equal.
        /// </summary>
        /// <param name="gISModelAreal2DReference_1">The first reference.</param>
        /// <param name="object">The second object.</param>
        /// <returns>True if the references are not equal; otherwise, false.</returns>
        public static bool operator !=(GISModelAreal2DReference gISModelAreal2DReference_1, object @object)
        {
            return gISModelAreal2DReference_1?.GetHashCode() != @object?.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified object and GISModelAreal2DReference are not equal.
        /// </summary>
        /// <param name="serializableReference_1">The first object.</param>
        /// <param name="gISModelAreal2DReference_2">The second reference.</param>
        /// <returns>True if the references are not equal; otherwise, false.</returns>
        public static bool operator !=(object serializableReference_1, GISModelAreal2DReference gISModelAreal2DReference_2)
        {
            return serializableReference_1?.GetHashCode() != gISModelAreal2DReference_2?.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified two GISModelAreal2DReference instances are not equal.
        /// </summary>
        /// <param name="gISModelAreal2DReference_1">The first reference.</param>
        /// <param name="gISModelAreal2DReference_2">The second reference.</param>
        /// <returns>True if the references are not equal; otherwise, false.</returns>
        public static bool operator !=(GISModelAreal2DReference gISModelAreal2DReference_1, GISModelAreal2DReference gISModelAreal2DReference_2)
        {
            return gISModelAreal2DReference_1?.GetHashCode() != gISModelAreal2DReference_2?.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified GISModelAreal2DReference and ISerializableReference are equal.
        /// </summary>
        /// <param name="gISModelAreal2DReference_1">The first reference.</param>
        /// <param name="object">The second reference.</param>
        /// <returns>True if the references are equal; otherwise, false.</returns>
        public static bool operator ==(GISModelAreal2DReference gISModelAreal2DReference_1, ISerializableReference @object)
        {
            return gISModelAreal2DReference_1?.GetHashCode() == @object?.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified GISModelAreal2DReference and object are equal.
        /// </summary>
        /// <param name="gISModelAreal2DReference_1">The first reference.</param>
        /// <param name="object">The second object.</param>
        /// <returns>True if the references are equal; otherwise, false.</returns>
        public static bool operator ==(GISModelAreal2DReference gISModelAreal2DReference_1, object @object)
        {
            return gISModelAreal2DReference_1?.GetHashCode() == @object?.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified object and GISModelAreal2DReference are equal.
        /// </summary>
        /// <param name="serializableReference_1">The first object.</param>
        /// <param name="gISModelAreal2DReference_1">The second reference.</param>
        /// <returns>True if the references are equal; otherwise, false.</returns>
        public static bool operator ==(object serializableReference_1, GISModelAreal2DReference gISModelAreal2DReference_1)
        {
            return serializableReference_1?.GetHashCode() == gISModelAreal2DReference_1?.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified two GISModelAreal2DReference instances are equal.
        /// </summary>
        /// <param name="gISModelAreal2DReference_1">The first reference.</param>
        /// <param name="gISModelAreal2DReference_2">The second reference.</param>
        /// <returns>True if the references are equal; otherwise, false.</returns>
        public static bool operator ==(GISModelAreal2DReference gISModelAreal2DReference_1, GISModelAreal2DReference gISModelAreal2DReference_2)
        {
            return gISModelAreal2DReference_1?.GetHashCode() == gISModelAreal2DReference_2?.GetHashCode();
        }

        /// <summary>
        /// Creates a clone of this instance.
        /// </summary>
        /// <returns>A new GISModelAreal2DReference instance that is a copy of the current instance.</returns>
        public override ISerializableObject? Clone()
        {
            return new GISModelAreal2DReference(this);
        }

        /// <summary>
        /// Indicates whether this instance equals a given reference.
        /// </summary>
        /// <param name="reference">The reference to compare with this instance.</param>
        /// <returns>True if the instances are equal; otherwise, false.</returns>
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
        /// Indicates whether this instance equals a given object.
        /// </summary>
        /// <param name="obj">The object to compare with this instance.</param>
        /// <returns>True if the objects are equal; otherwise, false.</returns>
        public override bool Equals(object? obj)
        {
            return Equals(obj as IReference);
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A 32-bit signed integer hash code.</returns>
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        /// <summary>
        /// Returns the string representation of this instance.
        /// </summary>
        /// <returns>A string representing the GIS model and areal 2D references.</returns>
        public override string ToString()
        {
            return Convert.ToSystem_String(GISModelReference, Areal2DReference) ?? string.Empty;
        }
    }
}