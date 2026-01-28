using System.ComponentModel;

namespace DiGi.GIS.Enums
{
    public enum CardinalDirection
    {
        [Description("Undefined")] Undefined,
        [Description("North")] North,
        [Description("North East")] NorthEast,
        [Description("East")] East,
        [Description("South East")] SouthEast,
        [Description("South")] South,
        [Description("South West")] SouthWest,
        [Description("West")] West,
        [Description("North West")] NorthWest
    }
}