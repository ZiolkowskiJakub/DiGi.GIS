using DiGi.GIS.Enums;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public abstract class OtherYearBuilt : YearBuilt
    {
        public OtherYearBuilt(short year)
            : base(year)
        {

        }

        public OtherYearBuilt(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public override YearBuiltSource YearBuiltSource => YearBuiltSource.Other;
    }
}
