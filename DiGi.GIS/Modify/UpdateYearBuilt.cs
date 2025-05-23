﻿using DiGi.Core.Classes;
using DiGi.GIS.Classes;

namespace DiGi.GIS
{
    public static partial class Modify
    {
        public static UniqueReference UpdateYearBuilt(this GISModelFile gISModelFile, Building2D builidng2D, short? yearBuilt)
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

            path = System.IO.Path.Combine(directory, string.Format("{0}.{1}", System.IO.Path.GetFileNameWithoutExtension(path), Constans.FileExtension.YearBuiltDataFile));

            UniqueReference uniqueReference = null;

            using (YearBuiltDataFile yearBuiltDataFile = new YearBuiltDataFile(path))
            {
                yearBuiltDataFile.Open();

                
                if (yearBuilt != null && yearBuilt.HasValue)
                {
                    YearBuiltData yearBuiltData = new YearBuiltData(builidng2D.Reference, yearBuilt.Value);
                    uniqueReference = yearBuiltDataFile.AddValue(yearBuiltData);
                }
                else
                {
                    UniqueReference uniqueReference_Temp = YearBuiltDataFile.GetUniqueReference<YearBuiltData>(reference);
                    if(uniqueReference_Temp != null && yearBuiltDataFile.Remove(uniqueReference_Temp))
                    {
                        uniqueReference = uniqueReference_Temp;
                    }
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
