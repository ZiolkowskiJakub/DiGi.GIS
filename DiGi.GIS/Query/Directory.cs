using DiGi.GIS.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.GIS
{
    public static partial class Query
    {
        /// <summary>
        /// Combines a base directory with a collection of directory names to form a full path, optionally verifying if the resulting directory exists on the disk.
        /// </summary>
        /// <param name="directory">The base directory path.</param>
        /// <param name="directoryNames">A collection of additional directory names to append to the base path.</param>
        /// <param name="checkIfExists">A boolean value indicating whether to verify the existence of the combined path; if set to true and the resulting path does not exist, the original base directory is returned.</param>
        /// <returns>The combined directory path if successful or valid, otherwise the original directory or null if the base directory is null or whitespace.</returns>
        public static string? Directory(string? directory, IEnumerable<string>? directoryNames, bool checkIfExists = false)
        {
            if (string.IsNullOrWhiteSpace(directory))
            {
                return null;
            }

            List<string> values = [directory!];
            if (directoryNames != null && directoryNames.Count() != 0)
            {
                values.AddRange(directoryNames);
            }

            string directory_Temp = System.IO.Path.Combine([.. values]);
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

        /// <summary>
        /// Combines a base directory with directory names provided via a <see cref="DirectoryNamesOptions"/> object, optionally verifying if the resulting directory exists on the disk.
        /// </summary>
        /// <param name="directoryNamesOptions">The options object containing the list of directory names to append.</param>
        /// <param name="directory">The base directory path.</param>
        /// <param name="checkIfExists">A boolean value indicating whether to verify the existence of the combined path; if set to true and the resulting path does not exist, the original base directory is returned.</param>
        /// <returns>The combined directory path if successful or valid, otherwise the original directory or null if the options object is null.</returns>
        public static string? Directory(this DirectoryNamesOptions? directoryNamesOptions, string directory, bool checkIfExists = false)
        {
            if (directoryNamesOptions == null)
            {
                return null;
            }

            string[]? directoryNames = directoryNamesOptions.DirectoryNames;
            if (directoryNames == null || directoryNames.Length == 0)
            {
                return directory;
            }

            return Directory(directory, directoryNames, checkIfExists);
        }
    }
}