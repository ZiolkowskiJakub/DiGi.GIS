namespace DiGi.GIS.Interfaces
{
    public interface IStatisticalData : IGISSerializableObject
    {
        string? Name { get; }

        string? Reference { get; }
    }
}