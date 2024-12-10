using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public abstract class Building2DConstructionDateCalculationResult : UniqueResult<Building2D>, IConstructionDateCalculationResult
    {
        [JsonInclude, JsonPropertyName("DateTime")]
        private DateTime dateTime;

        public Building2DConstructionDateCalculationResult()
            :base()
        {

        }

        public Building2DConstructionDateCalculationResult(DateTime dateTime)
            : base()
        {
            this.dateTime = dateTime;
        }

        public Building2DConstructionDateCalculationResult(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Building2DConstructionDateCalculationResult(Building2DConstructionDateCalculationResult building2DConstructionDateCalculationResult)
            : base(building2DConstructionDateCalculationResult)
        {
            if(building2DConstructionDateCalculationResult == null)
            {
                dateTime = building2DConstructionDateCalculationResult.dateTime;
            }
        }

        [JsonIgnore]
        public DateTime DateTime
        {
            get
            {
                return dateTime;
            }
        }
    }
}
