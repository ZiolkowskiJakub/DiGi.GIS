using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public class StatisticalDataCollectionFile : Core.IO.File.Classes.StorageFile<StatisticalDataCollection>, IGISObject
    {
        public override UniqueReference GetUniqueReference(StatisticalDataCollection statisticalDataCollection)
        {
            return GetUniqueReference(statisticalDataCollection?.Reference);
        }

        public static UniqueReference GetUniqueReference(string reference)
        {
            if(reference == null)
            {
                return null;
            }

            return new UniqueIdReference(typeof(StatisticalDataCollection), reference);
        }

        public StatisticalDataCollectionFile(StatisticalDataCollectionFile statisticalDataCollectionFile)
            : base(statisticalDataCollectionFile)
        {

        }

        public StatisticalDataCollectionFile(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public StatisticalDataCollectionFile(string path)
            : base(path) 
        {
            
        }
    }
}