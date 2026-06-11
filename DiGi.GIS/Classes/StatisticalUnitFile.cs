using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a GIS model file that stores GIS model data with external reference support
    /// </summary>
    public class GISModelFile : Core.IO.File.Classes.ValueFile<GISModel>, IGISObject
    {
        /// <summary>
        /// Initializes a new instance of the GISModelFile class by copying another instance
        /// </summary>
        /// <param name="gISModelFile">The source GIS model file to copy from.</param>
        public GISModelFile(GISModelFile? gISModelFile)
            : base(gISModelFile)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GISModelFile class from a JSON object
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data for the GIS model file.</param>
        public GISModelFile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GISModelFile class from the specified path
        /// </summary>
        /// <param name="path">The file system path to the GIS model file.</param>
        public GISModelFile(string? path)
            : base(path)
        {
        }

        /// <summary>
        /// Gets the external reference for this GIS model file
        /// </summary>
        /// <returns>The external reference associated with this GIS model file, or null if not available.</returns>
        public GuidExternalReference? GuidExternalReference
        {
            get
            {
                return new GuidExternalReference(Path, Value);
            }
        }
    }
}