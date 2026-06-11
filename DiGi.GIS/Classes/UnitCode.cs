using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.GIS.Enums;
using DiGi.GIS.Interfaces;
using System;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a statistical unit code with hierarchical location identification
    /// </summary>
    public class UnitCode : SerializableObject, IGISObject
    {
        [JsonInclude, JsonPropertyName("Code")]
        private readonly string? code;

        /// <summary>
        /// Initializes a new instance of the UnitCode class with the specified code
        /// </summary>
        /// <param name="code">The unit code string to assign.</param>
        public UnitCode(string? code)
        {
            this.code = code;
        }

        /// <summary>
        /// Initializes a new instance of the UnitCode class by copying another instance
        /// </summary>
        /// <param name="unitCode">The source unit code instance to copy from.</param>
        public UnitCode(UnitCode? unitCode)
        {
            if (unitCode != null)
            {
                code = unitCode.code;
            }
        }

        /// <summary>
        /// Initializes a new instance of the UnitCode class from a JSON object
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the unit code data.</param>
        public UnitCode(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the code value
        /// </summary>
        [JsonIgnore]
        public string? Code
        {
            get
            {
                return code;
            }
        }

        /// <summary>
        /// Creates a shallow copy of this unit code
        /// </summary>
        /// <returns>A new ISerializableObject instance that is a clone of the current object.</returns>
        public override ISerializableObject Clone()
        {
            return new UnitCode(code);
        }

        /// <summary>
        /// Determines whether the specified object equals this unit code
        /// </summary>
        /// <param name="obj">The object to compare with the current unit code.</param>
        /// <returns>True if the specified object is equal to the current unit code; otherwise, false.</returns>
        public override bool Equals(object? obj)
        {
            return obj?.ToString() == code;
        }

        /// <summary>
        /// Returns the hash code for this unit code
        /// </summary>
        /// <returns>A 32-bit signed integer hash code for the current object.</returns>
        public override int GetHashCode()
        {
            if (code == null)
            {
                return 0;
            }

            return code.GetHashCode();
        }

        /// <summary>
        /// Gets the parent unit code based on the hierarchical structure
        /// </summary>
        /// <returns>The UnitCode of the parent entity if it exists; otherwise, null.</returns>
        public UnitCode? GetParent()
        {
            StatisticalUnitType? statisticalUnitType = GetStatisticalUnitType();
            if (statisticalUnitType == null || !statisticalUnitType.HasValue)
            {
                return null;
            }

            if (statisticalUnitType.Value == 0)
            {
                return null;
            }

            return GetUnitCode(Core.Query.Previous(statisticalUnitType.Value));
        }

        /// <summary>
        /// Gets the prefix of the code by removing trailing zeros
        /// </summary>
        /// <returns>The processed prefix string, or null if the original code is null or whitespace.</returns>
        public string? GetPrefix()
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                return null;
            }

            string? result = code;
            if (string.IsNullOrWhiteSpace(result))
            {
                return result;
            }

            if (result is null)
            {
                return result;
            }

            while (result.EndsWith("0"))
            {
                result = result.Substring(0, result.Length - 1);
            }

            return result;
        }

        /// <summary>
        /// Gets the statistical unit type represented by this code
        /// </summary>
        /// <returns>The StatisticalUnitType associated with the current code, or null if no matching type is found.</returns>
        public StatisticalUnitType? GetStatisticalUnitType()
        {
            Array array = Enum.GetValues(typeof(StatisticalUnitType));

            for (int i = array.Length - 1; i >= 1; i--)
            {
                StatisticalUnitType statisticalUnitType = (StatisticalUnitType)array.GetValue(i);

                UnitCode? unitCode = GetUnitCode(statisticalUnitType);
                if (unitCode != null)
                {
                    return statisticalUnitType;
                }
            }

            return null;
        }

        /// <summary>
        /// Gets the unit code for the specified statistical unit type
        /// </summary>
        /// <param name="statisticalUnitType">The target statistical unit type.</param>
        /// <returns>A UnitCode instance corresponding to the requested type, or null if it cannot be determined.</returns>
        public UnitCode? GetUnitCode(StatisticalUnitType statisticalUnitType)
        {
            if (statisticalUnitType == StatisticalUnitType.statistical_towns)
            {
                return null;
            }

            if (statisticalUnitType == StatisticalUnitType.country)
            {
                return new UnitCode("000000000000");
            }

            int[] counts = [2, 4, 5, 7, 9, 12];

            Array array = Enum.GetValues(typeof(StatisticalUnitType));

            int length = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                int index = i - 1;
                length = counts[index];

                int start = index == 0 ? 0 : counts[index - 1] - 1;

                string? substring = code?.Substring(start, length - start);

                if (substring.All(x => x == '0'))
                {
                    return null;
                }

                if ((StatisticalUnitType)array.GetValue(i) == statisticalUnitType)
                {
                    break;
                }
            }

            return Create.UnitCode(code?.Substring(0, length));
        }

        /// <summary>
        /// Determines whether this code is valid (12 digits)
        /// </summary>
        /// <returns>True if the code consists of exactly 12 numeric digits; otherwise, false.</returns>
        public bool IsValid()
        {
            if (code == null || code.Length != 12)
            {
                return false;
            }

            return code.All(char.IsDigit);
        }

        /// <summary>
        /// Returns the code as a string
        /// </summary>
        /// <returns>The string representation of the unit code.</returns>
        public override string? ToString()
        {
            return code?.ToString();
        }
    }
}