using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a file containing statistical unit data.
    /// </summary>
    public class StatisticalUnitFile : Core.IO.File.Classes.ValueFile<StatisticalUnit>, IGISObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticalUnitFile"/> class based on an existing instance.
        /// </summary>
        /// <param name="statisticalUnitFile">The source StatisticalUnitFile instance to copy from.</param>
        public StatisticalUnitFile(StatisticalUnitFile? statisticalUnitFile)
            : base(statisticalUnitFile)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticalUnitFile"/> class using a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the file data.</param>
        public StatisticalUnitFile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticalUnitFile"/> class from the specified path.
        /// </summary>
        /// <param name="path">The file system path to the statistical unit file.</param>
        public StatisticalUnitFile(string? path)
            : base(path)
        {
        }
    }
}