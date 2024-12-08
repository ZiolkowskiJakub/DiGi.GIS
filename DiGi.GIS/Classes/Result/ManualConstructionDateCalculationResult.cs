using System;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public class ManualConstructionDateCalculationResult : ConstructionDateCalculationResult
    {
        public ManualConstructionDateCalculationResult()
            :base()
        {

        }

        public ManualConstructionDateCalculationResult(DateTime dateTime)
            : base(dateTime)
        {

        }

        public ManualConstructionDateCalculationResult(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public ManualConstructionDateCalculationResult(ManualConstructionDateCalculationResult manualConstructionDateCalculationResult)
            : base(manualConstructionDateCalculationResult)
        {

        }
    }
}
