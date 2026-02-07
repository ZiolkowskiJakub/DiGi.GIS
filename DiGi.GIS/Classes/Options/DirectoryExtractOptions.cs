using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public class DirectoryExtractOptions : ExtractOptions
    {
        [JsonInclude, JsonPropertyName("SourcePath")]
        public string? SourcePath { get; set; } = null;

        [JsonInclude, JsonPropertyName("DestionationDirectory")]
        public string? DestionationDirectory { get; set; } = null;

        [JsonInclude, JsonPropertyName("UpdateExisting")]
        public bool UpdateExisting { get; set; } = true;

        [JsonInclude, JsonPropertyName("Building2DFileName")]
        public string Building2DFileName { get; set; } = Constants.FileName.Building2D;

        [JsonInclude, JsonPropertyName("BuildingsDirectoryName")]
        public string BuildingsDirectoryName { get; set; } = Constants.DirectoryName.Buildings;

        [JsonInclude, JsonPropertyName("AdministrativeAreal2DFileName")]
        public string AdministrativeAreal2DFileName { get; set; } = Constants.FileName.AdministrativeAreal2D;

        [JsonInclude, JsonPropertyName("AdministrativeArealsDirectoryName")]
        public string AdministrativeArealsDirectoryName { get; set; } = Constants.DirectoryName.AdministrativeAreals;

        public DirectoryExtractOptions(string? sourcePath, string? destionationDirectory)
            : base()
        {
            SourcePath = sourcePath;
            DestionationDirectory = destionationDirectory;
        }

        public DirectoryExtractOptions()
            : base()
        {
        }

        public DirectoryExtractOptions(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}