using DiGi.GIS.Enums;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a year built value that is provided by the user.
    /// </summary>
    public sealed class UserYearBuilt : YearBuilt
    {
        [JsonInclude, JsonPropertyName("YearBuiltRelation")]
        private readonly YearBuiltRelation yearBuiltRelation;

        [JsonInclude, JsonPropertyName("DateTime")]
        private readonly DateTimeOffset? dateTime;

        [JsonInclude, JsonPropertyName("UserName")]
        private readonly string? userName;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserYearBuilt"/> class with a year, an optional relation, and optional provenance.
        /// </summary>
        /// <param name="year">The construction year, or the bound year, recorded by the user.</param>
        /// <param name="yearBuiltRelation">How <paramref name="year"/> relates to the true construction year. Defaults to <see cref="YearBuiltRelation.Exact"/>.</param>
        /// <param name="dateTime">When the entry was recorded (UTC). Defaults to null for legacy entries.</param>
        /// <param name="userName">Who recorded the entry. Defaults to null for legacy entries.</param>
        public UserYearBuilt(short year, YearBuiltRelation yearBuiltRelation = YearBuiltRelation.Exact, DateTimeOffset? dateTime = null, string? userName = null)
            : base(year)
        {
            this.yearBuiltRelation = yearBuiltRelation;
            this.dateTime = dateTime;
            this.userName = userName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserYearBuilt"/> class by copying an existing <see cref="UserYearBuilt"/> instance.
        /// </summary>
        /// <param name="userYearBuilt">The source <see cref="UserYearBuilt"/> instance to copy from.</param>
        public UserYearBuilt(UserYearBuilt? userYearBuilt)
            : base(userYearBuilt)
        {
            if (userYearBuilt != null)
            {
                yearBuiltRelation = userYearBuilt.yearBuiltRelation;
                dateTime = userYearBuilt.dateTime;
                userName = userYearBuilt.userName;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserYearBuilt"/> class using data from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the year built data.</param>
        public UserYearBuilt(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets how the stored <see cref="YearBuilt.Year"/> relates to the true construction year. Defaults to <see cref="YearBuiltRelation.Exact"/> for legacy entries.
        /// </summary>
        [JsonIgnore]
        public YearBuiltRelation YearBuiltRelation
        {
            get
            {
                return yearBuiltRelation;
            }
        }

        /// <summary>
        /// Gets when the entry was recorded (UTC), or null for legacy entries written before this member existed.
        /// </summary>
        [JsonIgnore]
        public DateTimeOffset? DateTime
        {
            get
            {
                return dateTime;
            }
        }

        /// <summary>
        /// Gets who recorded the entry, or null for legacy entries written before this member existed.
        /// </summary>
        [JsonIgnore]
        public string? UserName
        {
            get
            {
                return userName;
            }
        }

        /// <summary> Gets the description of the source for this year built value. </summary>

        [JsonIgnore]
        public override string? Source => Core.Query.Description(YearBuiltSource);

        /// <summary> Gets the source type for this year built value, which is always <see cref="YearBuiltSource.User" />. </summary>

        [JsonIgnore]
        public override YearBuiltSource YearBuiltSource => YearBuiltSource.User;
    }
}
