using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Core.Classes;
using DiGi.GIS.Enums;
using DiGi.GIS.Interfaces;

namespace DiGi.GIS.Classes
{
    public abstract class YearBuilt : SerializableObject, IYearBuilt
    {
        [JsonInclude, JsonPropertyName("Year")]
        private short year;

        public YearBuilt(short year)
        {
            this.year = year;
        }

        public YearBuilt(YearBuilt yearBuilt)
            :base(yearBuilt)
        {
            if(yearBuilt != null)
            {
                year = yearBuilt.year;
            }
        }

        public YearBuilt(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public abstract string Source { get; }

        [JsonIgnore]
        public short Year
        {
            get
            {
                return year;
            }
        }

        [JsonIgnore]
        public abstract YearBuiltSource YearBuiltSource { get; }
    }
}
