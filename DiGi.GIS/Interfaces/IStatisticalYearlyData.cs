using System.Collections.Generic;

namespace DiGi.GIS.Interfaces
{
    /// <summary>
    /// Defines a contract for statistical data that is organized by year.
    /// </summary>
    public interface IStatisticalYearlyData : IStatisticalData
    {
        /// <summary>
        /// Gets the collection of years available in the statistical data.
        /// </summary>
        IEnumerable<short>? Years { get; }
    }

    /// <summary>
    /// Defines a generic contract for accessing statistical data values associated with specific years.
    /// </summary>
    /// <typeparam name="T">The type of the statistical data value.</typeparam>
    public interface IStatisticalYearlyData<T> : IStatisticalYearlyData
    {
        /// <summary>
        /// Gets the statistical data value for the specified year.
        /// </summary>
        /// <param name="year">The year for which to retrieve the statistical data.</param>
        /// <returns>The statistical data value of type <typeparamref name="T"/> associated with the given year, or null if not found.</returns>
        T? this[short year] { get; }
    }
}