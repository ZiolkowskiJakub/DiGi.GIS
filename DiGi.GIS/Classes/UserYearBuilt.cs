using DiGi.GIS.Enums;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a year built value that is provided by the user.
    /// </summary>
    public sealed class UserYearBuilt : YearBuilt
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserYearBuilt"/> class using a specified year.
        /// </summary>
        /// <param name="year">The year value to initialize with.</param>
        public UserYearBuilt(short year)
            : base(year)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserYearBuilt"/> class by copying an existing <see cref="UserYearBuilt"/> instance.
        /// </summary>
        /// <param name="userYearBuilt">The source <see cref="UserYearBuilt"/> instance to copy from.</param>
        public UserYearBuilt(UserYearBuilt? userYearBuilt)
            : base(userYearBuilt)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserYearBuilt"/> class using data from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the year built data.</param>
        public UserYearBuilt(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary> Gets the description of the source for this year built value. </summary>
        [JsonIgnore]
        public override string? Source => Core.Query.Description(YearBuiltSource);

        /// <summary> Gets the source type for this year built value, which is always <see cref="YearBuiltSource.User" />. </summary>
        [JsonIgnore]
        public override YearBuiltSource YearBuiltSource => YearBuiltSource.User;
    }
}
