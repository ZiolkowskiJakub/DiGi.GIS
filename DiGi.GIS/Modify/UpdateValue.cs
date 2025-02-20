using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using DiGi.GIS.Interfaces;

namespace DiGi.GIS
{
    public static partial class Modify
    {
        public static UniqueReference UpdateValue(this GISModelFile gISModelFile, Building2D builidng2D, short? yearBuilt)
        {
            if(gISModelFile == null || builidng2D == null)
            {
                return null;
            }
            string reference = builidng2D.Reference;
            if (string.IsNullOrWhiteSpace(reference))
            {
                return null;
            }

            string path = gISModelFile.Path;
            if(string.IsNullOrWhiteSpace(path))
            {
                return null;
            }

            string directory = System.IO.Path.GetDirectoryName(path);
            if(!System.IO.Directory.Exists(directory))
            {
                return null;
            }

            path = System.IO.Path.Combine(directory, string.Format("{0}.{1}", System.IO.Path.GetFileNameWithoutExtension(path), Constans.FileExtension.YearBuiltDatasFile));

            using (YearBuiltDataFile yearBuiltDataFile = new YearBuiltDataFile(path))
            {
                yearBuiltDataFile.Open();

                UniqueReference uniqueReference = yearBuiltDataFile.RemoveFirst<IYearBuiltData>(x => x.Reference == reference);
                if (yearBuilt != null && yearBuilt.HasValue)
                {
                    uniqueReference = yearBuiltDataFile.AddValue(new YearBuiltData(builidng2D.Reference, yearBuilt.Value));
                }

                if (uniqueReference != null)
                {
                    yearBuiltDataFile.Save();
                }

                return uniqueReference;
            }
        }
    }
}
