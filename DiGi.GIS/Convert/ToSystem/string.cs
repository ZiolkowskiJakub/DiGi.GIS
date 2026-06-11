namespace DiGi.GIS
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts the GIS model reference and areal 2D reference into a formatted system string.
        /// </summary>
        /// <param name="gISModelReference">The GIS model reference identifier.</param>
        /// <param name="areal2DReference">The areal 2D reference identifier.</param>
        /// <returns>A formatted string combining the references, or null if the areal 2D reference is null or whitespace.</returns>
        public static string? ToSystem_String(string? gISModelReference, string? areal2DReference)
        {
            if (string.IsNullOrWhiteSpace(areal2DReference))
            {
                return null;
            }

            if (string.IsNullOrWhiteSpace(gISModelReference))
            {
                return areal2DReference!.Trim();
            }

            return $"[{gISModelReference!.Trim()}]{areal2DReference!.Trim()}";
        }
    }
}