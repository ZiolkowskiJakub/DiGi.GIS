using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Geometry.Core.Classes;
using DiGi.GIS.Interfaces;

namespace DiGi.GIS.Classes
{
    public class StatisticalDataCollection : GuidObject, IGISGuidObject2D
    {
        [JsonIgnore]
        private Dictionary<string, IStatisticalData> dictionary = new Dictionary<string, IStatisticalData>();

        [JsonInclude, JsonPropertyName("Reference")]
        private string reference = null;
        public StatisticalDataCollection(Guid guid, string reference, IEnumerable<IStatisticalData> statisticalDatas)
            : base(guid)
        {
            this.reference = reference;
            StatisticalDatas = statisticalDatas;
        }

        public StatisticalDataCollection(Guid guid, string reference)
            : base(guid)
        {
            this.reference = reference;
        }

        public StatisticalDataCollection(StatisticalDataCollection statisticalDataCollection)
            : base(statisticalDataCollection == null ? Guid.Empty : statisticalDataCollection.Guid)
        {
            if(statisticalDataCollection != null)
            {
                reference = statisticalDataCollection.reference;
                StatisticalDatas = statisticalDataCollection.StatisticalDatas;
            }
        }

        public StatisticalDataCollection(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        [JsonIgnore]
        public IEnumerable<string> Names
        {
            get
            {
                return dictionary.Keys;
            }
        }

        [JsonIgnore]
        public string Reference
        {
            get
            {
                return reference;
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
                if(value == null)
                {
                    return;
                }

                foreach(IStatisticalData statisticalData in value)
                {
                    if(statisticalData.Name == null)
                    {
                        continue;
                    }

                    dictionary[statisticalData.Name] = statisticalData;
                }
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
            foreach(IStatisticalData statisticalData in dictionary.Values)
            {
                if(statisticalData is UStatisticalData)
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

            if(!dictionary.TryGetValue(name, out statisticalData))
            {
                return false;
            }

            return true;
        }

        public TStatisticalData Find<TStatisticalData>(Func<TStatisticalData, bool> func) where TStatisticalData : IStatisticalData
        {
            if(func == null)
            {
                return default;
            }

            foreach(IStatisticalData statisticalData in dictionary.Values)
            {
                if(statisticalData is TStatisticalData)
                {
                    TStatisticalData statisticalData_Temp = (TStatisticalData)statisticalData;
                    if(func.Invoke(statisticalData_Temp))
                    {
                        return statisticalData_Temp;
                    }
                }
            }

            return default;
        }
    }
}
