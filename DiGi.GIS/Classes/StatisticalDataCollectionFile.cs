using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a file for storing and loading statistical data collections
    /// </summary>
    public class StatisticalDataCollectionFile : Core.IO.File.Classes.StorageFile<StatisticalDataCollection>, IGISObject
    {
        /// <summary>
        /// Gets the unique reference for the given statistical data collection
        /// </summary>
        /// <param name="statisticalDataCollection">The statistical data collection to retrieve the unique reference for.</param>
        /// <returns>The unique reference associated with the statistical data collection, or null if the provided collection is null.</returns>
        public override UniqueReference? GetUniqueReference(StatisticalDataCollection? statisticalDataCollection)
        {
            return GetUniqueReference(statisticalDataCollection?.Code);
        }

        /// <summary>
        /// Gets the unique reference for the given reference string
        /// </summary>
        /// <param name="reference">The reference string used to create the unique reference.</param>
        /// <returns>A new UniqueReference instance based on the provided string, or null if the reference is null.</returns>
        public static UniqueReference? GetUniqueReference(string? reference)
        {
            if (reference == null)
            {
                return null;
            }

            return new UniqueIdReference(typeof(StatisticalDataCollection), reference);
        }

        /// <summary>
        /// Initializes a new instance of the StatisticalDataCollectionFile class by copying another instance
        /// </summary>
        /// <param name="statisticalDataCollectionFile">The source file instance to copy from.</param>
        public StatisticalDataCollectionFile(StatisticalDataCollectionFile? statisticalDataCollectionFile)
            : base(statisticalDataCollectionFile)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StatisticalDataCollectionFile class from a JSON object
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data for the file.</param>
        public StatisticalDataCollectionFile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StatisticalDataCollectionFile class from the specified path
        /// </summary>
        /// <param name="path">The file system path to the statistical data collection file.</param>
        public StatisticalDataCollectionFile(string? path)
            : base(path)
        {
        }
    }
}