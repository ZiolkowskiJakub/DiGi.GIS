using DiGi.GIS.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public abstract class StatisticalYearlyData<T> : StatisticalData, IStatisticalYearlyData<T>
    {
        [JsonInclude, JsonPropertyName("Values")]
        private SortedDictionary<short, T> sortedDictionary = new SortedDictionary<short, T>();

        public StatisticalYearlyData(string name, string reference)
            : base(name, reference)
        {

        }

        public StatisticalYearlyData(string name, string reference, IEnumerable<KeyValuePair<short, T>> values)
            : base(name, reference)
        {
            if(values != null)
            {
                foreach(KeyValuePair<short, T> keyValuePair in values)
                {
                    sortedDictionary[keyValuePair.Key] = keyValuePair.Value;
                }
            }
        }

        public StatisticalYearlyData(StatisticalYearlyData<T> statisticalYearlyData)
            : base(statisticalYearlyData)
        {
            if (statisticalYearlyData != null)
            {
                if(statisticalYearlyData.sortedDictionary != null)
                {
                    foreach(KeyValuePair<short, T> keyValuePair in statisticalYearlyData.sortedDictionary)
                    {
                        sortedDictionary[keyValuePair.Key] = keyValuePair.Value;
                    }
                }
            }
        }

        public StatisticalYearlyData(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public IEnumerable<short> Years
        {
            get
            {
                return sortedDictionary.Keys;
            }
        }

        public T this[short year]
        {
            get
            {
                if(!sortedDictionary.TryGetValue(year, out T result))
                {
                    return default;
                }

                return result;
            }

            set
            {
                sortedDictionary[year] = value;
            }
        }

        public bool TryGetValue(short year, out T value)
        {
            return sortedDictionary.TryGetValue(year, out value);
        }

        public void Clear()
        {
            sortedDictionary.Clear();
        }

        public bool Remove(short year)
        {
            return sortedDictionary.Remove(year);
        }
    }
}
