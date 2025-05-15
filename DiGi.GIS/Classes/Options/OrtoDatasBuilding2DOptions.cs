using DiGi.Core.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public class OrtoDatasBuilding2DOptions : OrtoDatasOptions
    {
        [JsonInclude, JsonPropertyName("Offset")]
        public double Offset { get; set; } = 5;

        [JsonInclude, JsonPropertyName("Width")]
        public double Width { get; set; } = 320;

        public OrtoDatasBuilding2DOptions(Range<int> years, double offset, double width, bool reduce, ulong maxFileSize)
            : base(years, reduce, maxFileSize)
        {
            Width = width;
            Offset = offset;
        }

        public OrtoDatasBuilding2DOptions()
            : base()
        {
            DirectoryNames = Query.OrtoDatasDirectoryNames_Building2D();
        }

        public OrtoDatasBuilding2DOptions(OrtoDatasBuilding2DOptions ortoDatasBuilding2DOptions)
            : base(ortoDatasBuilding2DOptions)
        {
            if (ortoDatasBuilding2DOptions != null)
            {
                Width = ortoDatasBuilding2DOptions.Width;
                Offset = ortoDatasBuilding2DOptions.Offset;
            }
        }

        public OrtoDatasBuilding2DOptions(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}

