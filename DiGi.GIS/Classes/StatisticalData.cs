using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents the base class for statistical data, providing common properties such as name and reference.
    /// </summary>
    public abstract class StatisticalData : SerializableObject, IStatisticalData
    {
        [JsonInclude, JsonPropertyName("Name")]
        private readonly string? name;

        [JsonInclude, JsonPropertyName("Reference")]
        private readonly string? reference = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticalData"/> class.
        /// </summary>
        /// <param name="name">The name of the statistical data.</param>
        /// <param name="reference">The reference identifier for the statistical data.</param>
        public StatisticalData(string? name, string? reference)
            : base()
        {
            this.name = name;
            this.reference = reference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticalData"/> class by copying an existing statistical data object.
        /// </summary>
        /// <param name="statisticalData">The source statistical data object to copy from.</param>
        public StatisticalData(StatisticalData? statisticalData)
            : base(statisticalData)
        {
            if (statisticalData != null)
            {
                name = statisticalData.name;
                reference = statisticalData.reference;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticalData"/> class using a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data to initialize the instance.</param>
        public StatisticalData(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the name of the statistical data.
        /// </summary>
        [JsonIgnore]
        public string? Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Gets the reference identifier of the statistical data.
        /// </summary>
        [JsonIgnore]
        public string? Reference
        {
            get
            {
                return reference;
            }
        }
    }
}