using DiGi.Core.Classes;
using DiGi.GIS.Enums;
using DiGi.GIS.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a statistical unit within the GIS system, providing hierarchical organization and identification via unit codes.
    /// </summary>
    public class StatisticalUnit : GuidObject, IGISObject
    {
        [JsonIgnore]
        private Dictionary<string, StatisticalUnit>? dictionary;

        [JsonInclude, JsonPropertyName("Name")]
        private readonly string? name;

        [JsonIgnore]
        private UnitCode? unitCode;

        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticalUnit"/> class.
        /// </summary>
        /// <param name="guid">The unique identifier for the statistical unit.</param>
        /// <param name="unitCode">The code associated with the statistical unit.</param>
        /// <param name="name">The descriptive name of the statistical unit.</param>
        /// <param name="statisticalUnits">A collection of child statistical units.</param>
        public StatisticalUnit(Guid guid, UnitCode? unitCode, string? name, IEnumerable<StatisticalUnit>? statisticalUnits)
            : base(guid)
        {
            this.name = name;
            this.unitCode = Core.Query.Clone(unitCode);
            StatisticalUnits = statisticalUnits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticalUnit"/> class by copying another statistical unit.
        /// </summary>
        /// <param name="statisticalUnit">The source statistical unit to copy from.</param>
        public StatisticalUnit(StatisticalUnit? statisticalUnit)
            : base(statisticalUnit)
        {
            if (statisticalUnit != null)
            {
                name = statisticalUnit.name;
                StatisticalUnits = statisticalUnit.StatisticalUnits;
                unitCode = Core.Query.Clone(statisticalUnit.unitCode);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticalUnit"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the statistical unit data.</param>
        public StatisticalUnit(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the code of the statistical unit.
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
        /// Gets the name of the statistical unit.
        /// </summary>
        [JsonIgnore]
        public string? Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Gets the collection of child statistical units associated with this unit.
        /// </summary>
        [JsonInclude, JsonPropertyName("StatisticalUnits")]
        public IEnumerable<StatisticalUnit>? StatisticalUnits
        {
            get
            {
                return dictionary?.Values;
            }

            private set
            {
                if (value == null)
                {
                    dictionary = null;
                    return;
                }

                dictionary = [];
                foreach (StatisticalUnit statisticalUnit in value)
                {
                    if (statisticalUnit?.Code == null)
                    {
                        continue;
                    }

                    dictionary[statisticalUnit.Code] = statisticalUnit;
                }
            }
        }

        /// <summary>
        /// Gets the unit code associated with this statistical unit.
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
        /// Retrieves a collection of statistical units, optionally including nested children and filtered by a predicate.
        /// </summary>
        /// <param name="includeNested">If set to <c>true</c>, recursively includes all child statistical units.</param>
        /// <param name="func">An optional filter function to determine which units should be included in the result.</param>
        /// <returns>A collection of matching <see cref="StatisticalUnit"/> objects, or null if no dictionary exists.</returns>
        public IEnumerable<StatisticalUnit>? GetStatisticalUnits(bool includeNested, Func<StatisticalUnit?, bool>? func = null)
        {
            if (dictionary is null)
            {
                return null;
            }

            List<StatisticalUnit> result = [];
            foreach (StatisticalUnit statisticalUnit in dictionary.Values)
            {
                if (includeNested)
                {
                    IEnumerable<StatisticalUnit>? statisticalUnits_Nested = statisticalUnit.GetStatisticalUnits(includeNested, func);
                    if (statisticalUnits_Nested != null)
                    {
                        foreach (StatisticalUnit statisticalUnit_Nested in statisticalUnits_Nested)
                        {
                            result.Add(statisticalUnit_Nested);
                        }
                    }
                }

                if (func != null && !func.Invoke(statisticalUnit))
                {
                    continue;
                }

                result.Add(statisticalUnit);
            }

            return result;
        }

        /// <summary>
        /// Gets the statistical unit type based on the current unit code.
        /// </summary>
        /// <returns>The <see cref="StatisticalUnitType"/> of this unit, or null if the unit code is not defined.</returns>
        public StatisticalUnitType? GetStatisticalUnitType()
        {
            return unitCode?.GetStatisticalUnitType();
        }

        /// <summary>
        /// Searches for a statistical unit that matches the specified unit code.
        /// </summary>
        /// <param name="unitCode">The unit code to search for.</param>
        /// <param name="includeNested">If set to <c>true</c>, searches recursively through child units.</param>
        /// <returns>The matching <see cref="StatisticalUnit"/> if found; otherwise, null.</returns>
        public StatisticalUnit? Find(UnitCode? unitCode, bool includeNested)
        {
            if (unitCode == null)
            {
                return null;
            }

            string? prefix = unitCode.GetPrefix();

            if (this.unitCode == unitCode)
            {
                return this;
            }

            IEnumerable<StatisticalUnit>? statisticalUnits = StatisticalUnits;
            if (statisticalUnits == null)
            {
                return null;
            }

            foreach (StatisticalUnit statisticalUnit in statisticalUnits)
            {
                string? prefix_StatisticalUnit = statisticalUnit?.UnitCode?.GetPrefix();

                if (prefix_StatisticalUnit == prefix)
                {
                    return statisticalUnit;
                }

                if (includeNested && prefix is not null && prefix.StartsWith(prefix_StatisticalUnit))
                {
                    StatisticalUnit? statisticalUnit_Nested = statisticalUnit?.Find(unitCode, includeNested);
                    if (statisticalUnit_Nested != null)
                    {
                        return statisticalUnit_Nested;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Returns a string representation of the statistical unit, combining its code and name.
        /// </summary>
        /// <returns>A formatted string containing the unit's code and name.</returns>
        public override string? ToString()
        {
            return string.Format("{0}: {1}", string.IsNullOrWhiteSpace(unitCode?.Code) ? "???" : unitCode!.Code, string.IsNullOrWhiteSpace(name) ? "???" : name);
        }
    }
}