using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a source that operates from a directory path
    /// </summary>
    public class DirectorySource : Source, IDirectorySource
    {
        [JsonInclude, JsonPropertyName("Directory")]
        public string? directory;

        /// <summary>
        /// Initializes a new instance of the DirectorySource class from a JSON object
        /// </summary>
        public DirectorySource(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DirectorySource class
        /// </summary>
        public DirectorySource(string? directory)
        {
            this.directory = directory;
        }

        /// <summary>
        /// Initializes a new instance of the DirectorySource class as a copy
        /// </summary>
        public DirectorySource(DirectorySource? directorySource)
            : base(directorySource)
        {
            if (directorySource != null)
            {
                directory = directorySource.directory;
            }
        }

        /// <summary>
        /// Directory path
        /// </summary>
        [JsonIgnore]
        public string? Directory
        {
            get
            {
                return directory;
            }
        }
    }
}