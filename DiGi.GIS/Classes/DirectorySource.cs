using DiGi.GIS.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public class DirectorySource : Source, IDirectorySource
    {
        [JsonInclude, JsonPropertyName("Directory")]
        public string directory;

        public DirectorySource(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public DirectorySource(string directory)
        {
            this.directory = directory;
        }

        public DirectorySource(DirectorySource directorySource)
            :base(directorySource)
        {
            if(directorySource != null)
            {
                directory = directorySource.directory;
            }
        }

        [JsonIgnore]
        public string Directory
        {
            get
            {
                return directory;
            }
        }

    }
}
