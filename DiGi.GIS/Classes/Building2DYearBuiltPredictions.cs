using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Core.Classes;

namespace DiGi.GIS.Classes
{
    public class Building2DYearBuiltPredictions : SerializableObject
    {
        [JsonInclude, JsonPropertyName("Reference")]
        private string reference;

        [JsonInclude, JsonPropertyName("YearBuiltPredictions")]
        private SortedDictionary<ushort, YearBuiltPrediction> yearBuiltPredictions;

        public Building2DYearBuiltPredictions(string reference, IEnumerable<YearBuiltPrediction> yearBuiltPredictions)
        {
            this.reference = reference;
            if(yearBuiltPredictions != null)
            {
                this.yearBuiltPredictions = new SortedDictionary<ushort, YearBuiltPrediction>();
                foreach (YearBuiltPrediction yearBuiltPrediction in yearBuiltPredictions)
                {
                    if(yearBuiltPrediction == null)
                    {
                        continue;
                    }

                    this.yearBuiltPredictions[yearBuiltPrediction.Year] = Core.Query.Clone(yearBuiltPrediction);
                }

            }
        }

        public Building2DYearBuiltPredictions(Building2DYearBuiltPredictions building2DYearBuiltPredictions)
            : base(building2DYearBuiltPredictions)
        {
            if(building2DYearBuiltPredictions != null)
            {
                reference = building2DYearBuiltPredictions.reference;

                if(building2DYearBuiltPredictions.yearBuiltPredictions != null)
                {
                    yearBuiltPredictions = new SortedDictionary<ushort, YearBuiltPrediction>();
                    foreach (KeyValuePair<ushort, YearBuiltPrediction> keyValuePair in building2DYearBuiltPredictions.yearBuiltPredictions)
                    {
                        yearBuiltPredictions[keyValuePair.Key] = Core.Query.Clone(keyValuePair.Value);
                    }
                }

            }
        }

        public Building2DYearBuiltPredictions(JsonObject jsonObject)
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

        [JsonIgnore]
        public List<ushort> Years
        {
            get
            {
                return yearBuiltPredictions?.Keys.ToList();
            }
        }

        public YearBuiltPrediction this[ushort year]
        {
            get
            {
                if(yearBuiltPredictions == null)
                {
                    return null;
                }

                if(!yearBuiltPredictions.TryGetValue(year, out YearBuiltPrediction yearBuiltPrediction) || yearBuiltPrediction == null)
                {
                    return null;
                }

                return Core.Query.Clone(yearBuiltPrediction);
            }
        }
    }
}
