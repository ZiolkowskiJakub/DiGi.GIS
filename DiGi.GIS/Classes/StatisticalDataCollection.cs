using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;

namespace DiGi.GIS.Classes
{
    public class StatisticalDataCollection : GuidObject, IGISGuidObject2D
    {
        [JsonIgnore]
        private Dictionary<string, IStatisticalData> dictionary = new Dictionary<string, IStatisticalData>();

        [JsonIgnore]
        private UnitCode unitCode = null;

        public StatisticalDataCollection(Guid guid, UnitCode unitCode, IEnumerable<IStatisticalData> statisticalDatas)
            : base(guid)
        {
            this.unitCode = Core.Query.Clone(unitCode);
            StatisticalDatas = statisticalDatas;
        }

        public StatisticalDataCollection(Guid guid, UnitCode unitCode)
            : base(guid)
        {
            this.unitCode = Core.Query.Clone(unitCode);
        }

        public StatisticalDataCollection(StatisticalDataCollection statisticalDataCollection)
            : base(statisticalDataCollection == null ? Guid.Empty : statisticalDataCollection.Guid)
        {
            if (statisticalDataCollection != null)
            {
                unitCode = Core.Query.Clone(statisticalDataCollection.unitCode);
                StatisticalDatas = statisticalDataCollection.StatisticalDatas;
            }
        }

        public StatisticalDataCollection(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonInclude, JsonPropertyName("Code")]
        public string Code
        {
            get
            {
                return unitCode.Code;
            }

            set
            {
                unitCode = Create.UnitCode(value);
            }
        }

        [JsonIgnore]
        public IEnumerable<string> Names
        {
            get
            {
                return dictionary.Keys;
            }
        }

        [JsonInclude, JsonPropertyName("StatisticalDatas")]
        public IEnumerable<IStatisticalData> StatisticalDatas
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

        [JsonIgnore]
        public UnitCode UnitCode
        {
            get
            {
                return Core.Query.Clone(unitCode);
            }
        }
        [JsonIgnore]
        public IStatisticalData this[string name]
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

        public bool Add(IStatisticalData statisticalData)
        {
            if (statisticalData?.Name == null)
            {
                return false;
            }

            dictionary[statisticalData.Name] = statisticalData;
            return true;
        }

        public bool Contains(string name)
        {
            return dictionary.ContainsKey(name);
        }

        public TStatisticalData Find<TStatisticalData>(Func<TStatisticalData, bool> func) where TStatisticalData : IStatisticalData
        {
            if (func == null)
            {
                return default;
            }

            foreach (IStatisticalData statisticalData in dictionary.Values)
            {
                if (statisticalData is TStatisticalData)
                {
                    TStatisticalData statisticalData_Temp = (TStatisticalData)statisticalData;
                    if (func.Invoke(statisticalData_Temp))
                    {
                        return statisticalData_Temp;
                    }
                }
            }

            return default;
        }

        public IStatisticalData GetStatisticalData(string name)
        {
            if (!TryGetStatisticalData(name, out IStatisticalData statisticalData))
            {
                return null;
            }

            return statisticalData;
        }

        public IEnumerable<UStatisticalData> GetStatisticalDatas<UStatisticalData>() where UStatisticalData : IStatisticalData
        {
            List<UStatisticalData> result = new List<UStatisticalData>();
            foreach (IStatisticalData statisticalData in dictionary.Values)
            {
                if (statisticalData is UStatisticalData)
                {
                    result.Add((UStatisticalData)statisticalData);
                }

            }

            return result;
        }

        public bool Remove(string name)
        {
            return dictionary.Remove(name);
        }

        public bool TryGetStatisticalData(string name, out IStatisticalData statisticalData)
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
