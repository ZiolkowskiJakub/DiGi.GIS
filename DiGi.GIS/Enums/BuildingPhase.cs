using System.ComponentModel;

namespace DiGi.GIS.Enums
{
    /// <summary>
    /// Specifies the current phase or status of a building.
    /// </summary>
    public enum BuildingPhase
    {
        /// <summary>
        /// The building is currently in use.
        /// </summary>
        [Description("in use")] occupied,

        /// <summary>
        /// The building is not currently occupied.
        /// </summary>
        [Description("unoccupied")] unoccupied,

        /// <summary>
        /// The building is currently under construction.
        /// </summary>
        [Description("under construction")] under_construction,

        /// <summary>
        /// The building has been destroyed.
        /// </summary>
        [Description("destroyed")] destroyed,
    }
}