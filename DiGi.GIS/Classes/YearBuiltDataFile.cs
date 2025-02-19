using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public class YearBuiltDataFile : Core.IO.File.Classes.StorageFile<IYearBuiltData>, IGISObject
    {
        public YearBuiltDataFile(YearBuiltDataFile yearBuiltDataFile)
            : base(yearBuiltDataFile)
        {

        }

        public YearBuiltDataFile(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public YearBuiltDataFile(string path)
            : base(path) 
        {
            
        }
    }
}