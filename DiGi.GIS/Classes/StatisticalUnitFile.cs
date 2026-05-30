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
        public GISModelFile(GISModelFile? gISModelFile)
            : base(gISModelFile)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GISModelFile class from a JSON object
        /// </summary>
        public GISModelFile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GISModelFile class from the specified path
        /// </summary>
        public GISModelFile(string? path)
            : base(path)
        {
        }

        /// <summary>
        /// Gets the external reference for this GIS model file
        /// </summary>
        public GuidExternalReference? GuidExternalReference
        {
            get
            {
                return new GuidExternalReference(Path, Value);
            }
        }
    }
}