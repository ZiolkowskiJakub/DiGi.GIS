using System.ComponentModel;

namespace DiGi.GIS.Enums
{
    /// <summary>
    /// Specifies the coordinate system context for a geometry.
    /// </summary>
    public enum GeometryContext
    {
        /// <summary>
        /// The geometry context is undefined.
        /// </summary>
        [Description("Undefined")] Undefined,

        /// <summary>
        /// The geometry context is local.
        /// </summary>
        [Description("Local")] Local,

        /// <summary>
        /// The geometry context is global.
        /// </summary>
        [Description("Global")] Global,
    }
}