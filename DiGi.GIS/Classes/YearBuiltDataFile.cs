using DiGi.Core.Classes;
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
            : base(jsonObject)
        {

        }

        public YearBuiltDataFile(string path)
            : base(path)
        {

        }

        public static UniqueReference GetUniqueReference<UYearBuiltData>(string reference) where UYearBuiltData : IYearBuiltData
        {
            return GetUniqueReference(typeof(UYearBuiltData), reference);
        }

        public override UniqueReference GetUniqueReference(IYearBuiltData yearBuiltData)
        {
            return GetUniqueReference(yearBuiltData?.GetType(), yearBuiltData.Reference);
        }

        public UYearBuiltData GetValue<UYearBuiltData>(string reference) where UYearBuiltData : IYearBuiltData
        {
            UniqueReference uniqueReference = GetUniqueReference<UYearBuiltData>(reference);
            if(uniqueReference == null)
            {
                return default;
            }

            return GetValue<UYearBuiltData>(uniqueReference);
        }
        
        private static UniqueReference GetUniqueReference(System.Type type, string reference)
        {
            if (string.IsNullOrWhiteSpace(reference) || type == null)
            {
                return null;
            }

            return new UniqueIdReference(type, reference);
        }
    }
}