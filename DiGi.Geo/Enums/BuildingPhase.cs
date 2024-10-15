using System.ComponentModel;

namespace DiGi.Geo.Enums
{
    public enum BuildingPhase
    {
        [Description("in use")] occupied,
        [Description("unoccupied")] unoccupied,
        [Description("under construction")] under_construction,
        [Description("destroyed")] destroyed,
    }
}
