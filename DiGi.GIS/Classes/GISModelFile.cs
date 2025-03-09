using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public class StatisticalUnitFile : Core.IO.File.Classes.ValueFile<StatisticalUnit>, IGISObject
    {
        public StatisticalUnitFile(StatisticalUnitFile statisticalUnitFile)
            : base(statisticalUnitFile)
        {

        }

        public StatisticalUnitFile(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public StatisticalUnitFile(string path)
            : base(path) 
        {
            
        }
    }
}