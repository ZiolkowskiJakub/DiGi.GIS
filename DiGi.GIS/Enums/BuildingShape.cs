using System.ComponentModel;

namespace DiGi.GIS.Enums
{
    /// <summary>
    /// Specifies the geometric shape of a building.
    /// </summary>
    public enum BuildingShape
    {
        /// <summary>
        /// The building shape is undefined.
        /// </summary>
        [Description("Undefined")] Undefined,

        /// <summary>
        /// The building has a square shape.
        /// </summary>
        [Description("Square")] Square,

        /// <summary>
        /// The building has a rectangular shape.
        /// </summary>
        [Description("Rectangular")] Rectangular,

        /// <summary>
        /// The building has a circular shape.
        /// </summary>
        [Description("Circural")] Circural,

        /// <summary>
        /// The building has an L-shape.
        /// </summary>
        [Description("L")] L,

        /// <summary>
        /// The building has an H-shape.
        /// </summary>
        [Description("H")] H,

        /// <summary>
        /// The building has a U-shape.
        /// </summary>
        [Description("U")] U,

        /// <summary>
        /// The building has an O-shape.
        /// </summary>
        [Description("O")] O,

        /// <summary>
        /// The building has an E-shape.
        /// </summary>
        [Description("E")] E,

        /// <summary>
        /// The building has an F-shape.
        /// </summary>
        [Description("F")] F,

        /// <summary>
        /// The building has a T-shape.
        /// </summary>
        [Description("T")] T,

        /// <summary>
        /// The building has an X-shape.
        /// </summary>
        [Description("X")] X,

        /// <summary>
        /// The building has another shape not specified in the list.
        /// </summary>
        [Description("Other")] Other,
    }
}