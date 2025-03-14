using DiGi.Core.Classes;
using DiGi.GIS.Enums;
using DiGi.GIS.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public class StatisticalUnit : GuidObject, IGISObject
    {
        [JsonIgnore]
        private Dictionary<string, StatisticalUnit> dictionary;

        [JsonInclude, JsonPropertyName("Name")]
        private string name;

        [JsonIgnore]
        private UnitCode unitCode;

        public StatisticalUnit(Guid guid, UnitCode unitCode, string name, IEnumerable<StatisticalUnit> statisticalUnits)
            : base(guid)
        {
            this.name = name;
            this.unitCode = Core.Query.Clone(unitCode);
            StatisticalUnits = statisticalUnits;
        }

        public StatisticalUnit(StatisticalUnit statisticalUnit)
            : base(statisticalUnit)
        {
            if(statisticalUnit != null)
            {
                name = statisticalUnit.name;
                StatisticalUnits = statisticalUnit.StatisticalUnits;
                unitCode = Core.Query.Clone(statisticalUnit.unitCode);
            }
        }

        public StatisticalUnit(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        [JsonInclude, JsonPropertyName("Code")]
        public string Code
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
                if (value == null)
                {
                    dictionary = null;
                    return;
                }

                dictionary = new Dictionary<string, StatisticalUnit>();
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

        [JsonIgnore]
        public UnitCode UnitCode
        {
            get
            {
                return Core.Query.Clone(unitCode);
            }
        }
        
        public IEnumerable<StatisticalUnit> GetStatisticalUnits(bool includeNested, Func<StatisticalUnit, bool> func = null)
        {
            List<StatisticalUnit> result = new List<StatisticalUnit>();
            foreach (StatisticalUnit statisticalUnit in StatisticalUnits)
            {
                if(includeNested)
                {
                    IEnumerable<StatisticalUnit> statisticalUnits_Nested = statisticalUnit.GetStatisticalUnits(includeNested, func);
                    if (statisticalUnits_Nested != null)
                    {
                        foreach (StatisticalUnit statisticalUnit_Nested in statisticalUnits_Nested)
                        {
                            result.Add(statisticalUnit_Nested);
                        }
                    }
                }

                if(func != null && !func.Invoke(statisticalUnit))
                {
                    continue;
                }

                result.Add(statisticalUnit);
            }

            return result;
        }
        
        public StatisticalUnitType? GetStatisticalUnitType()
        {
            return unitCode?.GetStatisticalUnitType();
        }
    }
}
