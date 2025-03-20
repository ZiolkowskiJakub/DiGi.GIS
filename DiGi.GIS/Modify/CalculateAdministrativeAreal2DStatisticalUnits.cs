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

            Func<StatisticalUnit, AdministrativeDivision, bool, bool> similar_AdministrativeDivision = new Func<StatisticalUnit, AdministrativeDivision, bool, bool>((StatisticalUnit statisticalUnit, AdministrativeDivision administrativeDivision, bool extended) =>
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
                    if(extended)
                    {
                        string name = statisticalUnit.Name.Trim().ToUpper();

                        return name.EndsWith(administrativeDivision.Name.ToUpper());
                    }
                    else
                    {
                        string name_StatisticalUnit = statisticalUnit.Name.Trim().ToUpper();
                        int index_OD = name_StatisticalUnit.IndexOf(" OD ");
                        int index_DO = name_StatisticalUnit.IndexOf(" DO ");
                        if (index_DO > 0 || index_OD > 0)
                        {
                            index_OD = index_OD == -1 ? index_DO : index_OD;
                            index_DO = index_DO == -1 ? index_OD : index_DO;
                            name_StatisticalUnit = name_StatisticalUnit.Substring(0, System.Math.Min(index_OD, index_DO));
                        }

                        string name_AdministrativeDivision = administrativeDivision.Name.Trim().ToUpper();
                        string name_AdministrativeDivision_2 = "POWIAT " + name_AdministrativeDivision;
                        string name_AdministrativeDivision_3 = "POWIAT M. " + name_AdministrativeDivision;

                        return name_StatisticalUnit == name_AdministrativeDivision_2 || name_StatisticalUnit == name_AdministrativeDivision_3;
                    }
                }
                else if (administrativeDivision.AdministrativeDivisionType == AdministrativeDivisionType.town_in_urban_rural_municipality)
                {
                    MunicipalityType? municipalityType = statisticalUnit.MunicipalityType();
                    if (municipalityType != null && municipalityType.HasValue)
                    {
                        if(extended)
                        {
                            return Query.IsUrban(municipalityType.Value) ? statisticalUnit.Name.ToUpper().StartsWith(administrativeDivision.Name?.ToUpper()) : false;
                        }
                        else
                        {
                            return municipalityType == MunicipalityType.urban_rural_municipality_town ? statisticalUnit.Name?.ToUpper() == administrativeDivision.Name?.ToUpper() : false;
                        }
                    }

                }
                else if (administrativeDivision.AdministrativeDivisionType == AdministrativeDivisionType.municipality)
                {
                    if (statisticalUnit.GetStatisticalUnitType() == StatisticalUnitType.municipalities)
                    {
                        string name_StatisticalUnit = statisticalUnit.Name.ToUpper();

                        string name_AdministrativeDivision = administrativeDivision.Name?.ToUpper();
                        if (name_AdministrativeDivision.StartsWith("M. ST."))
                        {
                            name_AdministrativeDivision = name_AdministrativeDivision.Replace(" ", string.Empty) + " OD 2002";
                        }
                        else if (name_AdministrativeDivision.StartsWith("M."))
                        {
                            name_AdministrativeDivision = name_AdministrativeDivision.Substring(2).Trim();
                        }

                        MunicipalityType? municipalityType = statisticalUnit.MunicipalityType();
                        if(municipalityType != null && municipalityType.HasValue)
                        {
                            string sufix;

                            sufix = "(GM. MIEJSKA)";
                            if (name_AdministrativeDivision.EndsWith(sufix))
                            {
                                if (Query.IsUrban(municipalityType.Value))
                                {
                                    name_StatisticalUnit = string.Format("{0} {1}", name_StatisticalUnit, sufix);
                                }
                            }

                            sufix = "(GM. WIEJSKA)";
                            if (name_AdministrativeDivision.EndsWith(sufix))
                            {
                                if (!Query.IsUrban(municipalityType.Value))
                                {
                                    name_StatisticalUnit = string.Format("{0} {1}", name_StatisticalUnit, sufix);
                                }
                            }

                            if(name_StatisticalUnit == name_AdministrativeDivision)
                            {
                                return true;
                            }

                            int index_Start = name_AdministrativeDivision.LastIndexOf("(");
                            int index_End = name_AdministrativeDivision.LastIndexOf(")");
                            if (index_Start > 0 && index_End > 1 && index_End == name_AdministrativeDivision.Length - 1)
                            {
                                name_AdministrativeDivision = name_AdministrativeDivision.Substring(0, index_Start).Trim();
                            }
                        }


                        return extended ? name_StatisticalUnit.Contains(name_AdministrativeDivision) : name_StatisticalUnit == name_AdministrativeDivision;
                    }
                }
                else if (administrativeDivision.AdministrativeDivisionType == AdministrativeDivisionType.district_or_delegation)
                {
                    if(statisticalUnit.GetStatisticalUnitType() == StatisticalUnitType.municipalities)
                    {
                        MunicipalityType? municipalityType = statisticalUnit.MunicipalityType();
                        if(municipalityType != null && municipalityType.HasValue)
                        {
                            if (Query.IsUrban(municipalityType.Value))
                            {
                                if(municipalityType.Value == MunicipalityType.Warsaw_district)
                                {
                                    return statisticalUnit.Name.ToUpper().StartsWith(administrativeDivision.Name.ToUpper());
                                }
                                else
                                {
                                    return administrativeDivision.Name.ToUpper().StartsWith(statisticalUnit.Name.ToUpper());
                                }
                            }
                        }
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
                            List<StatisticalUnit> statisticalUnits_Temp_Temp = new List<StatisticalUnit>(statisticalUnits_Temp);

                            for (int i = statisticalUnits_Temp_Temp.Count - 1; i >= 0; i--)
                            {
                                StatisticalUnit statisticalUnit_Parent = statisticalUnit.Find(statisticalUnits_Temp_Temp[i].UnitCode.GetParent(), true);
                                if (tuples.Find(x => x.Item2.Find(y => y.Code == statisticalUnit_Parent.Code) != null) == null)
                                {
                                    statisticalUnits_Temp_Temp.RemoveAt(i);
                                }
                            }

                            if(statisticalUnits_Temp_Temp.Count == 0)
                            {
                                statisticalUnits_Temp_Temp = new List<StatisticalUnit>(statisticalUnits_Temp);

                                List<StatisticalUnit> statisticalUnits = new List<StatisticalUnit>();
                                tuples.ConvertAll(x => x.Item2).ForEach(x => statisticalUnits.AddRange(x));

                                string prefix = null;
                                foreach(string prefix_Temp in statisticalUnits.ConvertAll(x => x.UnitCode.GetPrefix()))
                                {
                                    if(prefix == null || prefix_Temp.Length > prefix.Length)
                                    {
                                        prefix = prefix_Temp;
                                    }
                                }

                                statisticalUnits_Temp_Temp.RemoveAll(x => !x.Code.StartsWith(prefix));
                            }

                            statisticalUnits_Temp = statisticalUnits_Temp_Temp;
                        }

                        if(statisticalUnits_Temp.Count > 1)
                        {
                            List<string> names = statisticalUnits_Temp.ConvertAll(x => x.Name.Trim().ToUpper());
                            if(names.TrueForAll(x => x.Contains(" OD ") || x.Contains(" DO ")))
                            {
                                List<StatisticalUnit> statisticalUnits = new List<StatisticalUnit>();
                                tuples.ConvertAll(x => x.Item2).ForEach(x => statisticalUnits.AddRange(x));

                                List<StatisticalUnit> statisticalUnits_Temp_Temp = new List<StatisticalUnit>(statisticalUnits_Temp);
                                statisticalUnits_Temp_Temp.RemoveAll(x => statisticalUnits.Find(y => y.Code == x.Code) != null);
                                if(statisticalUnits_Temp_Temp.Count > 0)
                                {
                                    statisticalUnits_Temp = statisticalUnits_Temp_Temp;
                                }

                                statisticalUnits_Temp.Sort((x, y) => y.Code.CompareTo(x.Code));
                                statisticalUnits_Temp = new List<StatisticalUnit>() { statisticalUnits_Temp[0] };
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

