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
        public UnitCode(string? code)
        {
            this.code = code;
        }

        /// <summary>
        /// Initializes a new instance of the UnitCode class by copying another instance
        /// </summary>
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
        public override ISerializableObject Clone()
        {
            return new UnitCode(code);
        }

        /// <summary>
        /// Determines whether the specified object equals this unit code
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj?.ToString() == code;
        }

        /// <summary>
        /// Returns the hash code for this unit code
        /// </summary>
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
        public override string? ToString()
        {
            return code?.ToString();
        }
    }
}