using DiGi.Core.Interfaces;

namespace DiGi.GIS.Interfaces
{
    public interface IStatisticalData : IGISObject, ISerializableObject
    {
        string Name { get; }

        string Reference { get; }
    }
}
