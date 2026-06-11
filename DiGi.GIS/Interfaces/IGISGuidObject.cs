using DiGi.Core.Interfaces;

namespace DiGi.GIS.Interfaces
{
    /// <summary>
    /// Defines an object that integrates both GIS uniqueness and GUID identification capabilities.
    /// </summary>
    public interface IGISGuidObject : IGISUniqueObject, IGuidObject
    {
    }
}