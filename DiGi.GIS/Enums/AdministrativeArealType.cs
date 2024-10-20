using System.ComponentModel;

namespace DiGi.GIS.Enums
{
    public enum AdministrativeArealType
    {
        [Description("city")] city,
        [Description("part of a city")] part_of_city,
        [Description("village")] village,
        [Description("part of a village")] part_of_village,
        [Description("colony")] colony,
        [Description("part of a colony")] part_of_colony,
        [Description("settlement")] settlement,
        [Description("part of a settlement")] part_of_settlement,
        [Description("housing estate")] housing_estate,
        [Description("hamlet")] hamlet,
        [Description("forest settlement")] forest_settlement,
        [Description("other")] other,
    }
}
