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
        private readonly string? reference;

        [JsonInclude, JsonPropertyName("YearBuiltPredictions")]
        private readonly SortedDictionary<ushort, YearBuiltPrediction>? yearBuiltPredictions;

        public Building2DYearBuiltPredictions(string? reference, IEnumerable<YearBuiltPrediction>? yearBuiltPredictions)
        {
            this.reference = reference;
            if(yearBuiltPredictions != null)
            {
                this.yearBuiltPredictions = [];
                foreach (YearBuiltPrediction yearBuiltPrediction in yearBuiltPredictions)
                {
                    if(Core.Query.Clone(yearBuiltPrediction) is YearBuiltPrediction yearBuiltPrediction_Temp)
                    {
                        this.yearBuiltPredictions[yearBuiltPrediction.Year] = yearBuiltPrediction_Temp;
                    }
                }

            }
        }

        public Building2DYearBuiltPredictions(Building2DYearBuiltPredictions? building2DYearBuiltPredictions)
            : base(building2DYearBuiltPredictions)
        {
            if(building2DYearBuiltPredictions != null)
            {
                reference = building2DYearBuiltPredictions.reference;

                if(building2DYearBuiltPredictions.yearBuiltPredictions != null)
                {
                    yearBuiltPredictions = [];
                    foreach (KeyValuePair<ushort, YearBuiltPrediction> keyValuePair in building2DYearBuiltPredictions.yearBuiltPredictions)
                    {
                        if(Core.Query.Clone(keyValuePair.Value) is YearBuiltPrediction yearBuiltPrediction)
                        {
                            yearBuiltPredictions[keyValuePair.Key] = yearBuiltPrediction;
                        }
                    }
                }

            }
        }

        public Building2DYearBuiltPredictions(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public string? Reference
        {
            get
            {
                return reference;
            }
        }

        [JsonIgnore]
        public List<ushort>? Years
        {
            get
            {
                return yearBuiltPredictions?.Keys.ToList();
            }
        }

        public YearBuiltPrediction? this[ushort year]
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

        public YearBuiltPrediction? GetYearBuiltPrediction(ushort year)
        {
            if (!Core.Query.TryGetLowerValue(yearBuiltPredictions, year, out YearBuiltPrediction? result))
            {
                return null;
            }

            return result;
        }
    }
}
