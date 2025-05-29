using DiGi.Core.Classes;
using DiGi.GIS.Enums;
using DiGi.GIS.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public class YearBuiltData : SerializableObject, IYearBuiltData
    {
        [JsonInclude, JsonPropertyName("Reference")]
        private string reference;

        //[JsonInclude, JsonPropertyName("Year")]
        //public short Year;

        [JsonIgnore]
        private Dictionary<string, IYearBuilt> yearBuilts;

        public YearBuiltData(string reference)
        {
            this.reference = reference;
        }

        public YearBuiltData(YearBuiltData yearBuiltData)
        {
            if (yearBuiltData != null)
            {
                reference = yearBuiltData.reference;
                YearBuilts = yearBuiltData.YearBuilts;
            }
        }

        public YearBuiltData(JsonObject jsonObject)
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

        [JsonInclude, JsonPropertyName("YearBuilts")]
        public IEnumerable<IYearBuilt> YearBuilts
        {
            get
            {
                return yearBuilts == null ? null : yearBuilts.Values;
            }

            set
            {
                if (value == null)
                {
                    yearBuilts = null;
                    return;
                }

                yearBuilts = new Dictionary<string, IYearBuilt>();

                foreach (IYearBuilt yearBuilt in value)
                {
                    Add(yearBuilt);
                }
            }
        }

        public bool Add(IYearBuilt yearBuilt)
        {
            string source = yearBuilt?.Source;
            if (source == null)
            {
                return false;
            }

            if(yearBuilts == null)
            {
                yearBuilts = new Dictionary<string, IYearBuilt>();
            }

            yearBuilts[source] = yearBuilt;
            return true;
        }

        public PredictedYearBuilt GetLatestPredictedYearBuilt()
        {
            List<PredictedYearBuilt> predictedYearBuilts = GetPredictedYearBuilts();
            if (predictedYearBuilts == null || predictedYearBuilts.Count == 0)
            {
                return null;
            }

            PredictedYearBuilt result = predictedYearBuilts[0];
            for (int i = 1; i < predictedYearBuilts.Count; i++)
            {
                if (result.DateTime < predictedYearBuilts[i].DateTime)
                {
                    result = predictedYearBuilts[i];
                }
            }

            return result;
        }

        public PredictedYearBuilt GetPredictedYearBuilt(DateTime dateTime)
        {
            if (yearBuilts == null)
            {
                return null;
            }

            foreach (KeyValuePair<string, IYearBuilt> keyValuePair in yearBuilts)
            {
                PredictedYearBuilt predictedYearBuilt = keyValuePair.Value as PredictedYearBuilt;
                if (predictedYearBuilt != null && dateTime.Equals(predictedYearBuilt.DateTime))
                {
                    return predictedYearBuilt;
                }
            }

            return null;
        }
        
        public List<PredictedYearBuilt> GetPredictedYearBuilts()
        {
            if(yearBuilts == null)
            {
                return null;
            }

            List < PredictedYearBuilt > result = new List<PredictedYearBuilt> ();
            foreach (IYearBuilt yearBuilt in yearBuilts.Values)
            {
                PredictedYearBuilt predictedYearBuilt = yearBuilt as PredictedYearBuilt;
                if (predictedYearBuilt != null)
                {
                    result.Add(predictedYearBuilt);
                }
            }

            return result;
        }

        public UserYearBuilt GetUserYearBuilt()
        {
            if (!TryGetYearBuilt(Core.Query.Description(YearBuiltSource.User), out UserYearBuilt result))
            {
                return null;
            }

            return result;
        }

        public List<TYearBuilt> GetYearBuilts<TYearBuilt>() where TYearBuilt : IYearBuilt
        {
            if (yearBuilts == null)
            {
                return null;
            }

            List<TYearBuilt> result = new List<TYearBuilt>();
            foreach (IYearBuilt yearBuilt in yearBuilts.Values)
            {
                if (yearBuilt is TYearBuilt)
                {
                    result.Add((TYearBuilt)yearBuilt);
                }
            }

            return result;
        }

        public bool Remove(string source)
        {
            if (source == null || yearBuilts == null)
            {
                return false;
            }

            return yearBuilts.Remove(source);
        }

        public bool RemovePredictedYearBuilts()
        {
            bool result = false;

            if (yearBuilts == null)
            {
                return result;
            }

            List<string> sources = new List<string>();
            foreach(KeyValuePair<string, IYearBuilt> keyValuePair in yearBuilts)
            {
                if(keyValuePair.Value is PredictedYearBuilt)
                {
                    sources.Add(keyValuePair.Key);
                }
            }

            foreach(string source in sources)
            {
                if(yearBuilts.Remove(source))
                {
                    result = true;
                }
            }


            return result;
        }

        public bool RemoveUserYearBuilt()
        {
            return Remove(Core.Query.Description(YearBuiltSource.User));
        }

        public bool SetPredictedYearBuilt(DateTime dateTime, short year)
        {
            return Add(new PredictedYearBuilt(dateTime, year));
        }
        
        public bool SetUserYearBuilt(short year)
        {
            return Add(new UserYearBuilt(year));
        }

        public bool TryGetYearBuilt<TYearBuilt>(string source, out TYearBuilt yearBuilt) where TYearBuilt : IYearBuilt
        {
            yearBuilt = default;

            if(source == null || yearBuilts == null)
            {
                return false;
            }

            if(!yearBuilts.TryGetValue(source, out IYearBuilt yearBuilt_Temp) || !(yearBuilt_Temp is TYearBuilt))
            {
                return false;
            }

            yearBuilt = (TYearBuilt)yearBuilt_Temp;
            return true;
        }
    }
}
