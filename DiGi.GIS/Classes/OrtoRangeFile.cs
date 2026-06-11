using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a file storage object specifically for OrtoRange data, providing functionality to manage and reference OrtoRange files.
    /// </summary>
    public class OrtoRangeFile : Core.IO.File.Classes.StorageFile<OrtoRange>, IGISObject
    {
        /// <summary>
        /// Gets the unique reference for the specified OrtoRange object.
        /// </summary>
        /// <param name="ortoRange">The OrtoRange object to retrieve the unique reference from.</param>
        /// <returns>A <see cref="UniqueReference"/> associated with the OrtoRange object, or null if the provided object is null.</returns>
        public override UniqueReference? GetUniqueReference(OrtoRange? ortoRange)
        {
            return GetUniqueReference(ortoRange?.UniqueId);
        }

        /// <summary>
        /// Gets the unique reference based on a string identifier.
        /// </summary>
        /// <param name="reference">The string identifier used to create the unique reference.</param>
        /// <returns>A <see cref="UniqueReference"/> created from the provided string, or null if the reference is null.</returns>
        public static UniqueReference? GetUniqueReference(string? reference)
        {
            if (reference == null)
            {
                return null;
            }

            return new UniqueIdReference(typeof(OrtoRange), reference);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoRangeFile"/> class by copying an existing OrtoRangeFile instance.
        /// </summary>
        /// <param name="ortoRangeFile">The source <see cref="OrtoRangeFile"/> instance to copy from.</param>
        public OrtoRangeFile(OrtoRangeFile? ortoRangeFile)
            : base(ortoRangeFile)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoRangeFile"/> class using data from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the file information.</param>
        public OrtoRangeFile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoRangeFile"/> class using a specified file path.
        /// </summary>
        /// <param name="path">The system path to the OrtoRange file.</param>
        public OrtoRangeFile(string path)
            : base(path)
        {
        }
    }
}