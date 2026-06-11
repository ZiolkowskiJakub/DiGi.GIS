using DiGi.Core.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Provides options for specifying directory names.
    /// </summary>
    public abstract class DirectoryNamesOptions : SerializableOptions
    {
        /// <summary>
        /// Gets or sets the array of directory names.
        /// </summary>
        [JsonInclude, JsonPropertyName("DirectoryNames")]
        public string[]? DirectoryNames { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryNamesOptions"/> class.
        /// </summary>
        public DirectoryNamesOptions()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryNamesOptions"/> class based on an existing <see cref="DirectoryNamesOptions"/> instance.
        /// </summary>
        /// <param name="directoryNamesOptions">The source options to copy from.</param>
        public DirectoryNamesOptions(DirectoryNamesOptions? directoryNamesOptions)
            : base(directoryNamesOptions)
        {
            if (directoryNamesOptions != null)
            {
                DirectoryNames = (string[]?)directoryNamesOptions.DirectoryNames?.Clone();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryNamesOptions"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the options data.</param>
        public DirectoryNamesOptions(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}