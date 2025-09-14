using System.IO;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static string? FileName(string? directory, string? fileName, string? extension, double maxFileSize)
        {
            if (string.IsNullOrWhiteSpace(directory) || string.IsNullOrWhiteSpace(fileName))
            {
                return null;
            }

            string? result;

            int index = 1;

            FileInfo? fileInfo;

            do
            {
                result = string.Format("{0}_{1}", fileName, index);
                fileInfo = new FileInfo(Path.Combine(directory, string.Format("{0}{1}", result, extension)));

                index++;

            } while (fileInfo.Exists && fileInfo.Length > maxFileSize);

            return result;
        }
    }
}



