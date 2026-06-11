using DiGi.Core.Classes;
using DiGi.GIS.Enums;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents the year a structure was built.
    /// </summary>
    public abstract class YearBuilt : SerializableObject, IYearBuilt
    {
        [JsonInclude, JsonPropertyName("Year")]
        private readonly short year;

        /// <summary>
        /// Initializes a new instance of the <see cref="YearBuilt"/> class with the specified year.
        /// </summary>
        /// <param name="year">The year the structure was built.</param>
        public YearBuilt(short year)
        {
            this.year = year;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="YearBuilt"/> class using another <see cref="YearBuilt"/> instance.
        /// </summary>
        /// <param name="yearBuilt">The existing <see cref="YearBuilt"/> instance to copy from.</param>
        public YearBuilt(YearBuilt? yearBuilt)
            : base(yearBuilt)
        {
            if (yearBuilt != null)
            {
                year = yearBuilt.year;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="YearBuilt"/> class using a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the data.</param>
        public YearBuilt(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the source of the year built information.
        /// </summary>
        [JsonIgnore]
        public abstract string? Source { get; }

        /// <summary>
        /// Gets the year the structure was built.
        /// </summary>
        [JsonIgnore]
        public short Year
        {
            get
            {
                return year;
            }
        }

        /// <summary>
        /// Gets the source type for the year built value.
        /// </summary>
        [JsonIgnore]
        public abstract YearBuiltSource YearBuiltSource { get; }
    }
}