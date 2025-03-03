using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public class OrtoDatasFile : Core.IO.File.Classes.StorageFile<OrtoDatas>, IGISObject
    {
        public override UniqueReference GetUniqueReference(OrtoDatas ortoDatas)
        {
            return GetUniqueReference(ortoDatas?.Reference);
        }

        public static UniqueReference GetUniqueReference(string reference)
        {
            if(reference == null)
            {
                return null;
            }

            return new UniqueIdReference(typeof(OrtoDatas), reference);
        }

        public OrtoDatasFile(OrtoDatasFile ortoDatasFile)
            : base(ortoDatasFile)
        {

        }

        public OrtoDatasFile(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public OrtoDatasFile(string path)
            : base(path) 
        {
            
        }
    }
}