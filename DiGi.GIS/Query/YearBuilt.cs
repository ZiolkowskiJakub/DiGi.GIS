using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using DiGi.GIS.Interfaces;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static short? YearBuilt(this GISModelFile gISModelFile, Building2D builidng2D)
        {
            if (gISModelFile == null || builidng2D == null)
            {
                return null;
            }
            string reference = builidng2D.Reference;
            if (string.IsNullOrWhiteSpace(reference))
            {
                return null;
            }

            Dictionary<string, YearBuiltData> dictionary = YearBuiltDataDictionary<YearBuiltData>(gISModelFile, new string[] { reference });
            if(dictionary == null || !dictionary.TryGetValue(reference, out YearBuiltData yearBuiltData) || yearBuiltData == null)
            {
                return null;
            }

            return yearBuiltData.Year;


            //string path = gISModelFile.Path;
            //if (string.IsNullOrWhiteSpace(path))
            //{
            //    return null;
            //}

            //string directory = System.IO.Path.GetDirectoryName(path);
            //if (!System.IO.Directory.Exists(directory))
            //{
            //    return null;
            //}

            //path = System.IO.Path.Combine(directory, string.Format("{0}.{1}", System.IO.Path.GetFileNameWithoutExtension(path), Constans.FileExtension.YearBuiltDataFile));

            //if (!System.IO.File.Exists(path))
            //{
            //    return null;
            //}

            //using (YearBuiltDataFile yearBuiltDataFile = new YearBuiltDataFile(path))
            //{
            //    yearBuiltDataFile.Open();

            //    UniqueReference uniqueReference = YearBuiltDataFile.GetUniqueReference<YearBuiltData>(reference);
            //    if (uniqueReference == null)
            //    {
            //        return null;
            //    }

            //    YearBuiltData yearBuiltData = yearBuiltDataFile.GetValue<YearBuiltData>(uniqueReference);
            //    if (yearBuiltData == null)
            //    {
            //        return null;
            //    }

            //    return yearBuiltData.Year;
            //}
        }
    }
}







