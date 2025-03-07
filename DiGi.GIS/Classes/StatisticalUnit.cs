using DiGi.GIS.Enums;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public class StatisticalUnit : GISGuidObject2D
    {
        [JsonIgnore]
        private Dictionary<string, StatisticalUnit> dictionary;

        [JsonInclude, JsonPropertyName("Name")]
        private string name;
        
        [JsonInclude, JsonPropertyName("StatisticalUnitType")]
        private StatisticalUnitType statisticalUnitType;

        public StatisticalUnit(Guid guid, string reference, string name, StatisticalUnitType statisticalUnitType, IEnumerable<StatisticalUnit> statisticalUnits)
            : base(guid, reference)
        {
            this.name = name;
            this.statisticalUnitType = statisticalUnitType;
            StatisticalUnits = statisticalUnits;
        }

        public StatisticalUnit(StatisticalUnit statisticalUnit)
            : base(statisticalUnit)
        {
            if(statisticalUnit != null)
            {
                name = statisticalUnit.name;
                statisticalUnitType = statisticalUnit.statisticalUnitType;
                StatisticalUnits = statisticalUnit.StatisticalUnits;
            }
        }

        public StatisticalUnit(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        [JsonIgnore]
        public string Name
        {
            get
            {
                return name;
            }
        }

        [JsonInclude, JsonPropertyName("StatisticalUnits")]
        public IEnumerable<StatisticalUnit> StatisticalUnits
        {
            get
            {
                return dictionary?.Values;
            }

            private set
            {
                if(value == null)
                {
                    dictionary = null;
                    return;
                }

                dictionary = new Dictionary<string, StatisticalUnit>();
                foreach (StatisticalUnit statisticalUnit in value)
                {
                    if(statisticalUnit?.Reference == null)
                    {
                        continue;
                    }

                    dictionary[statisticalUnit.Reference] = statisticalUnit;
                }
            }
        }
        
        [JsonIgnore]
        public StatisticalUnitType StatisticalUnitType
        {
            get
            {
                return statisticalUnitType;
            }
        }
    }
}
