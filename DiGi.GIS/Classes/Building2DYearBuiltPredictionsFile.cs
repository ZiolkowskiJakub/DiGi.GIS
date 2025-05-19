using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public class Building2DYearBuiltPredictionsFile : Core.IO.File.Classes.StorageFile<Building2DYearBuiltPredictions>, IGISObject
    {
        public override UniqueReference GetUniqueReference(Building2DYearBuiltPredictions building2DYearBuiltPredictions)
        {
            return GetUniqueReference(building2DYearBuiltPredictions?.Reference);
        }

        public static UniqueReference GetUniqueReference(string reference)
        {
            if(reference == null)
            {
                return null;
            }

            return new UniqueIdReference(typeof(Building2DYearBuiltPredictions), reference);
        }

        public Building2DYearBuiltPredictionsFile(Building2DYearBuiltPredictionsFile building2DYearBuiltPredictionsFile)
            : base(building2DYearBuiltPredictionsFile)
        {

        }

        public Building2DYearBuiltPredictionsFile(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public Building2DYearBuiltPredictionsFile(string path)
            : base(path) 
        {
            
        }
    }
}