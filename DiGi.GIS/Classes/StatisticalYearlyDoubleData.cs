using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public class StatisticalYearlyDoubleData : StatisticalYearlyData<double>
    {
        public StatisticalYearlyDoubleData(string name, string reference)
            : base(name, reference)
        {

        }

        public StatisticalYearlyDoubleData(string name, string reference, IEnumerable<KeyValuePair<short, double>> values)
            : base(name, reference, values)
        {

        }

        public StatisticalYearlyDoubleData(StatisticalYearlyDoubleData statisticalYearlyDoubleData)
            : base(statisticalYearlyDoubleData)
        {

        }

        public StatisticalYearlyDoubleData(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
