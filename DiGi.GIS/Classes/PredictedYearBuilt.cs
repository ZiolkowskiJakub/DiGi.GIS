using DiGi.GIS.Enums;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a year built value that has been predicted, including the date and time of the prediction.
    /// </summary>
    public sealed class PredictedYearBuilt : YearBuilt
    {
        [JsonInclude, JsonPropertyName("DateTime")]
        private readonly DateTime dateTime;

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictedYearBuilt"/> class with a specific date time and year.
        /// </summary>
        /// <param name="dateTime">The date and time when the prediction was made.</param>
        /// <param name="year">The predicted year built.</param>
        public PredictedYearBuilt(DateTime dateTime, short year)
            : base(year)
        {
            this.dateTime = dateTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictedYearBuilt"/> class by copying another instance.
        /// </summary>
        /// <param name="predictedYearBuilt">The existing predicted year built instance to copy from.</param>
        public PredictedYearBuilt(PredictedYearBuilt predictedYearBuilt)
            : base(predictedYearBuilt)
        {
            if (predictedYearBuilt != null)
            {
                dateTime = predictedYearBuilt.dateTime;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictedYearBuilt"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data for initialization.</param>
        public PredictedYearBuilt(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the date and time when the prediction was made.
        /// </summary>
        [JsonIgnore]
        public DateTime DateTime
        {
            get
            {
                return dateTime;
            }
        }

        /// <summary>
        /// Gets the source identifier for the predicted year built, combining the source type and ticks of the prediction date.
        /// </summary>
        [JsonIgnore]
        public override string Source => string.Format("{0}_{1}", Core.Query.Description(YearBuiltSource), dateTime.Ticks);

        /// <summary>
        /// Gets the source of the year built value, which is always set to prediction.
        /// </summary>
        [JsonIgnore]
        public override YearBuiltSource YearBuiltSource => YearBuiltSource.Prediction;
    }
}