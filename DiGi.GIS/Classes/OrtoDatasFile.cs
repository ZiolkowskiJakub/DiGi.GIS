using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public class OrtoDatasFile : Core.IO.File.Classes.StorageFile<OrtoDatas>, IGISObject
    {
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