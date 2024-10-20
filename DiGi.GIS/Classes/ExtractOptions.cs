using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;

namespace DiGi.GIS.Classes
{
    public class ExtractOptions : SerializableObject, IGISObject
    {
        [JsonInclude, JsonPropertyName("SourcePath")]
        public string SourcePath { get; set; } = null;

        [JsonInclude, JsonPropertyName("DestionationDirectory")]
        public string DestionationDirectory { get; set; } = null;

        [JsonInclude, JsonPropertyName("UpdateExisting")]
        public bool UpdateExisting { get; set; } = true;

        [JsonInclude, JsonPropertyName("Building2DFileName")]
        public string Building2DFileName { get; set; } = Constans.FileName.Building2D;

        [JsonInclude, JsonPropertyName("BuildingsDirectoryName")]
        public string BuildingsDirectoryName { get; set; } = Constans.DirectoryName.Buildings;

        [JsonInclude, JsonPropertyName("AdministrativeAreal2DFileName")]
        public string AdministrativeAreal2DFileName { get; set; } = Constans.FileName.AdministrativeAreal2D;

        [JsonInclude, JsonPropertyName("AdministrativeArealsDirectoryName")]
        public string AdministrativeArealsDirectoryName { get; set; } = Constans.DirectoryName.AdministrativeAreals;

        public ExtractOptions(string sourcePath, string destionationDirectory)
        {
            SourcePath = sourcePath;
            DestionationDirectory = destionationDirectory;
        }

        public ExtractOptions()
        {

        }

        public ExtractOptions(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

    }
}
