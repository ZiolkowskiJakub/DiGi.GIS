namespace DiGi.GIS.Interfaces
{
    /// <summary>
    /// Defines the contract for a data source that is based on a directory.
    /// </summary>
    internal interface IDirectorySource : ISource
    {
        /// <summary>
        /// Gets the path of the directory associated with this source.
        /// </summary>
        public string? Directory { get; }
    }
}