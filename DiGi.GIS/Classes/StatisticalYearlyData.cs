using DiGi.GIS.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Provides a base class for statistical data organized by year
    /// </summary>
    /// <typeparam name="T">The type of the value associated with each year.</typeparam>
    public abstract class StatisticalYearlyData<T> : StatisticalData, IStatisticalYearlyData<T>
    {
        [JsonInclude, JsonPropertyName("Values")]
        private readonly SortedDictionary<short, T> sortedDictionary = [];

        /// <summary>
        /// Initializes a new instance of the StatisticalYearlyData class with the specified name and reference
        /// </summary>
        /// <param name="name">The name of the statistical data.</param>
        /// <param name="reference">The reference identifier for the statistical data.</param>
        public StatisticalYearlyData(string? name, string? reference)
            : base(name, reference)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StatisticalYearlyData class with the specified name, reference, and values
        /// </summary>
        /// <param name="name">The name of the statistical data.</param>
        /// <param name="reference">The reference identifier for the statistical data.</param>
        /// <param name="values">A collection of key-value pairs where the key is the year and the value is the data for that year.</param>
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
        /// <param name="statisticalYearlyData">The source instance to copy from.</param>
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
        /// <param name="jsonObject">The JSON object containing the statistical yearly data.</param>
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
        /// <param name="year">The year for which to get or set the value.</param>
        /// <returns>The value associated with the specified year, or the default value of <typeparamref name="T"/> if not found.</returns>
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
        /// <param name="year">The year to look for.</param>
        /// <param name="value">When this method returns, contains the value associated with the specified year if found; otherwise, the default value of <typeparamref name="T"/>.</param>
        /// <returns>True if the specified year was found in the data; otherwise, false.</returns>
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
        /// <param name="year">The year whose value should be removed.</param>
        /// <returns>True if the value for the specified year was successfully removed; otherwise, false.</returns>
        public bool Remove(short year)
        {
            return sortedDictionary.Remove(year);
        }
    }
}