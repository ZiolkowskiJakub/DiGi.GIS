using DiGi.Core.Interfaces;

namespace DiGi.GIS.Interfaces
{
    public interface IYearBuiltData : IGISObject, ISerializableObject
    {
        public string Reference { get; }

        public short Year { get; }
    }
}
