using DiGi.GIS.Enums;

namespace DiGi.GIS.Interfaces
{
    /// <summary>
    /// Defines the properties for an object that represents the year a structure was built.
    /// </summary>
    public interface IYearBuilt : IGISSerializableObject
    {
        /// <summary>
        /// Gets the source description of the year built information.
        /// </summary>
        public string? Source { get; }

        /// <summary>
        /// Gets the year the structure was built.
        /// </summary>
        public short Year { get; }

        /// <summary>
        /// Gets the categorized source of the year built information.
        /// </summary>
        public YearBuiltSource YearBuiltSource { get; }
    }
}