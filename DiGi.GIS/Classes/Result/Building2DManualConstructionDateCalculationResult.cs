using System;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public class Building2DManualConstructionDateCalculationResult : Building2DConstructionDateCalculationResult
    {
        public Building2DManualConstructionDateCalculationResult()
            :base()
        {

        }

        public Building2DManualConstructionDateCalculationResult(DateTime dateTime)
            : base(dateTime)
        {

        }

        public Building2DManualConstructionDateCalculationResult(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Building2DManualConstructionDateCalculationResult(Building2DManualConstructionDateCalculationResult building2DManualConstructionDateCalculationResult)
            : base(building2DManualConstructionDateCalculationResult)
        {

        }
    }
}
