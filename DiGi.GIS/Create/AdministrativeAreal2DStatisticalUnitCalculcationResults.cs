using DiGi.GIS.Classes;
using DiGi.GIS.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.GIS
{
    public static partial class Create
    {
        public static List<AdministrativeAreal2DStatisticalUnitCalculcationResult> AdministrativeAreal2DStatisticalUnitCalculcationResults(this GISModel gISModel, StatisticalUnit statisticalUnit)
        {
            if(gISModel == null || statisticalUnit == null)
            {
                return null;
            }

            List<AdministrativeAreal2D> administrativeAreal2Ds = gISModel.GetObjects<AdministrativeAreal2D>();
            if(administrativeAreal2Ds == null || administrativeAreal2Ds.Count == 0)
            {
                return null;
            }

            List<AdministrativeAreal2DStatisticalUnitCalculcationResult> result = new List<AdministrativeAreal2DStatisticalUnitCalculcationResult>();

            for (int i = administrativeAreal2Ds.Count - 1; i >= 0; i--)
            {
                AdministrativeAreal2D administrativeAreal2D = administrativeAreal2Ds[i];

                List<Tuple<StatisticalUnit, AdministrativeAreal2D>> tuples = new List<Tuple<StatisticalUnit, AdministrativeAreal2D>>();

                IEnumerable<StatisticalUnit> statisticalUnits = statisticalUnit.GetStatisticalUnits(true, x => x.Name.ToUpper().Trim() == administrativeAreal2D.Name.ToUpper().Trim());
                if (statisticalUnits != null && statisticalUnits.Count() != 0)
                {
                    foreach (StatisticalUnit statisticalUnit_Temp in statisticalUnits)
                    {
                        tuples.Add(new Tuple<StatisticalUnit, AdministrativeAreal2D>(statisticalUnit_Temp, administrativeAreal2D));
                    }
                }

                if (gISModel.TryGetRelatedObjects<AdministrativeAreal2D, AdministrativeAreal2DAdministrativeAreal2DsRelation>(administrativeAreal2D, out List<AdministrativeAreal2D> administrativeAreal2Ds_Related) && administrativeAreal2Ds_Related != null)
                {
                    foreach (AdministrativeAreal2D administrativeAreal2D_Related in administrativeAreal2Ds_Related)
                    {
                        statisticalUnits = statisticalUnit.GetStatisticalUnits(true, x => x.Name.ToUpper().Trim() == administrativeAreal2D_Related.Name.ToUpper().Trim());
                        if (statisticalUnits != null && statisticalUnits.Count() != 0)
                        {
                            foreach (StatisticalUnit statisticalUnit_Temp in statisticalUnits)
                            {
                                tuples.Add(new Tuple<StatisticalUnit, AdministrativeAreal2D>(statisticalUnit_Temp, administrativeAreal2D_Related));
                            }
                        }
                    }
                }

                if (tuples == null || tuples.Count == 0)
                {
                    throw new NotImplementedException();
                }

                List<StatisticalUnitType> statisticalUnitTypes = new List<StatisticalUnitType>(Enum.GetValues(typeof(StatisticalUnitType)).Cast<StatisticalUnitType>());
                statisticalUnitTypes.Sort((x, y) => y.CompareTo(x));
                
                foreach(StatisticalUnitType statisticalUnitType in statisticalUnitTypes)
                {
                    List<Tuple<StatisticalUnit, AdministrativeAreal2D>> tuples_StatisticalUnitType = tuples.FindAll(x => x.Item1.GetStatisticalUnitType() == statisticalUnitType);
                    if(tuples.Count == 0)
                    {
                        continue;
                    }

                    if (tuples_StatisticalUnitType.Count == 1)
                    {
                        StatisticalUnit statisticalUnit_Temp = tuples_StatisticalUnitType[0].Item1;

                        result.Add(new AdministrativeAreal2DStatisticalUnitCalculcationResult(statisticalUnit_Temp.UnitCode, statisticalUnit_Temp.Name));
                        break;
                    }
                }
            }

            return result;
        }
    }
}

