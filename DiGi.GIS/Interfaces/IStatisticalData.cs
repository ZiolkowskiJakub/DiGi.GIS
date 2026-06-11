namespace DiGi.GIS.Interfaces
{
    /// <summary>
    /// Defines the properties for an object that represents statistical data.
    /// </summary>
    public interface IStatisticalData : IGISSerializableObject
    {
        /// <summary>
        /// Gets the name of the statistical data.
        /// </summary>
        string? Name { get; }

        /// <summary>
        /// Gets the reference identifier associated with the statistical data.
        /// </summary>
        string? Reference { get; }
    }
}