using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public abstract class ExtractOptions : SerializableOptions, IExtractOptions
    {
        public ExtractOptions()
        {
        }

        public ExtractOptions(ExtractOptions? extractOptions)
            : base(extractOptions)
        {
        }

        public ExtractOptions(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}