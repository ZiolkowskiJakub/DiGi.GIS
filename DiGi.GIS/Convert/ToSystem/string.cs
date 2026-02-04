namespace DiGi.GIS
{
    public static partial class Convert
    {
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