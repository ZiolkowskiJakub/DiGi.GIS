using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents the result of calculating statistical units for a 2D administrative area.
    /// </summary>
    public class AdministrativeAreal2DStatisticalUnitsCalculcationResult : GuidResult<AdministrativeAreal2D>, IGISUniqueResult
    {
        [JsonIgnore]
        private readonly Dictionary<string, StatisticalUnit> dictionary = [];

        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrativeAreal2DStatisticalUnitsCalculcationResult"/> class using a collection of statistical units.
        /// </summary>
        /// <param name="statisticalUnits">The collection of statistical units to assign.</param>
        public AdministrativeAreal2DStatisticalUnitsCalculcationResult(IEnumerable<StatisticalUnit> statisticalUnits)
            : base()
        {
            StatisticalUnits = statisticalUnits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrativeAreal2DStatisticalUnitsCalculcationResult"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the result data.</param>
        public AdministrativeAreal2DStatisticalUnitsCalculcationResult(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdministrativeAreal2DStatisticalUnitsCalculcationResult"/> class by copying another result instance.
        /// </summary>
        /// <param name="administrativeAreal2DStatisticalUnitsCalculcationResult">The source result instance to copy from.</param>
        public AdministrativeAreal2DStatisticalUnitsCalculcationResult(AdministrativeAreal2DStatisticalUnitsCalculcationResult administrativeAreal2DStatisticalUnitsCalculcationResult)
            : base(administrativeAreal2DStatisticalUnitsCalculcationResult)
        {
            if (administrativeAreal2DStatisticalUnitsCalculcationResult != null)
            {
                StatisticalUnits = administrativeAreal2DStatisticalUnitsCalculcationResult.StatisticalUnits;
            }
        }

        /// <summary>
        /// Gets or sets the collection of statistical units associated with this calculation result.
        /// </summary>
        [JsonInclude, JsonPropertyName("StatisticalUnits")]
        public IEnumerable<StatisticalUnit> StatisticalUnits
        {
            get
            {
                return dictionary.Values;
            }

            private set
            {
                dictionary.Clear();
                if (value == null)
                {
                    return;
                }

                foreach (StatisticalUnit statisticalUnit in value)
                {
                    if (statisticalUnit?.Code == null)
                    {
                        continue;
                    }

                    dictionary[statisticalUnit.Code] = statisticalUnit;
                }
            }
        }
    }
}