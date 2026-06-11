namespace DiGi.GIS
{
    public static partial class Create
    {
        /// <summary>
        /// Sanitizes the provided text to ensure it contains only characters valid for a file name, replacing invalid characters with underscores.
        /// </summary>
        /// <param name="text">The source text to be sanitized.</param>
        /// <returns>A string containing the sanitized text, or null if the input text is null or empty.</returns>
        public static string? Reference(string? text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return null;
            }

            char[] invalidChars = System.IO.Path.GetInvalidFileNameChars();

            string? result = text;

            int index = result!.IndexOfAny(invalidChars);

            while (index != -1)
            {
                char @char = result[index];
                result = result.Replace(@char, '_');
                index = result.IndexOfAny(invalidChars);
            }

            return result;
        }
    }
}