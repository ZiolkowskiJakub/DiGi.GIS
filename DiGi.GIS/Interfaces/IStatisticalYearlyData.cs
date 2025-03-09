using System.Collections.Generic;

namespace DiGi.GIS.Interfaces
{
    public interface IStatisticalYearlyData : IStatisticalData
    {
        IEnumerable<short> Years { get; }
    }

    public interface IStatisticalYearlyData<T> : IStatisticalYearlyData
    {
        T this[short year] { get; }
    }
}
