namespace DiGi.GIS
{
    public static partial class Query
    {
        public static string OrtoDatasDirectory_Building2D(string directory, bool checkIfExists = false)
        {
            return Directory(directory, OrtoDatasDirectoryNames_Building2D(), checkIfExists);
        }

        public static string OrtoDatasDirectory_OrtoRange(string directory, bool checkIfExists = false)
        {
            return Directory(directory, OrtoDatasDirectoryNames_OrtoRange(), checkIfExists);
        }
    }
}



