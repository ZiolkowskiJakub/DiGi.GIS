using DiGi.Core.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Stores and manages predicted year built data for buildings, extending SerializableObject
    /// </summary>
    public class Building2DYearBuiltPredictions : SerializableObject
    {
        [JsonInclude, JsonPropertyName("Reference")]
        private readonly string? reference;

        [JsonInclude, JsonPropertyName("YearBuiltPredictions")]
        private readonly SortedDictionary<ushort, YearBuiltPrediction>? yearBuiltPredictions;

        /// <summary>
        /// Initializes a new instance of the Building2DYearBuiltPredictions class with a reference and a collection of year built predictions
        /// </summary>
        /// <param name="reference">An optional reference string</param>
        /// <param name="yearBuiltPredictions">An optional collection of YearBuiltPrediction objects</param>
        public Building2DYearBuiltPredictions(string? reference, IEnumerable<YearBuiltPrediction>? yearBuiltPredictions)
        {
            this.reference = reference;
            if (yearBuiltPredictions != null)
            {
                this.yearBuiltPredictions = [];
                foreach (YearBuiltPrediction yearBuiltPrediction in yearBuiltPredictions)
                {
                    if (Core.Query.Clone(yearBuiltPrediction) is YearBuiltPrediction yearBuiltPrediction_Temp)
                    {
                        this.yearBuiltPredictions[yearBuiltPrediction.Year] = yearBuiltPrediction_Temp;
                    }
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the Building2DYearBuiltPredictions class by copying another instance
        /// </summary>
        /// <param name="building2DYearBuiltPredictions">The instance to copy</param>
        public Building2DYearBuiltPredictions(Building2DYearBuiltPredictions? building2DYearBuiltPredictions)
            : base(building2DYearBuiltPredictions)
        {
            if (building2DYearBuiltPredictions != null)
            {
                reference = building2DYearBuiltPredictions.reference;

                if (building2DYearBuiltPredictions.yearBuiltPredictions != null)
                {
                    yearBuiltPredictions = [];
                    foreach (KeyValuePair<ushort, YearBuiltPrediction> keyValuePair in building2DYearBuiltPredictions.yearBuiltPredictions)
                    {
                        if (Core.Query.Clone(keyValuePair.Value) is YearBuiltPrediction yearBuiltPrediction)
                        {
                            yearBuiltPredictions[keyValuePair.Key] = yearBuiltPrediction;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the Building2DYearBuiltPredictions class from a JSON object
        /// </summary>
        /// <param name="jsonObject">The JSON object to deserialize from</param>
        public Building2DYearBuiltPredictions(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the reference string for this building
        /// </summary>
        [JsonIgnore]
        public string? Reference
        {
            get
            {
                return reference;
            }
        }

        /// <summary>
        /// Gets the list of years that have year built predictions
        /// </summary>
        [JsonIgnore]
        public List<ushort>? Years
        {
            get
            {
                return yearBuiltPredictions?.Keys.ToList();
            }
        }

        /// <summary>
        /// Gets the exact year built prediction for the specified year
        /// </summary>
        /// <param name="year">The year to look up</param>
        public YearBuiltPrediction? this[ushort year]
        {
            get
            {
                if (yearBuiltPredictions == null)
                {
                    return null;
                }

                if (!yearBuiltPredictions.TryGetValue(year, out YearBuiltPrediction yearBuiltPrediction) || yearBuiltPrediction == null)
                {
                    return null;
                }

                return Core.Query.Clone(yearBuiltPrediction);
            }
        }

        /// <summary>
        /// Gets the year built prediction for the specified year, or the nearest lower year prediction if an exact match is not found
        /// </summary>
        /// <param name="year">The year to look up</param>
        public YearBuiltPrediction? GetYearBuiltPrediction(ushort year)
        {
            if (!Core.Query.TryGetLowerValue(yearBuiltPredictions, year, out YearBuiltPrediction? result))
            {
                return null;
            }

            return result;
        }
    }
}