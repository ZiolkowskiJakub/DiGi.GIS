using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.GIS.Classes;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Create
    {
        /// <summary>
        /// Parses the <c>[gISModelReference]areal2DReference</c> shorthand into a <see cref="Classes.GISModelAreal2DReference"/>.
        /// </summary>
        /// <param name="reference">The shorthand to parse.</param>
        /// <returns>A <see cref="Classes.GISModelAreal2DReference"/> object if the input is valid; otherwise, null.</returns>
        /// <remarks>
        /// This is a convenience for hand-written input and is NOT the inverse of
        /// <see cref="GISModelAreal2DReference.ToString"/> - that round trip goes through
        /// <see cref="Core.Query.TryParse(string?, out IReference?)"/> and the segment overload below. The shorthand
        /// escapes nothing, so it cannot express a reference containing brackets; prefer the round-trip form when
        /// the string is machine-generated.
        /// </remarks>
        public static GISModelAreal2DReference? GISModelAreal2DReference(this string reference)
        {
            if (string.IsNullOrWhiteSpace(reference))
            {
                return null;
            }

            string reference_Temp = reference.Trim();

            int index_End = reference_Temp.IndexOf(']');
            if (index_End > 0 && reference_Temp.StartsWith("["))
            {
                string gISModelReference = reference_Temp.Substring(1, index_End - 1);
                string areal2DReference = reference_Temp.Substring(index_End + 1);

                return new GISModelAreal2DReference(gISModelReference, areal2DReference);
            }

            return new GISModelAreal2DReference(null, reference);
        }

        /// <summary>Rebuilds a <see cref="Classes.GISModelAreal2DReference"/> from the segments of its string form.</summary>
        /// <param name="segments">The segments: the GIS model reference, then the areal 2D reference.</param>
        /// <returns>The reference, or <c>null</c> if the segments do not describe one.</returns>
        [ReferenceFactory(typeof(GISModelAreal2DReference), Kind = Constants.ReferenceKind.GISModelAreal2D)]
        public static IReference? GISModelAreal2DReference(IReadOnlyList<string?>? segments)
        {
            if (segments == null || segments.Count != 2)
            {
                return null;
            }

            return new GISModelAreal2DReference(Core.Query.Unescaped(segments[0]), Core.Query.Unescaped(segments[1]));
        }
    }
}
