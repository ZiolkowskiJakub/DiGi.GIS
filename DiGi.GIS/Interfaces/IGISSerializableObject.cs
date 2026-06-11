using DiGi.Core.Interfaces;

namespace DiGi.GIS.Interfaces
{
    /// <summary>
    /// Defines a contract for objects that are both GIS-compatible and serializable.
    /// </summary>
    public interface IGISSerializableObject : IGISObject, ISerializableObject
    {
    }
}