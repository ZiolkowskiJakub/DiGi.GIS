using DiGi.GIS.Enums;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public sealed class PredictedYearBuilt : YearBuilt
    {
        [JsonInclude, JsonPropertyName("DateTime")]
        private DateTime dateTime;
        
        public PredictedYearBuilt(DateTime dateTime, short year)
            : base(year)
        {
            this.dateTime = dateTime;
        }

        public PredictedYearBuilt(PredictedYearBuilt predictedYearBuilt)
            :base(predictedYearBuilt)
        {
            if(predictedYearBuilt != null)
            {
                dateTime = predictedYearBuilt.dateTime;
            }
        }

        public PredictedYearBuilt(JsonObject jsonObject)
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
        public override string Source => string.Format("{0}_{1}", Core.Query.Description(YearBuiltSource), dateTime.Ticks);

        [JsonIgnore]
        public override YearBuiltSource YearBuiltSource => YearBuiltSource.Prediction;
    }
}
