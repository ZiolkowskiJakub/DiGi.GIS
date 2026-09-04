using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.GIS.Classes;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Create
    {
        /// <summary>Rebuilds a <see cref="Classes.GISModelFileGuidObjectReference"/> from the segments of its string form.</summary>
        /// <param name="segments">The segments: the nested GIS model file reference, then the nested object reference.</param>
        /// <returns>The reference, or <c>null</c> if the segments do not describe one.</returns>
        [ReferenceFactory(typeof(GISModelFileGuidObjectReference), Kind = Constants.ReferenceKind.GISModelFileGuidObject)]
        public static IReference? GISModelFileGuidObjectReference(IReadOnlyList<string?>? segments)
        {
            if (segments == null || segments.Count != 2)
            {
                return null;
            }

            return new GISModelFileGuidObjectReference(
                Core.Query.Reference<GuidExternalReference>(segments[0]),
                Core.Query.Reference<GuidReference>(segments[1]));
        }
    }
}