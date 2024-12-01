using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public class GISModelFile : Core.IO.File.Classes.ValueFile<GISModel>, IGISObject
    {
        public GISModelFile(GISModelFile gISModelFile)
            : base(gISModelFile)
        {

        }

        public GISModelFile(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public GISModelFile(string path)
            : base(path) 
        {
            
        }
    }
}