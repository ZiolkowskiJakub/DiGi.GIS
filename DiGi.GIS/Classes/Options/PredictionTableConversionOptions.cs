using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public class PredictionTableConversionOptions : TableConversionOptions
    {
        [JsonInclude, JsonPropertyName("IncludeYearBuiltPredictions")]
        public bool IncludeYearBuiltPredictions { get; set; } = true;

        [JsonInclude, JsonPropertyName("AdministrativeAreal2DsIndexDataFilePath")]
        public string AdministrativeAreal2DsIndexDataFilePath { get; set; } = null;

        public PredictionTableConversionOptions()
            :base()
        {

        }

        public PredictionTableConversionOptions(PredictionTableConversionOptions predictionTableConversionOptions)
            : base(predictionTableConversionOptions)
        {
            if(predictionTableConversionOptions != null)
            {
                IncludeYearBuiltPredictions = predictionTableConversionOptions.IncludeYearBuiltPredictions;
                AdministrativeAreal2DsIndexDataFilePath = predictionTableConversionOptions.AdministrativeAreal2DsIndexDataFilePath;
            }
        }

        public PredictionTableConversionOptions(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

    }
}
