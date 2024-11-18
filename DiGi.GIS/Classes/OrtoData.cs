using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;

namespace DiGi.GIS.Classes
{
    public class OrtoData : SerializableObject, IGISObject
    {
        [JsonInclude, JsonPropertyName("DateTime")]
        private DateTime dateTime;

        [JsonInclude, JsonPropertyName("Bytes")]
        private byte[] bytes;

        public OrtoData(DateTime dateTime, byte[] bytes)
        {
            this.dateTime = dateTime;
            this.bytes = bytes;
        }

        public OrtoData(OrtoData ortoData)
        {
            if(ortoData != null)
            {
                dateTime = ortoData.dateTime;
                bytes = ortoData.bytes;
            }
        }

        public OrtoData(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public DateTime DateTime
        {
            get
            {
                return dateTime;
            }
        }

        [JsonIgnore]
        public byte[] Bytes
        {
            get
            {
                return bytes;
            }
        }

    }
}
