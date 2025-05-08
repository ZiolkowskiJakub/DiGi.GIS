using DiGi.GIS.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static string Directory(string directory, IEnumerable<string> directoryNames, bool checkIfExists = false)
        {
            if (string.IsNullOrWhiteSpace(directory))
            {
                return null;
            }

            List<string> values = new List<string>() { directory };
            if (directoryNames != null && directoryNames.Count() != 0)
            {
                values.AddRange(directoryNames);
            }

            string directory_Temp = System.IO.Path.Combine(values.ToArray());
            if (!checkIfExists)
            {
                return directory_Temp;
            }

            if (System.IO.Directory.Exists(directory_Temp))
            {
                return directory_Temp;
            }

            return directory;
        }

        public static string Directory(this DirectoryNamesOptions directoryNamesOptions, string directory, bool checkIfExists = false)
        {
            if (directoryNamesOptions == null)
            {
                return null;
            }

            string[] directoryNames = directoryNamesOptions.DirectoryNames;
            if (directoryNames == null || directoryNames.Length == 0)
            {
                return directory;
            }

            return Directory(directory, directoryNames, checkIfExists);
        }
    }
}



