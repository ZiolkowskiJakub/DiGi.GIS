using System;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public class Building2DMachineLearningConstructionDateCalculationResult : Building2DConstructionDateCalculationResult
    {
        public Building2DMachineLearningConstructionDateCalculationResult()
            :base()
        {

        }

        public Building2DMachineLearningConstructionDateCalculationResult(DateTime dateTime)
            : base(dateTime)
        {

        }

        public Building2DMachineLearningConstructionDateCalculationResult(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Building2DMachineLearningConstructionDateCalculationResult(Building2DMachineLearningConstructionDateCalculationResult building2DMachineLearningConstructionDateCalculationResult)
            : base(building2DMachineLearningConstructionDateCalculationResult)
        {

        }
    }
}
