using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents statistical yearly data with double values
    /// </summary>
    public class StatisticalYearlyDoubleData : StatisticalYearlyData<double>
    {
        /// <summary>
        /// Initializes a new instance of the StatisticalYearlyDoubleData class with the specified name and reference
        /// </summary>
        public StatisticalYearlyDoubleData(string? name, string? reference)
            : base(name, reference)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StatisticalYearlyDoubleData class with the specified name, reference, and values
        /// </summary>
        public StatisticalYearlyDoubleData(string? name, string? reference, IEnumerable<KeyValuePair<short, double>>? values)
            : base(name, reference, values)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StatisticalYearlyDoubleData class by copying another instance
        /// </summary>
        public StatisticalYearlyDoubleData(StatisticalYearlyDoubleData? statisticalYearlyDoubleData)
            : base(statisticalYearlyDoubleData)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StatisticalYearlyDoubleData class from a JSON object
        /// </summary>
        public StatisticalYearlyDoubleData(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}