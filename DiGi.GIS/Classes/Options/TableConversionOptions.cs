﻿using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Core.Classes;

namespace DiGi.GIS.Classes
{
    public abstract class TableConversionOptions : Options
    {
        [JsonInclude, JsonPropertyName("IncludeModel")]
        public bool IncludeModel { get; set; } = true;
        
        [JsonInclude, JsonPropertyName("IncludeStatistical")]
        public bool IncludeStatistical { get; set; } = true;

        [JsonInclude, JsonPropertyName("IncludeYearBuiltData")]
        public bool IncludeYearBuilt { get; set; } = true;

        [JsonInclude, JsonPropertyName("YearBuiltOnly")]
        public bool YearBuiltOnly { get; set; } = true;

        [JsonInclude, JsonPropertyName("Years")]
        public Range<int> Years { get; set; } = new Range<int>(2008, System.DateTime.Now.Year);

        [JsonInclude, JsonPropertyName("StatisticalDirectory")]
        public string StatisticalDirectory { get; set; } = null;

        public TableConversionOptions()
        {

        }

        public TableConversionOptions(TableConversionOptions tableConversionOptions)
        {
            if(tableConversionOptions != null)
            {
                IncludeModel = tableConversionOptions.IncludeModel;
                IncludeStatistical = tableConversionOptions.IncludeStatistical;
                IncludeYearBuilt = tableConversionOptions.IncludeYearBuilt;
                YearBuiltOnly = tableConversionOptions.YearBuiltOnly;
                Years = Core.Query.Clone(tableConversionOptions.Years);
                StatisticalDirectory = tableConversionOptions.StatisticalDirectory;
            }
        }

        public TableConversionOptions(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

    }
}
