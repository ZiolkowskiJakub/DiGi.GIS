using DiGi.GIS.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Provides a base class for statistical data organized by year
    /// </summary>
    public abstract class StatisticalYearlyData<T> : StatisticalData, IStatisticalYearlyData<T>
    {
        [JsonInclude, JsonPropertyName("Values")]
        private readonly SortedDictionary<short, T> sortedDictionary = [];

        /// <summary>
        /// Initializes a new instance of the StatisticalYearlyData class with the specified name and reference
        /// </summary>
        public StatisticalYearlyData(string? name, string? reference)
            : base(name, reference)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StatisticalYearlyData class with the specified name, reference, and values
        /// </summary>
        public StatisticalYearlyData(string? name, string? reference, IEnumerable<KeyValuePair<short, T>>? values)
            : base(name, reference)
        {
            if (values != null)
            {
                foreach (KeyValuePair<short, T> keyValuePair in values)
                {
                    sortedDictionary[keyValuePair.Key] = keyValuePair.Value;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the StatisticalYearlyData class by copying another instance
        /// </summary>
        public StatisticalYearlyData(StatisticalYearlyData<T>? statisticalYearlyData)
            : base(statisticalYearlyData)
        {
            if (statisticalYearlyData != null)
            {
                if (statisticalYearlyData.sortedDictionary != null)
                {
                    foreach (KeyValuePair<short, T> keyValuePair in statisticalYearlyData.sortedDictionary)
                    {
                        sortedDictionary[keyValuePair.Key] = keyValuePair.Value;
                    }
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the StatisticalYearlyData class from a JSON object
        /// </summary>
        public StatisticalYearlyData(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets all years available in the data
        /// </summary>
        [JsonIgnore]
        public IEnumerable<short> Years
        {
            get
            {
                return sortedDictionary.Keys;
            }
        }

        /// <summary>
        /// Gets or sets the value for the specified year
        /// </summary>
        public T? this[short year]
        {
            get
            {
                if (!sortedDictionary.TryGetValue(year, out T result))
                {
                    return default;
                }

                return result;
            }

            set
            {
                if (value is null)
                {
                    return;
                }

                sortedDictionary[year] = value;
            }
        }

        /// <summary>
        /// Tries to get the value for the specified year
        /// </summary>
        public bool TryGetValue(short year, out T value)
        {
            return sortedDictionary.TryGetValue(year, out value);
        }

        /// <summary>
        /// Clears all year values
        /// </summary>
        public void Clear()
        {
            sortedDictionary.Clear();
        }

        /// <summary>
        /// Removes the value for the specified year
        /// </summary>
        public bool Remove(short year)
        {
            return sortedDictionary.Remove(year);
        }
    }
}