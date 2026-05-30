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
        public override UniqueReference? GetUniqueReference(StatisticalDataCollection? statisticalDataCollection)
        {
            return GetUniqueReference(statisticalDataCollection?.Code);
        }

        /// <summary>
        /// Gets the unique reference for the given reference string
        /// </summary>
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
        public StatisticalDataCollectionFile(StatisticalDataCollectionFile? statisticalDataCollectionFile)
            : base(statisticalDataCollectionFile)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StatisticalDataCollectionFile class from a JSON object
        /// </summary>
        public StatisticalDataCollectionFile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StatisticalDataCollectionFile class from the specified path
        /// </summary>
        public StatisticalDataCollectionFile(string? path)
            : base(path)
        {
        }
    }
}