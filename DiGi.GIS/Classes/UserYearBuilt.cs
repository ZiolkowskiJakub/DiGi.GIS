using DiGi.GIS.Enums;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public sealed class UserYearBuilt : YearBuilt
    {
        public UserYearBuilt(short year)
            : base(year)
        {

        }

        public UserYearBuilt(UserYearBuilt userYearBuilt)
            : base(userYearBuilt)
        {

        }

        public UserYearBuilt(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public override string Source => Core.Query.Description(YearBuiltSource);

        [JsonIgnore]
        public override YearBuiltSource YearBuiltSource => YearBuiltSource.User;
    }
}
