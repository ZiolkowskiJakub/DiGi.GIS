using DiGi.Core.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public abstract class DirectoryNamesOptions : Options
    {
        [JsonInclude, JsonPropertyName("DirectoryNames")]
        public string[] DirectoryNames { get; set; }

        public DirectoryNamesOptions()
            : base()
        {

        }

        public DirectoryNamesOptions(DirectoryNamesOptions directoryNamesOptions)
            : base(directoryNamesOptions)
        {
            if(directoryNamesOptions != null)
            {
                DirectoryNames = (string[])directoryNamesOptions.DirectoryNames?.Clone();
            }
        }

        public DirectoryNamesOptions(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}

