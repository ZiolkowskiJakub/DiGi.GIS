namespace DiGi.Geo
{
    public static partial class Create
    {
        public static string Reference(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return null;
            }

            char[] invalidChars = System.IO.Path.GetInvalidFileNameChars();

            string result = text;

            int index = result.IndexOfAny(invalidChars);

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
