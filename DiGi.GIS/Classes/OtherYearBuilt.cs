using DiGi.GIS.Enums;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a year built value where the source is categorized as other.
    /// </summary>
    public abstract class OtherYearBuilt : YearBuilt
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OtherYearBuilt"/> class with the specified year.
        /// </summary>
        /// <param name="year">The year to be assigned.</param>
        public OtherYearBuilt(short year)
            : base(year)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtherYearBuilt"/> class using the provided JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing year built data.</param>
        public OtherYearBuilt(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the source of the year built, which is always set to <see cref="YearBuiltSource.Other"/>.
        /// </summary>
        [JsonIgnore]
        public override YearBuiltSource YearBuiltSource => YearBuiltSource.Other;
    }
}