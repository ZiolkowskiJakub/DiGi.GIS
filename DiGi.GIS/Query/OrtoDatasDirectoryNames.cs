namespace DiGi.GIS
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the directory names associated with Orto Range data.
        /// </summary>
        /// <returns>An array of strings containing the directory names for Orto Data and Orto Range.</returns>
        public static string[] OrtoDatasDirectoryNames_OrtoRange()
        {
            return [Constants.DirectoryName.OrtoData, Constants.DirectoryName.OrtoRange];
        }

        /// <summary>
        /// Gets the directory names associated with Building 2D data.
        /// </summary>
        /// <returns>An array of strings containing the directory names for Orto Data and Building 2D.</returns>
        public static string[] OrtoDatasDirectoryNames_Building2D()
        {
            return [Constants.DirectoryName.OrtoData, Constants.DirectoryName.Building2D];
        }
    }
}