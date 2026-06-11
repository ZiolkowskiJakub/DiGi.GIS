using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Provides the base options used for data extraction processes.
    /// </summary>
    public abstract class ExtractOptions : SerializableOptions, IExtractOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractOptions"/> class.
        /// </summary>
        public ExtractOptions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractOptions"/> class using an existing options object.
        /// </summary>
        /// <param name="extractOptions">The source extraction options to copy from.</param>
        public ExtractOptions(ExtractOptions? extractOptions)
            : base(extractOptions)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractOptions"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the option values.</param>
        public ExtractOptions(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}