using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Core.Classes;

namespace DiGi.Geo.Classes
{
    public class ExtractOptions : SerializableObject
    {
        [JsonInclude, JsonPropertyName("SourcePath")]
        public string SourcePath { get; set; } = null;

        [JsonInclude, JsonPropertyName("DestionationDirectory")]
        public string DestionationDirectory { get; set; } = null;

        [JsonInclude, JsonPropertyName("UpdateExisting")]
        public bool UpdateExisting { get; set; } = true;

        [JsonInclude, JsonPropertyName("FileName")]
        public string FileName { get; set; } = "Building2D.json";

        [JsonInclude, JsonPropertyName("DirectoryName")]
        public string DirectoryName { get; set; } = "buildings";

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
