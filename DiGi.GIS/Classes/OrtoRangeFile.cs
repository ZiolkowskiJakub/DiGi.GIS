using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public class OrtoRangeFile : Core.IO.File.Classes.StorageFile<OrtoRange>, IGISObject
    {
        public override UniqueReference GetUniqueReference(OrtoRange ortoRange)
        {
            return GetUniqueReference(ortoRange?.UniqueId);
        }

        public static UniqueReference GetUniqueReference(string reference)
        {
            if(reference == null)
            {
                return null;
            }

            return new UniqueIdReference(typeof(OrtoRange), reference);
        }

        public OrtoRangeFile(OrtoRangeFile ortoRangeFile)
            : base(ortoRangeFile)
        {

        }

        public OrtoRangeFile(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public OrtoRangeFile(string path)
            : base(path) 
        {
            
        }
    }
}