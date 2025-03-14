using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public class AdministrativeAreal2DStatisticalUnitCalculcationResult : GuidResult<AdministrativeAreal2D>, IGISUniqueResult
    {
        [JsonIgnore]
        private UnitCode unitCode = null;

        [JsonInclude, JsonPropertyName("Name")]
        private string name = null;

        public AdministrativeAreal2DStatisticalUnitCalculcationResult(UnitCode unitCode, string name)
            : base()
        {
            this.unitCode = Core.Query.Clone(unitCode);
            this.name = name;
        }

        public AdministrativeAreal2DStatisticalUnitCalculcationResult(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public AdministrativeAreal2DStatisticalUnitCalculcationResult(AdministrativeAreal2DStatisticalUnitCalculcationResult administrativeAreal2DStatisticalUnitCalculcationResult)
            : base(administrativeAreal2DStatisticalUnitCalculcationResult)
        {
            unitCode = Core.Query.Clone(administrativeAreal2DStatisticalUnitCalculcationResult.unitCode);
            name = administrativeAreal2DStatisticalUnitCalculcationResult.name;
        }

        [JsonIgnore]
        public string Name
        {
            get
            {
                return name;
            }
        }

        [JsonInclude, JsonPropertyName("Code")]
        public string Code
        {
            get
            {
                return unitCode.Code;
            }
        }

        [JsonIgnore]
        public UnitCode UnitCode
        {
            get
            {
                return Core.Query.Clone(unitCode);
            }
        }

    }
}