using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a storage file for year built data.
    /// </summary>
    public class YearBuiltDataFile : Core.IO.File.Classes.StorageFile<IYearBuiltData>, IGISObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="YearBuiltDataFile"/> class using another instance.
        /// </summary>
        /// <param name="yearBuiltDataFile">The source instance to copy from.</param>
        public YearBuiltDataFile(YearBuiltDataFile? yearBuiltDataFile)
            : base(yearBuiltDataFile)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="YearBuiltDataFile"/> class using a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing file data.</param>
        public YearBuiltDataFile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="YearBuiltDataFile"/> class using a path.
        /// </summary>
        /// <param name="path">The file system path to the storage file.</param>
        public YearBuiltDataFile(string? path)
            : base(path)
        {
        }

        /// <summary>
        /// Gets the unique reference for a specific type and reference string.
        /// </summary>
        /// <typeparam name="UYearBuiltData">The type of year built data.</typeparam>
        /// <param name="reference">The reference identifier string.</param>
        /// <returns>A <see cref="UniqueReference"/> if successful; otherwise, null.</returns>
        public static UniqueReference? GetUniqueReference<UYearBuiltData>(string? reference) where UYearBuiltData : IYearBuiltData
        {
            return GetUniqueReference(typeof(UYearBuiltData), reference);
        }

        /// <summary>
        /// Gets the unique reference for a specific year built data instance.
        /// </summary>
        /// <param name="yearBuiltData">The year built data object.</param>
        /// <returns>A <see cref="UniqueReference"/> if successful; otherwise, null.</returns>
        public override UniqueReference? GetUniqueReference(IYearBuiltData? yearBuiltData)
        {
            return GetUniqueReference(yearBuiltData?.GetType(), yearBuiltData?.Reference);
        }

        /// <summary>
        /// Gets the value associated with the specified reference.
        /// </summary>
        /// <typeparam name="UYearBuiltData">The type of year built data to retrieve.</typeparam>
        /// <param name="reference">The reference identifier string.</param>
        /// <returns>The retrieved value of type <typeparamref name="UYearBuiltData"/>, or the default value if not found.</returns>
        public UYearBuiltData? GetValue<UYearBuiltData>(string? reference) where UYearBuiltData : IYearBuiltData
        {
            UniqueReference? uniqueReference = GetUniqueReference<UYearBuiltData>(reference);
            if (uniqueReference is null)
            {
                return default;
            }

            return GetValue<UYearBuiltData>(uniqueReference);
        }

        private static UniqueReference? GetUniqueReference(System.Type? type, string? reference)
        {
            if (string.IsNullOrWhiteSpace(reference) || type == null)
            {
                return null;
            }

            return new UniqueIdReference(type, reference);
        }
    }
}