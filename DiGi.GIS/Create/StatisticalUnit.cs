using DiGi.GIS.Classes;
using DiGi.BDL.Classes;
using System;
using System.Collections.Generic;

namespace DiGi.GIS
{
    public static partial class Create
    {
        public static StatisticalUnit StatisticalUnit(this IEnumerable<Unit> units)
        {
            if (units == null)
            {
                return null;
            }

            List<Unit> units_Temp = new List<Unit>(units);

            List<StatisticalUnit> statisticalUnits = new List<StatisticalUnit>();

            for (int i = 7; i >=0; i--)
            {
                Core.Query.Filter(units_Temp, x => x.level == i, out List<Unit> units_Level, out units_Temp);

                foreach(Unit unit_Level in units_Level)
                {
                    string id = unit_Level.id;
                    if(string.IsNullOrWhiteSpace(id))
                    {
                        continue;
                    }

                    while(id.EndsWith("0"))
                    {
                        id = id.Substring(0, id.Length - 1);
                    }

                    Core.Query.Filter(statisticalUnits, x => x.Reference.StartsWith(id), out List<StatisticalUnit> statisticalUnits_Unit, out statisticalUnits);

                    statisticalUnits.Add(new StatisticalUnit(Guid.NewGuid(), unit_Level.id, unit_Level.name, (Enums.StatisticalUnitType)unit_Level.level, statisticalUnits_Unit));
                }
            }

            if(statisticalUnits == null || statisticalUnits.Count  == 0)
            {
                return null;
            }

            statisticalUnits.Sort((x, y) => ((int)x.StatisticalUnitType).CompareTo((int)y.StatisticalUnitType));

            return statisticalUnits[0];
        }
    }
}
