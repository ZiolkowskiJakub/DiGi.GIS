using System;

namespace DiGi.GIS.Interfaces
{
    public interface IConstructionDateCalculationResult : IGISGuidResult
    {
        DateTime DateTime { get; }
    }
}
