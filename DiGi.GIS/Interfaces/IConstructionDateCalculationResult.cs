using System;

namespace DiGi.GIS.Interfaces
{
    /// <summary>
    /// Defines the contract for an object representing the result of a construction date calculation.
    /// </summary>
    public interface IConstructionDateCalculationResult : IGISGuidResult
    {
        /// <summary>
        /// Gets the calculated construction date and time.
        /// </summary>
        DateTime DateTime { get; }
    }
}