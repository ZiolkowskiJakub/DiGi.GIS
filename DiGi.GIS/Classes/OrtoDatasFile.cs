using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a storage file for orthodata information, providing functionality to manage and reference orthodata files.
    /// </summary>
    public class OrtoDatasFile : Core.IO.File.Classes.StorageFile<OrtoDatas>, IGISObject
    {
        /// <summary>
        /// Gets the unique reference associated with the specified orthodata object.
        /// </summary>
        /// <param name="ortoDatas">The orthodata object for which to retrieve the unique reference.</param>
        /// <returns>A <see cref="UniqueReference"/> if the orthodata is provided; otherwise, null.</returns>
        public override UniqueReference? GetUniqueReference(OrtoDatas? ortoDatas)
        {
            return GetUniqueReference(ortoDatas?.Reference);
        }

        /// <summary>
        /// Creates a unique reference based on the provided string identifier.
        /// </summary>
        /// <param name="reference">The string identifier used to create the unique reference.</param>
        /// <returns>A <see cref="UniqueReference"/> if the reference is not null; otherwise, null.</returns>
        public static UniqueReference? GetUniqueReference(string? reference)
        {
            if (reference == null)
            {
                return null;
            }

            return new UniqueIdReference(typeof(OrtoDatas), reference);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoDatasFile"/> class by copying an existing instance.
        /// </summary>
        /// <param name="ortoDatasFile">The source <see cref="OrtoDatasFile"/> instance to copy from.</param>
        public OrtoDatasFile(OrtoDatasFile? ortoDatasFile)
            : base(ortoDatasFile)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoDatasFile"/> class using data from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the file data.</param>
        public OrtoDatasFile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoDatasFile"/> class using the specified file path.
        /// </summary>
        /// <param name="path">The system path to the orthodata storage file.</param>
        public OrtoDatasFile(string? path)
            : base(path)
        {
        }
    }
}