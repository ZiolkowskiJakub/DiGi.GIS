namespace DiGi.GIS.Interfaces
{
    /// <summary>
    /// Defines the properties for occupancy data objects within the GIS system.
    /// </summary>
    public interface IOccupancyData : IGISGuidObject
    {
        /// <summary>
        /// Gets the reference identifier associated with the occupancy data.
        /// </summary>
        public string? Reference { get; }
    }
}