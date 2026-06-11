namespace DiGi.GIS.Interfaces
{
    /// <summary>
    /// Defines the properties for data representing the year a structure was built.
    /// </summary>
    public interface IYearBuiltData : IGISGuidObject
    {
        /// <summary>
        /// Gets the reference identifier or description associated with the year built data.
        /// </summary>
        public string? Reference { get; }

        //public short Year { get; }
    }
}