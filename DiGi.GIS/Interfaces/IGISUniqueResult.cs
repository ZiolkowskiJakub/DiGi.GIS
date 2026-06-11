using DiGi.Core.Interfaces;

namespace DiGi.GIS.Interfaces
{
    /// <summary>
    /// Defines the contract for a unique GIS result object, inheriting from both <see cref="IUniqueResult"/> and <see cref="IGISUniqueObject"/>.
    /// </summary>
    public interface IGISUniqueResult : IUniqueResult, IGISUniqueObject
    {
    }
}