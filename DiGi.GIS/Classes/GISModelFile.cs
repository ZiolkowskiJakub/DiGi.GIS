using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;
using System.Collections.Generic;

namespace DiGi.GIS.Classes
{
    public class GISModelFile : Core.IO.File.Classes.File<GISModel>, IGISObject
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