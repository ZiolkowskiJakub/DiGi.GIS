using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents statistical yearly data with double values.
    /// </summary>
    public class StatisticalYearlyDoubleData : StatisticalYearlyData<double>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticalYearlyDoubleData"/> class with the specified name and reference.
        /// </summary>
        /// <param name="name">The name of the statistical data.</param>
        /// <param name="reference">The reference identifier for the statistical data.</param>
        public StatisticalYearlyDoubleData(string? name, string? reference)
            : base(name, reference)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticalYearlyDoubleData"/> class with the specified name, reference, and values.
        /// </summary>
        /// <param name="name">The name of the statistical data.</param>
        /// <param name="reference">The reference identifier for the statistical data.</param>
        /// <param name="values">A collection of key-value pairs where the key is the year and the value is the double precision data point.</param>
        public StatisticalYearlyDoubleData(string? name, string? reference, IEnumerable<KeyValuePair<short, double>>? values)
            : base(name, reference, values)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticalYearlyDoubleData"/> class by copying another instance.
        /// </summary>
        /// <param name="statisticalYearlyDoubleData">The source instance to copy from.</param>
        public StatisticalYearlyDoubleData(StatisticalYearlyDoubleData? statisticalYearlyDoubleData)
            : base(statisticalYearlyDoubleData)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticalYearlyDoubleData"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data for initialization.</param>
        public StatisticalYearlyDoubleData(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}