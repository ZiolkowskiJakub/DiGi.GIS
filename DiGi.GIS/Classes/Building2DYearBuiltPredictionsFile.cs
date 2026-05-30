using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a file storage for Building2DYearBuiltPredictions data
    /// </summary>
    public class Building2DYearBuiltPredictionsFile : Core.IO.File.Classes.StorageFile<Building2DYearBuiltPredictions>, IGISObject
    {
        /// <summary>
        /// Gets the unique reference for the specified building year built predictions
        /// </summary>
        /// <param name="building2DYearBuiltPredictions">The building year built predictions to get the reference for</param>
        public override UniqueReference? GetUniqueReference(Building2DYearBuiltPredictions? building2DYearBuiltPredictions)
        {
            return GetUniqueReference(building2DYearBuiltPredictions?.Reference);
        }

        /// <summary>
        /// Gets the unique reference for the specified reference string
        /// </summary>
        /// <param name="reference">The reference string</param>
        public static UniqueReference? GetUniqueReference(string? reference)
        {
            if (reference == null)
            {
                return null;
            }

            return new UniqueIdReference(typeof(Building2DYearBuiltPredictions), reference);
        }

        /// <summary>
        /// Initializes a new instance of the Building2DYearBuiltPredictionsFile class by copying another instance
        /// </summary>
        /// <param name="building2DYearBuiltPredictionsFile">The instance to copy</param>
        public Building2DYearBuiltPredictionsFile(Building2DYearBuiltPredictionsFile? building2DYearBuiltPredictionsFile)
            : base(building2DYearBuiltPredictionsFile)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Building2DYearBuiltPredictionsFile class from a JSON object
        /// </summary>
        /// <param name="jsonObject">The JSON object to deserialize from</param>
        public Building2DYearBuiltPredictionsFile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Building2DYearBuiltPredictionsFile class with the specified file path
        /// </summary>
        /// <param name="path">The file path</param>
        public Building2DYearBuiltPredictionsFile(string? path)
            : base(path)
        {
        }
    }
}