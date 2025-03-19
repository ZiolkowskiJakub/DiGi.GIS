using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public class AdministrativeAreal2DStatisticalUnitsCalculcationResult : GuidResult<AdministrativeAreal2D>, IGISUniqueResult
    {
        [JsonIgnore]
        private Dictionary<string, StatisticalUnit> dictionary = new Dictionary<string, StatisticalUnit>();

        public AdministrativeAreal2DStatisticalUnitsCalculcationResult(IEnumerable<StatisticalUnit> statisticalUnits)
            : base()
        {
            StatisticalUnits = statisticalUnits;
        }

        public AdministrativeAreal2DStatisticalUnitsCalculcationResult(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public AdministrativeAreal2DStatisticalUnitsCalculcationResult(AdministrativeAreal2DStatisticalUnitsCalculcationResult administrativeAreal2DStatisticalUnitsCalculcationResult)
            : base(administrativeAreal2DStatisticalUnitsCalculcationResult)
        {
            if(administrativeAreal2DStatisticalUnitsCalculcationResult != null)
            {
                StatisticalUnits = administrativeAreal2DStatisticalUnitsCalculcationResult.StatisticalUnits;
            }
        }

        [JsonInclude, JsonPropertyName("StatisticalUnits")]
        public IEnumerable< StatisticalUnit> StatisticalUnits
        {
            get
            {
                return dictionary.Values;
            }

            private set
            {
                dictionary.Clear();
                if(value == null)
                {
                    return;
                }

                foreach(StatisticalUnit statisticalUnit in value)
                {
                    if(statisticalUnit?.Code == null)
                    {
                        continue;
                    }

                    dictionary[statisticalUnit.Code] = statisticalUnit;
                }
            }
        }
    }
}