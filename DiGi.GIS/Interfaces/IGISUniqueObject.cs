using DiGi.Core.Interfaces;

namespace DiGi.GIS.Interfaces
{
    /// <summary>
    /// Defines a contract for an object that is both uniquely identifiable and serializable within the GIS context.
    /// </summary>
    public interface IGISUniqueObject : IGISSerializableObject, IUniqueObject
    {
    }
}