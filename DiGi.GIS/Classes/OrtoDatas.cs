using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;

namespace DiGi.GIS.Classes
{
    public class OrtoDatas : GuidObject, IGISGuidObject, IEnumerable<OrtoData>
    {
        [JsonInclude, JsonPropertyName("Reference")]
        private string reference = null;

        [JsonIgnore]
        private SortedDictionary<DateTime, OrtoData> sortedDictionary = new SortedDictionary<DateTime, OrtoData>();
        
        public OrtoDatas(string reference, IEnumerable<OrtoData> values)
        {
            this.reference = reference;
            Values = values;
        }

        public OrtoDatas(OrtoDatas ortoDatas)
        {
            if(ortoDatas != null)
            {
                reference = ortoDatas.reference;
                Values = ortoDatas.Values;
            }
        }

        public OrtoDatas(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public string Reference
        {
            get
            {
                return reference;
            }
        }

        [JsonInclude, JsonPropertyName("Values")]
        private IEnumerable<OrtoData> Values
        {
            get
            {
                return sortedDictionary.Values;
            }
            set
            {
                sortedDictionary.Clear();
                if(value == null)
                {
                    return;
                }

                foreach(OrtoData ortoData in value)
                {
                    if(ortoData == null)
                    {
                        continue;
                    }

                    sortedDictionary[ortoData.DateTime] = ortoData;
                }
            }
        }
        
        public IEnumerator<OrtoData> GetEnumerator()
        {
            return sortedDictionary?.Values == null ? new List<OrtoData>().GetEnumerator() : new List<OrtoData>(sortedDictionary.Values).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Reduce()
        {
            if (sortedDictionary == null)
            {
                return;
            }

            List<OrtoData> ortoDatas = new List<OrtoData>(sortedDictionary.Values);

            sortedDictionary.Clear();

            List<OrtoData> result = new List<OrtoData>();
            while (ortoDatas.Count > 0)
            {
                OrtoData ortoData = ortoDatas[0];
                ortoDatas.RemoveAt(0);

                byte[] bytes = ortoData?.Bytes;
                if(bytes == null || bytes.Length == 0)
                {
                    continue;
                }

                sortedDictionary[ortoData.DateTime] = ortoData;

                int index = 0;

                for (int i = 0; i < ortoDatas.Count; i++)
                {
                    if(!Core.Query.Equals(bytes, ortoDatas[i].Bytes))
                    {
                        break;
                    }

                    index++;
                }

                if(index == 0)
                {
                    continue;
                }

                ortoDatas.RemoveRange(0, index);
            }
        }

        public bool TryGetYears(out HashSet<int> years)
        {
            years = null;
            if (!TryGetDateTime(out DateTime dateTime_Min, out DateTime dateTime_Max))
            {
                return false;
            }

            years = new HashSet<int>();
            for (int i = dateTime_Min.Year; i <= dateTime_Max.Year; i++)
            {
                years.Add(i);
            }

            return true;
        }

        public bool TryGetDateTime(out DateTime dateTime_Min, out DateTime dateTime_Max)
        {
            dateTime_Min = default;
            dateTime_Max = default;
            if(sortedDictionary == null || sortedDictionary.Count == 0)
            {
                return false;
            }

            dateTime_Min = sortedDictionary.Keys.First();
            dateTime_Max = sortedDictionary.Keys.Last();
            return true;
        }

        public byte[] GetBytes(DateTime dateTime)
        {
            OrtoData ortoData = GetOrtoData(dateTime);
            if(ortoData == null)
            {
                return null;
            }

            return ortoData.Bytes;
        }

        public OrtoData GetOrtoData(DateTime dateTime)
        {
            if(!Core.Query.TryGetLowerValue(sortedDictionary, dateTime, out OrtoData result))
            {
                return null;
            }

            return result;
        }
    }
}
