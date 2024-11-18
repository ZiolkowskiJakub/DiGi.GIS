using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;

namespace DiGi.GIS.Classes
{
    public class OrtoDatas : UniqueObject, IGISUniqueObject, IEnumerable<OrtoData>
    {
        [JsonIgnore]
        private Dictionary<DateTime, OrtoData> dictionary = new Dictionary<DateTime, OrtoData>();

        [JsonInclude, JsonPropertyName("Reference")]
        private string reference = null;
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
                return dictionary.Values;
            }
            set
            {
                dictionary.Clear();
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

                    dictionary[ortoData.DateTime] = ortoData;
                }
            }
        }
        
        public IEnumerator<OrtoData> GetEnumerator()
        {
            return dictionary?.Values == null ? new List<OrtoData>().GetEnumerator() : new List<OrtoData>(dictionary.Values).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
