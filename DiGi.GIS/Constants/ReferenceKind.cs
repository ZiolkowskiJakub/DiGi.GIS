namespace DiGi.GIS.Constants
{
    /// <summary>
    /// Discriminator tokens for the reference types defined in DiGi.GIS.
    /// <para>These values are a persisted contract: they are written into stored reference strings, so they are
    /// append-only. Renaming one silently invalidates every string already stored in that format. A token must be
    /// unique across every repository, and must contain neither a comma (which would make it parse as a full type
    /// name) nor a colon.</para>
    /// <para>This class is deliberately NOT named Reference. A local Constants.Reference would win
    /// innermost-namespace lookup over DiGi.Core.Constants.Reference and silently shadow the shared grammar
    /// constants - a bug this codebase has already had once, in DiGi.PostgreSQL.</para>
    /// </summary>
    public static class ReferenceKind
    {
        /// <summary>Discriminator for <see cref="Classes.GISModelAreal2DReference"/>.</summary>
        public const string GISModelAreal2D = "GISModelAreal2D";

        /// <summary>Discriminator for <see cref="Classes.GISModelFileGuidObjectReference"/>.</summary>
        public const string GISModelFileGuidObject = "GISModelFileGuidObject";
    }
}