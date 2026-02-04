using DiGi.Core.Interfaces;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public class GISModelAreal2DReference : Core.Classes.SerializableObject, IGISSerializableObject, ISerializableReference
    {
        public GISModelAreal2DReference(string? gISModelReference, string? areal2DReference)
        {
            GISModelReference = string.IsNullOrWhiteSpace(gISModelReference) ? null : gISModelReference;
            Areal2DReference = string.IsNullOrWhiteSpace(areal2DReference) ? null : areal2DReference;
        }

        public GISModelAreal2DReference(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public GISModelAreal2DReference(GISModelAreal2DReference gISModelAreal2DReference)
            : base(gISModelAreal2DReference)
        {
            if (gISModelAreal2DReference is not null)
            {
                GISModelReference = gISModelAreal2DReference.GISModelReference;
                Areal2DReference = gISModelAreal2DReference.Areal2DReference;
            }
        }

        [JsonInclude, JsonPropertyName("Areal2DReference")]
        public string? Areal2DReference { get; }

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

        public override ISerializableObject? Clone()
        {
            return new GISModelAreal2DReference(this);
        }

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

        public override bool Equals(object? obj)
        {
            return Equals(obj as IReference);
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override string ToString()
        {
            return Convert.ToSystem_String(GISModelReference, Areal2DReference) ?? string.Empty;
        }
    }
}