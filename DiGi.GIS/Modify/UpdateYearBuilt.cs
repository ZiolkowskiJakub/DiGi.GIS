using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using System.Linq;

namespace DiGi.GIS
{
    public static partial class Modify
    {
        /// <summary>
        /// Updates the user-defined year built for a specific building within a GIS model file.
        /// </summary>
        /// <param name="gISModelFile">The GIS model file containing the data path.</param>
        /// <param name="builidng2D">The 2D building object whose reference is used to identify the record.</param>
        /// <param name="yearBuilt">The new year built value to set; if null, the user-defined year built is removed.</param>
        /// <returns>A <see cref="UniqueReference"/> identifying the updated or removed record, or <c>null</c> if the operation could not be performed.</returns>
        public static UniqueReference? UpdateUserYearBuilt(this GISModelFile? gISModelFile, Building2D? builidng2D, short? yearBuilt)
        {
            if (gISModelFile == null || builidng2D == null)
            {
                return null;
            }
            string? reference = builidng2D.Reference;
            if (string.IsNullOrWhiteSpace(reference))
            {
                return null;
            }

            string? path = gISModelFile.Path;
            if (string.IsNullOrWhiteSpace(path))
            {
                return null;
            }

            string directory = System.IO.Path.GetDirectoryName(path);
            if (!System.IO.Directory.Exists(directory))
            {
                return null;
            }

            path = System.IO.Path.Combine(directory, string.Format("{0}.{1}", System.IO.Path.GetFileNameWithoutExtension(path), Constants.FileExtension.YearBuiltDataFile));

            UniqueReference? uniqueReference = null;

            using YearBuiltDataFile yearBuiltDataFile = new(path);

            yearBuiltDataFile.Open();

            YearBuiltData? yearBuiltData = yearBuiltDataFile.GetValue<YearBuiltData>(reference);

            if (yearBuilt != null && yearBuilt.HasValue)
            {
                yearBuiltData ??= new YearBuiltData(reference);

                yearBuiltData.SetUserYearBuilt(yearBuilt.Value);

                uniqueReference = yearBuiltDataFile.AddValue(yearBuiltData);
            }
            else if (yearBuiltData != null)
            {
                yearBuiltData.RemoveUserYearBuilt();

                if (yearBuiltData.YearBuilts == null || yearBuiltData.YearBuilts.Count() == 0)
                {
                    UniqueReference? uniqueReference_Temp = YearBuiltDataFile.GetUniqueReference<YearBuiltData>(reference);
                    if (uniqueReference_Temp is not null && yearBuiltDataFile.Remove(uniqueReference_Temp))
                    {
                        uniqueReference = uniqueReference_Temp;
                    }
                }
                else
                {
                    uniqueReference = yearBuiltDataFile.AddValue(yearBuiltData);
                }
            }

            if (uniqueReference is not null)
            {
                yearBuiltDataFile.Save();
            }

            return uniqueReference;
        }
    }
}