using DiGi.Core.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public class OrtoDatasOrtoRangeOptions : OrtoDatasOptions
    {
        [JsonInclude, JsonPropertyName("Scale")]
        public double Scale { get; set; } = 3;

        public OrtoDatasOrtoRangeOptions(Range<int> years, double scale, bool reduce, ulong maxFileSize)
            : base(years, reduce, maxFileSize)
        {
            Scale = scale;
        }

        public OrtoDatasOrtoRangeOptions()
            : base()
        {
            DirectoryNames = Query.OrtoDatasDirectoryNames_OrtoRange();
        }

        public OrtoDatasOrtoRangeOptions(OrtoDatasOrtoRangeOptions ortoDatasOrtoRangeOptions)
            : base(ortoDatasOrtoRangeOptions)
        {
            if (ortoDatasOrtoRangeOptions != null)
            {
                Scale = ortoDatasOrtoRangeOptions.Scale;  
            }
        }

        public OrtoDatasOrtoRangeOptions(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}

