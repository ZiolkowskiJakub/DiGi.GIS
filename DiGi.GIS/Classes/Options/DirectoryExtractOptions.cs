using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Provides options for directory extraction processes, specifying source and destination paths along with file and directory naming conventions.
    /// </summary>
    public class DirectoryExtractOptions : ExtractOptions
    {
        /// <summary>
        /// Gets or sets the path to the source directory from which data is extracted.
        /// </summary>
        [JsonInclude, JsonPropertyName("SourcePath")]
        public string? SourcePath { get; set; } = null;

        /// <summary>
        /// Gets or sets the path to the destination directory where extracted data will be stored.
        /// </summary>
        [JsonInclude, JsonPropertyName("DestionationDirectory")]
        public string? DestionationDirectory { get; set; } = null;

        /// <summary>
        /// Gets or sets a value indicating whether existing files in the destination directory should be updated.
        /// </summary>
        [JsonInclude, JsonPropertyName("UpdateExisting")]
        public bool UpdateExisting { get; set; } = true;

        /// <summary>
        /// Gets or sets the file name used for Building 2D data extraction.
        /// </summary>
        [JsonInclude, JsonPropertyName("Building2DFileName")]
        public string Building2DFileName { get; set; } = Constants.FileName.Building2D;

        /// <summary>
        /// Gets or sets the directory name used for storing Buildings data.
        /// </summary>
        [JsonInclude, JsonPropertyName("BuildingsDirectoryName")]
        public string BuildingsDirectoryName { get; set; } = Constants.DirectoryName.Buildings;

        /// <summary>
        /// Gets or sets the file name used for Administrative Areal 2D data extraction.
        /// </summary>
        [JsonInclude, JsonPropertyName("AdministrativeAreal2DFileName")]
        public string AdministrativeAreal2DFileName { get; set; } = Constants.FileName.AdministrativeAreal2D;

        /// <summary>
        /// Gets or sets the directory name used for storing Administrative Areals data.
        /// </summary>
        [JsonInclude, JsonPropertyName("AdministrativeArealsDirectoryName")]
        public string AdministrativeArealsDirectoryName { get; set; } = Constants.DirectoryName.AdministrativeAreals;

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryExtractOptions"/> class with specified source and destination paths.
        /// </summary>
        /// <param name="sourcePath">The path to the source directory.</param>
        /// <param name="destionationDirectory">The path to the destination directory.</param>
        public DirectoryExtractOptions(string? sourcePath, string? destionationDirectory)
            : base()
        {
            SourcePath = sourcePath;
            DestionationDirectory = destionationDirectory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryExtractOptions"/> class.
        /// </summary>
        public DirectoryExtractOptions()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryExtractOptions"/> class using a JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the configuration options.</param>
        public DirectoryExtractOptions(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}