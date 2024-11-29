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
    public class OrtoDatas : UniqueObject, IGISUniqueObject, IEnumerable<OrtoData>
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
                sortedDictionary[ortoData.DateTime] = ortoData;
                ortoDatas.RemoveAt(0);

                int index = 0;

                for (int i = 0; i < ortoDatas.Count; i++)
                {
                    if(!Core.Query.Equals(ortoData.Bytes, ortoDatas[i].Bytes))
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

        public byte[] GetBytes(DateTime dateTime)
        {
            if(sortedDictionary == null || sortedDictionary.Count == 0)
            {
                return null;
            }

            IEnumerable<DateTime> dateTimes = sortedDictionary.Keys;

            DateTime min = dateTimes.First();
            DateTime max = dateTimes.Last();

            if (dateTime < min)
            {
                return null;
            }

            if(dateTime >= max)
            {
                return sortedDictionary[max]?.Bytes;
            }

            List<DateTime> dateTimes_Temp = new List<DateTime>(dateTimes);
            dateTimes_Temp.Reverse();

            foreach (DateTime dateTime_Temp in dateTimes)
            {
                if(dateTime_Temp < dateTime)
                {
                    return sortedDictionary[dateTime_Temp]?.Bytes;
                }
            }

            return null;
        }
    }
}
