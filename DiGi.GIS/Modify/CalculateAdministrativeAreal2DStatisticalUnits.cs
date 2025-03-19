using DiGi.GIS.Classes;
using DiGi.GIS.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.GIS
{
    public static partial class Modify
    {
        public static void CalculateAdministrativeAreal2DStatisticalUnits(this GISModel gISModel, StatisticalUnit statisticalUnit, out List<AdministrativeAreal2D> invalidAdministrativeAreal2Ds)
        {
            invalidAdministrativeAreal2Ds = null;

            if (gISModel == null || statisticalUnit == null)
            {
                return;
            }

            List<AdministrativeDivision> administrativeDivisions = gISModel.GetObjects<AdministrativeDivision>();
            if (administrativeDivisions == null || administrativeDivisions.Count == 0)
            {
                return;
            }

            List<Tuple<AdministrativeAreal2D, List<StatisticalUnit>>> tuples = new List<Tuple<AdministrativeAreal2D, List<StatisticalUnit>>>();

            Func<StatisticalUnit, AdministrativeDivision, bool, bool> similar_AdministrativeDivision = new Func<StatisticalUnit, AdministrativeDivision, bool, bool>((StatisticalUnit statisticalUnit, AdministrativeDivision administrativeDivision, bool contains) =>
            {
                if (statisticalUnit == null && administrativeDivision == null)
                {
                    return true;
                }

                if (statisticalUnit == null || administrativeDivision == null)
                {
                    return false;
                }

                if (statisticalUnit.Name == null)
                {
                    return false;
                }

                if (administrativeDivision.AdministrativeDivisionType == AdministrativeDivisionType.county)
                {
                    return statisticalUnit.Name.ToUpper().EndsWith(administrativeDivision.Name.ToUpper());
                }
                else if (administrativeDivision.AdministrativeDivisionType == AdministrativeDivisionType.municipality)
                {
                    if (statisticalUnit.GetStatisticalUnitType() == StatisticalUnitType.municipalities)
                    {
                        string name = administrativeDivision.Name?.ToUpper();
                        if (name.StartsWith("M. ST."))
                        {
                            name = name.Replace(" ", string.Empty) + " OD 2002";
                        }
                        else if (name.StartsWith("M."))
                        {
                            name = name.Substring(2).Trim();
                        }

                        return contains ? statisticalUnit.Name.ToUpper().Contains(name) : statisticalUnit.Name.ToUpper() == name;
                    }
                }
                else if (administrativeDivision.AdministrativeDivisionType == AdministrativeDivisionType.district_or_delegation)
                {
                    if (statisticalUnit.MunicipalityType() == MunicipalityType.Warsaw_district)
                    {
                        return statisticalUnit.Name.ToUpper().StartsWith(administrativeDivision.Name.ToUpper());
                    }
                }

                return statisticalUnit.Name?.ToUpper() == administrativeDivision.Name?.ToUpper();
            });

            invalidAdministrativeAreal2Ds = new List<AdministrativeAreal2D>();

            foreach (AdministrativeDivisionType administrativeDivisionType in Enum.GetValues(typeof(AdministrativeDivisionType)))
            {
                List<AdministrativeDivision> administrativeDivisions_Temp = administrativeDivisions.FindAll(x => x.AdministrativeDivisionType == administrativeDivisionType);
                if(administrativeDivisions_Temp.Count == 0)
                {
                    continue;
                }

                foreach(AdministrativeDivision administrativeDivision in administrativeDivisions_Temp)
                {
                    if(similar_AdministrativeDivision.Invoke(statisticalUnit, administrativeDivision, false))
                    {
                        tuples.Add(new Tuple<AdministrativeAreal2D, List<StatisticalUnit>>(administrativeDivision, new List<StatisticalUnit>() { statisticalUnit }));
                        continue;
                    }

                    List<StatisticalUnit> statisticalUnits_Temp = statisticalUnit.GetStatisticalUnits(true, x => similar_AdministrativeDivision.Invoke(x, administrativeDivision, false))?.ToList();
                    if (statisticalUnits_Temp == null || statisticalUnits_Temp.Count == 0)
                    {
                        statisticalUnits_Temp = statisticalUnit.GetStatisticalUnits(true, x => similar_AdministrativeDivision.Invoke(x, administrativeDivision, true))?.ToList();
                    }

                    if (statisticalUnits_Temp == null || statisticalUnits_Temp.Count == 0)
                    {
                        invalidAdministrativeAreal2Ds.Add(administrativeDivision);
                        continue;
                    }

                    if (statisticalUnits_Temp != null && statisticalUnits_Temp.Count != 0)
                    {
                        if (statisticalUnits_Temp.Count > 1)
                        {
                            for (int i = statisticalUnits_Temp.Count - 1; i >= 0; i--)
                            {
                                StatisticalUnit statisticalUnit_Parent = statisticalUnit.Find(statisticalUnits_Temp[i].UnitCode.GetParent(), true);
                                if (tuples.Find(x => x.Item2.Find(y => y.Code == statisticalUnit_Parent.Code) != null) == null)
                                {
                                    statisticalUnits_Temp.RemoveAt(i);
                                }
                            }
                        }

                        Dictionary<string, StatisticalUnit> dictionary = new Dictionary<string, StatisticalUnit>();
                        foreach (StatisticalUnit statisticalUnit_Temp in statisticalUnits_Temp)
                        {
                            if (!dictionary.ContainsKey(statisticalUnit_Temp.Code))
                            {
                                dictionary[statisticalUnit_Temp.Code] = statisticalUnit_Temp;
                            }

                            StatisticalUnitType? statisticalUnitType = statisticalUnit_Temp.GetStatisticalUnitType();
                            if (statisticalUnitType == null || statisticalUnitType.Value != StatisticalUnitType.municipalities)
                            {
                                continue;
                            }

                            string code = statisticalUnit_Temp.Code;

                            code = code.Substring(0, code.Length - 1);

                            IEnumerable<StatisticalUnit> statisticalUnits_Code = statisticalUnit.GetStatisticalUnits(true, x => x.Code.StartsWith(code));
                            if (statisticalUnits_Code != null)
                            {
                                foreach (StatisticalUnit statisticalUnit_Code in statisticalUnits_Code)
                                {
                                    if (!dictionary.ContainsKey(statisticalUnit_Code.Code))
                                    {
                                        dictionary[statisticalUnit_Code.Code] = statisticalUnit_Code;
                                    }
                                }
                            }
                        }

                        if(dictionary.Count != 0)
                        {
                            tuples.Add(new Tuple<AdministrativeAreal2D, List<StatisticalUnit>>(administrativeDivision, new List<StatisticalUnit>(dictionary.Values)));
                        }
                    }

                    if (statisticalUnits_Temp == null || statisticalUnits_Temp.Count == 0)
                    {
                        invalidAdministrativeAreal2Ds.Add(administrativeDivision);
                    }
                }
            }

            List<AdministrativeSubdivision> administrativeSubdivisions = gISModel.GetObjects<AdministrativeSubdivision>();
            if (administrativeSubdivisions == null || administrativeSubdivisions.Count == 0)
            {
                return;
            }

            Func<StatisticalUnit, AdministrativeSubdivision, bool> similar_AdministrativeSubdivision = new Func<StatisticalUnit, AdministrativeSubdivision, bool>((StatisticalUnit statisticalUnit, AdministrativeSubdivision administrativeSubdivision) =>
            {
                if (statisticalUnit == null && administrativeSubdivision == null)
                {
                    return true;
                }

                if (statisticalUnit == null || administrativeSubdivision == null)
                {
                    return false;
                }

                return statisticalUnit.Name?.ToUpper() == administrativeSubdivision.Name?.ToUpper();
            });

            foreach (AdministrativeSubdivision administrativeSubdivision in administrativeSubdivisions)
            {
                if(administrativeSubdivision == null)
                {
                    continue;
                }

                List<StatisticalUnit> statisticalUnits_Temp = statisticalUnit.GetStatisticalUnits(true, x => similar_AdministrativeSubdivision.Invoke(x, administrativeSubdivision))?.ToList();
                if (statisticalUnits_Temp != null && statisticalUnits_Temp.Count != 0)
                {
                    if (statisticalUnits_Temp.Count > 1)
                    {
                        for (int i = statisticalUnits_Temp.Count - 1; i >= 0; i--)
                        {
                            StatisticalUnit statisticalUnit_Parent = statisticalUnit.Find(statisticalUnits_Temp[i].UnitCode.GetParent(), true);
                            if (tuples.Find(x => x.Item2.Find(y => y.Code == statisticalUnit_Parent.Code) != null) == null)
                            {
                                statisticalUnits_Temp.RemoveAt(i);
                            }
                        }
                    }
                }

                if (statisticalUnits_Temp == null || statisticalUnits_Temp.Count == 0)
                {
                    if (!gISModel.TryGetRelatedObjects<AdministrativeAreal2D, AdministrativeAreal2DAdministrativeAreal2DsRelation>(administrativeSubdivision, out List<AdministrativeAreal2D> administrativeAreal2Ds_Related) || administrativeAreal2Ds_Related == null)
                    {
                        continue;
                    }

                    List<Tuple<string, StatisticalUnit>> tuples_StatisticalUnits = new List<Tuple<string, StatisticalUnit>>();
                    foreach (AdministrativeAreal2D administrativeAreal2D_Related in administrativeAreal2Ds_Related)
                    {
                        List<StatisticalUnit> statisticalUnits = tuples.Find(x => x.Item1.Guid == administrativeAreal2D_Related.Guid)?.Item2;
                        if(statisticalUnits == null || statisticalUnits.Count == 0)
                        {
                            if (administrativeAreal2D_Related is AdministrativeSubdivision)
                            {
                                statisticalUnits = statisticalUnit.GetStatisticalUnits(true, x => similar_AdministrativeSubdivision.Invoke(x, (AdministrativeSubdivision)administrativeAreal2D_Related))?.ToList();
                            }
                            else if (administrativeAreal2D_Related is AdministrativeDivision)
                            {
                                statisticalUnits = statisticalUnit.GetStatisticalUnits(true, x => similar_AdministrativeDivision.Invoke(x, (AdministrativeDivision)administrativeAreal2D_Related, false))?.ToList();
                            }

                            if (statisticalUnits.Count > 1)
                            {
                                for (int i = statisticalUnits.Count - 1; i >= 0; i--)
                                {
                                    StatisticalUnit statisticalUnit_Parent = statisticalUnit.Find(statisticalUnits[i].UnitCode.GetParent(), true);
                                    if (tuples.Find(x => x.Item2.Find(y => y.Code == statisticalUnit_Parent.Code) != null) == null)
                                    {
                                        statisticalUnits.RemoveAt(i);
                                    }
                                }
                            }
                        }

                        if (statisticalUnits != null && statisticalUnits.Count > 0)
                        {
                            foreach(StatisticalUnit statisticalUnit_Temp in statisticalUnits)
                            {
                                string code = statisticalUnit_Temp?.Code;
                                if(string.IsNullOrWhiteSpace(code))
                                {
                                    continue;
                                }

                                code = code.Substring(0, code.Length - 1);

                                tuples_StatisticalUnits.Add(new Tuple<string, StatisticalUnit>(code, statisticalUnit_Temp));
                            }
                        }
                    }

                    if (tuples_StatisticalUnits != null && tuples_StatisticalUnits.Count > 0)
                    {
                        tuples_StatisticalUnits.Sort((x, y) => y.Item1.CompareTo(x.Item1));

                        statisticalUnits_Temp = tuples_StatisticalUnits.FindAll(x => x.Item1 == tuples_StatisticalUnits[0].Item1).ConvertAll(x => x.Item2);
                    }
                }

                if (statisticalUnits_Temp != null && statisticalUnits_Temp.Count > 1)
                {
                    AdministrativeSubdivisionType administrativeSubdivisionType = administrativeSubdivision.AdministrativeSubdivisionType;

                    List<MunicipalityType?> municipalityTypes = statisticalUnits_Temp.ConvertAll(x => x.MunicipalityType());

                    if(administrativeSubdivisionType == AdministrativeSubdivisionType.city || administrativeSubdivisionType == AdministrativeSubdivisionType.part_of_city)
                    {
                        int index = -1;

                        index = municipalityTypes.IndexOf(MunicipalityType.Warsaw_district);
                        if (index == -1)
                        {
                            index = municipalityTypes.IndexOf(MunicipalityType.urban_rural_municipality_town);
                            if (index == -1)
                            {
                                index = municipalityTypes.IndexOf(MunicipalityType.urban_municipality);
                            }
                        }

                        if(index != -1)
                        {
                            statisticalUnits_Temp = new List<StatisticalUnit>() { statisticalUnits_Temp[index] };
                        }
                    }
                    else
                    {
                        int index = -1;

                        if (index == -1)
                        {
                            index = municipalityTypes.IndexOf(MunicipalityType.urban_rural_municipality_rural_area);
                            if (index == -1)
                            {
                                index = municipalityTypes.IndexOf(MunicipalityType.rural_municipality);
                            }
                        }

                        if (index != -1)
                        {
                            statisticalUnits_Temp = new List<StatisticalUnit>() { statisticalUnits_Temp[index] };
                        }
                    }
                }

                if(statisticalUnits_Temp == null || statisticalUnits_Temp.Count == 0)
                {
                    invalidAdministrativeAreal2Ds.Add(administrativeSubdivision);
                    continue;
                }

                tuples.Add(new Tuple<AdministrativeAreal2D, List<StatisticalUnit>>(administrativeSubdivision, statisticalUnits_Temp));
            }

            foreach(Tuple<AdministrativeAreal2D, List<StatisticalUnit>> tuple in tuples)
            {
                gISModel.Update(tuple.Item1, new AdministrativeAreal2DStatisticalUnitsCalculcationResult(tuple.Item2));
            }
        }
    }
}

