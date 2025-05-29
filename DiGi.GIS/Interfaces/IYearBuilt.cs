using DiGi.Core.Interfaces;
using DiGi.GIS.Enums;

namespace DiGi.GIS.Interfaces
{
    public interface IYearBuilt : IGISObject, ISerializableObject
    {
        public string Source { get; }

        public short Year { get; }

        public YearBuiltSource YearBuiltSource { get; }
    }
}
