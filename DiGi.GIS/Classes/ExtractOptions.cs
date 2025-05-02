using System.Text.Json.Nodes;
using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;

namespace DiGi.GIS.Classes
{
    public abstract class ExtractOptions : Options, IExtractOptions
    {
        public ExtractOptions()
        {

        }

        public ExtractOptions(ExtractOptions extractOptions)
        {

        }

        public ExtractOptions(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

    }
}
