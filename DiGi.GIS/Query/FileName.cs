using System.IO;

namespace DiGi.GIS
{
    public static partial class Query
    {
        /// <summary>
        /// Generates a unique filename by appending an incrementing index until a file that either does not exist or is smaller than the specified maximum size is found.
        /// </summary>
        /// <param name="directory">The directory path where the files are located.</param>
        /// <param name="fileName">The base name of the file.</param>
        /// <param name="extension">The file extension to be appended to the filename.</param>
        /// <param name="maxFileSize">The maximum allowable size of the file in bytes.</param>
        /// <returns>A unique filename string if successful; otherwise, null if the directory or fileName is null or whitespace.</returns>
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