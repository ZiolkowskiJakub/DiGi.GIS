using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public abstract class ConstructionDateCalculationResult : UniqueResult<Building2D>, IConstructionDateCalculationResult
    {
        private DateTime dateTime;

        public ConstructionDateCalculationResult()
            :base()
        {

        }

        public ConstructionDateCalculationResult(DateTime dateTime)
            : base()
        {
            this.dateTime = dateTime;
        }

        public ConstructionDateCalculationResult(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public ConstructionDateCalculationResult(ConstructionDateCalculationResult constructionDateCalculationResult)
            : base(constructionDateCalculationResult)
        {

        }

        public DateTime DateTime
        {
            get
            {
                return dateTime;
            }
        }
    }
}
