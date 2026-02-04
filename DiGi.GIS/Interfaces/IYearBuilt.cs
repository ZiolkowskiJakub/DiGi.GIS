using DiGi.GIS.Enums;

namespace DiGi.GIS.Interfaces
{
    public interface IYearBuilt : IGISSerializableObject
    {
        public string? Source { get; }

        public short Year { get; }

        public YearBuiltSource YearBuiltSource { get; }
    }
}