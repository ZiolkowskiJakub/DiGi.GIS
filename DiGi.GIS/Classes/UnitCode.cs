using System;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.GIS.Enums;
using DiGi.GIS.Interfaces;

namespace DiGi.GIS.Classes
{
    public class UnitCode : SerializableObject, IGISObject
    {
        [JsonInclude, JsonPropertyName("Code")]
        private string code;

        public UnitCode(string code)
        {
            this.code = code;
        }

        public UnitCode(UnitCode unitCode)
        {
            if(unitCode != null)
            {
                code = unitCode.code;
            }
        }

        public UnitCode(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public string Code
        {
            get
            {
                return code;
            }
        }

        public bool IsValid()
        {
            if(code == null || code.Length != 12)
            {
                return false;
            }

            return code.All(char.IsDigit);
        }

        public override ISerializableObject Clone()
        {
            return new UnitCode(code);
        }

        public override bool Equals(object obj)
        {
            return obj?.ToString() == code;
        }

        public override int GetHashCode()
        {
            if(code == null)
            {
                return 0;
            }

            return code.GetHashCode();
        }

        public override string ToString()
        {
            return code?.ToString();
        }

        public UnitCode GetUnitCode(StatisticalUnitType statisticalUnitType)
        {
            if(statisticalUnitType == StatisticalUnitType.statistical_towns)
            {
                return null;
            }

            if (statisticalUnitType == StatisticalUnitType.country)
            {
                return new UnitCode("000000000000");
            }

            int[] counts = new int[] {2, 4, 5, 7, 9, 12 };

            Array array = Enum.GetValues(typeof(StatisticalUnitType));

            int length = 0;
            for(int i = 1; i < array.Length - 1; i++)
            {
                int index = i - 1;
                length = counts[index];

                int start = index == 0 ? 0 : counts[index - 1] - 1;

                string substring = code.Substring(start, length - start);

                if(substring.All(x => x == '0'))
                {
                    return null;
                }

                if((StatisticalUnitType)array.GetValue(i) == statisticalUnitType)
                {                     
                    break;
                }
            }

            return Create.UnitCode(code.Substring(0, length));
        }

        public StatisticalUnitType? GetStatisticalUnitType()
        {
            Array array = Enum.GetValues(typeof(StatisticalUnitType));

            for (int i = array.Length - 1; i >= 1 ; i--)
            {
                StatisticalUnitType statisticalUnitType = (StatisticalUnitType)array.GetValue(i);

                UnitCode unitCode = GetUnitCode(statisticalUnitType);
                if(unitCode != null)
                {
                    return statisticalUnitType;
                }
            }

            return null;
        }

        public UnitCode GetParent()
        {
            StatisticalUnitType? statisticalUnitType = GetStatisticalUnitType();
            if(statisticalUnitType == null || !statisticalUnitType.HasValue)
            {
                return null;
            }

            if(statisticalUnitType.Value == 0)
            {
                return null;
            }

            return GetUnitCode(Core.Query.Previous(statisticalUnitType.Value));
        }

        public string GetPrefix()
        {
            if(string.IsNullOrWhiteSpace(code))
            {
                return null;
            }

            string result = code;
            while(result.EndsWith("0"))
            {
                result = result.Substring(0, result.Length - 1);
            }

            return result;
        }
    }
}
