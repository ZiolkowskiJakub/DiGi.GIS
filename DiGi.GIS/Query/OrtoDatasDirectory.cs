namespace DiGi.GIS
{
    public static partial class Query
    {
        /// <summary>
        /// Retrieves the path to the Building 2D Orto data directory.
        /// </summary>
        /// <param name="directory">The base directory path.</param>
        /// <param name="checkIfExists">A value indicating whether to check if the directory exists.</param>
        /// <returns>The full path to the Building 2D Orto data directory, or null if not found.</returns>
        public static string? OrtoDatasDirectory_Building2D(string? directory, bool checkIfExists = false)
        {
            return Directory(directory, OrtoDatasDirectoryNames_Building2D(), checkIfExists);
        }

        /// <summary>
        /// Retrieves the path to the Orto Range Orto data directory.
        /// </summary>
        /// <param name="directory">The base directory path.</param>
        /// <param name="checkIfExists">A value indicating whether to check if the directory exists.</param>
        /// <returns>The full path to the Orto Range Orto data directory, or null if not found.</returns>
        public static string? OrtoDatasDirectory_OrtoRange(string? directory, bool checkIfExists = false)
        {
            return Directory(directory, OrtoDatasDirectoryNames_OrtoRange(), checkIfExists);
        }
    }
}