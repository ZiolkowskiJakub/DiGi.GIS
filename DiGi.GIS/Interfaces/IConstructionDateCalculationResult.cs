using System;

namespace DiGi.GIS.Interfaces
{
    public interface IConstructionDateCalculationResult : IGISUniqueResult
    {
        DateTime DateTime { get; }
    }
}
