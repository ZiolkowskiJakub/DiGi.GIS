using System.ComponentModel;

namespace DiGi.GIS.Enums
{
    /// <summary>
    /// Represents the cardinal and intercardinal directions used for geographic orientation.
    /// </summary>
    public enum CardinalDirection
    {
        /// <summary>
        /// The direction is undefined or unknown.
        /// </summary>
        [Description("Undefined")] Undefined,

        /// <summary>
        /// Represents the North direction.
        /// </summary>
        [Description("North")] North,

        /// <summary>
        /// Represents the North East direction.
        /// </summary>
        [Description("North East")] NorthEast,

        /// <summary>
        /// Represents the East direction.
        /// </summary>
        [Description("East")] East,

        /// <summary>
        /// Represents the South East direction.
        /// </summary>
        [Description("South East")] SouthEast,

        /// <summary>
        /// Represents the South direction.
        /// </summary>
        [Description("South")] South,

        /// <summary>
        /// Represents the South West direction.
        /// </summary>
        [Description("South West")] SouthWest,

        /// <summary>
        /// Represents the West direction.
        /// </summary>
        [Description("West")] West,

        /// <summary>
        /// Represents the North West direction.
        /// </summary>
        [Description("North West")] NorthWest
    }
}