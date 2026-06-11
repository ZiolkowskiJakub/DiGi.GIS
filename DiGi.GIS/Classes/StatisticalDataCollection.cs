using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a collection of statistical data associated with a specific unit code and identifier.
    /// </summary>
    public class StatisticalDataCollection : GuidObject, IGISGuidObject2D
    {
        [JsonIgnore]
        private readonly Dictionary<string, IStatisticalData> dictionary = [];

        [JsonIgnore]
        private UnitCode? unitCode = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticalDataCollection"/> class with a specified identifier, unit code, and initial statistical data.
        /// </summary>
        /// <param name="guid">The unique identifier for the collection.</param>
        /// <param name="unitCode">The unit code associated with this collection.</param>
        /// <param name="statisticalDatas">An optional sequence of statistical data items to populate the collection.</param>
        public StatisticalDataCollection(Guid guid, UnitCode? unitCode, IEnumerable<IStatisticalData>? statisticalDatas)
            : base(guid)
        {
            this.unitCode = Core.Query.Clone(unitCode);
            StatisticalDatas = statisticalDatas;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticalDataCollection"/> class with a specified identifier and unit code.
        /// </summary>
        /// <param name="guid">The unique identifier for the collection.</param>
        /// <param name="unitCode">The unit code associated with this collection.</param>
        public StatisticalDataCollection(Guid guid, UnitCode? unitCode)
            : base(guid)
        {
            this.unitCode = Core.Query.Clone(unitCode);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticalDataCollection"/> class by copying another collection.
        /// </summary>
        /// <param name="statisticalDataCollection">The source collection to copy from.</param>
        public StatisticalDataCollection(StatisticalDataCollection? statisticalDataCollection)
            : base(statisticalDataCollection == null ? Guid.Empty : statisticalDataCollection.Guid)
        {
            if (statisticalDataCollection != null)
            {
                unitCode = Core.Query.Clone(statisticalDataCollection.unitCode);
                StatisticalDatas = statisticalDataCollection.StatisticalDatas;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticalDataCollection"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the collection data.</param>
        public StatisticalDataCollection(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the code associated with the unit code of this collection.
        /// </summary>
        [JsonInclude, JsonPropertyName("Code")]
        public string? Code
        {
            get
            {
                return unitCode?.Code;
            }

            set
            {
                unitCode = Create.UnitCode(value);
            }
        }

        /// <summary>
        /// Gets the names of all statistical data items currently stored in the collection.
        /// </summary>
        [JsonIgnore]
        public IEnumerable<string> Names
        {
            get
            {
                return dictionary.Keys;
            }
        }

        /// <summary>
        /// Gets or sets the sequence of statistical data items contained in this collection.
        /// </summary>
        [JsonInclude, JsonPropertyName("StatisticalDatas")]
        public IEnumerable<IStatisticalData>? StatisticalDatas
        {
            get
            {
                return dictionary.Values;
            }

            private set
            {
                dictionary.Clear();
                if (value == null)
                {
                    return;
                }

                foreach (IStatisticalData statisticalData in value)
                {
                    if (statisticalData.Name == null)
                    {
                        continue;
                    }

                    dictionary[statisticalData.Name] = statisticalData;
                }
            }
        }

        /// <summary>
        /// Gets the unit code associated with this collection.
        /// </summary>
        [JsonIgnore]
        public UnitCode? UnitCode
        {
            get
            {
                return Core.Query.Clone(unitCode);
            }
        }

        /// <summary>
        /// Gets the statistical data item associated with the specified name.
        /// </summary>
        /// <param name="name">The name of the statistical data item to retrieve.</param>
        /// <returns>The matching <see cref="IStatisticalData"/> if found; otherwise, null.</returns>
        [JsonIgnore]
        public IStatisticalData? this[string name]
        {
            get
            {
                if (!dictionary.TryGetValue(name, out IStatisticalData result))
                {
                    return null;
                }

                return result;
            }
        }

        /// <summary>
        /// Adds a statistical data item to the collection.
        /// </summary>
        /// <param name="statisticalData">The statistical data item to add.</param>
        /// <returns>True if the item was successfully added; false if the item is null or has no name.</returns>
        public bool Add(IStatisticalData? statisticalData)
        {
            if (statisticalData?.Name == null)
            {
                return false;
            }

            dictionary[statisticalData.Name] = statisticalData;
            return true;
        }

        /// <summary>
        /// Determines whether the collection contains a statistical data item with the specified name.
        /// </summary>
        /// <param name="name">The name of the item to locate.</param>
        /// <returns>True if an item with the specified name exists; otherwise, false.</returns>
        public bool Contains(string name)
        {
            return dictionary.ContainsKey(name);
        }

        /// <summary>
        /// Searches for a statistical data item of a specific type that satisfies the provided predicate.
        /// </summary>
        /// <typeparam name="TStatisticalData">The type of statistical data to search for.</typeparam>
        /// <param name="func">A predicate function used to test each element for a match.</param>
        /// <returns>The first item that matches the criteria, or the default value if no match is found or the predicate is null.</returns>
        public TStatisticalData? Find<TStatisticalData>(Func<TStatisticalData?, bool>? func) where TStatisticalData : IStatisticalData
        {
            if (func == null)
            {
                return default;
            }

            foreach (IStatisticalData statisticalData in dictionary.Values)
            {
                if (statisticalData is TStatisticalData statisticalData_Temp)
                {
                    if (func.Invoke(statisticalData_Temp))
                    {
                        return statisticalData_Temp;
                    }
                }
            }

            return default;
        }

        /// <summary>
        /// Retrieves the statistical data item associated with the specified name.
        /// </summary>
        /// <param name="name">The name of the statistical data item to retrieve.</param>
        /// <returns>The matching <see cref="IStatisticalData"/> if found; otherwise, null.</returns>
        public IStatisticalData? GetStatisticalData(string? name)
        {
            if (!TryGetStatisticalData(name, out IStatisticalData? statisticalData))
            {
                return null;
            }

            return statisticalData;
        }

        /// <summary>
        /// Retrieves all statistical data items in the collection that are of a specific type.
        /// </summary>
        /// <typeparam name="UStatisticalData">The type of statistical data to filter by.</typeparam>
        /// <returns>A sequence containing all items of the specified type.</returns>
        public IEnumerable<UStatisticalData> GetStatisticalDatas<UStatisticalData>() where UStatisticalData : IStatisticalData
        {
            List<UStatisticalData> result = [];
            foreach (IStatisticalData statisticalData in dictionary.Values)
            {
                if (statisticalData is UStatisticalData statisticalData_Temp)
                {
                    result.Add(statisticalData_Temp);
                }
            }

            return result;
        }

        /// <summary>
        /// Removes the statistical data item with the specified name from the collection.
        /// </summary>
        /// <param name="name">The name of the item to remove.</param>
        /// <returns>True if the item was successfully removed; false if the name is null or the item does not exist.</returns>
        public bool Remove(string? name)
        {
            if (name is null)
            {
                return false;
            }

            return dictionary.Remove(name);
        }

        /// <summary>
        /// Attempts to retrieve a statistical data item by its name.
        /// </summary>
        /// <param name="name">The name of the item to search for.</param>
        /// <param name="statisticalData">When this method returns, contains the found item if successful; otherwise, null.</param>
        /// <returns>True if the item was found; otherwise, false.</returns>
        public bool TryGetStatisticalData(string? name, out IStatisticalData? statisticalData)
        {
            statisticalData = null;

            if (name == null)
            {
                return false;
            }

            if (!dictionary.TryGetValue(name, out statisticalData))
            {
                return false;
            }

            return true;
        }
    }
}