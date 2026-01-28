using System.ComponentModel;

namespace DiGi.GIS.Enums
{
    public enum BuildingShape
    {
        [Description("Undefined")] Undefined,
        [Description("Square")] Square,
        [Description("Rectangular")] Rectangular,
        [Description("Circural")] Circural,
        [Description("L")] L,
        [Description("H")] H,
        [Description("U")] U,
        [Description("O")] O,
        [Description("E")] E,
        [Description("F")] F,
        [Description("T")] T,
        [Description("X")] X,
        [Description("Other")] Other,
    }
}