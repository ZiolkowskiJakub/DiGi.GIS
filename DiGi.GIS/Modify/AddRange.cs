using DiGi.BDL.Classes;
using DiGi.BDOT10k.Classes;
using DiGi.BDOT10k.Interfaces;
using DiGi.Core.Classes;
using DiGi.GIS.Classes;
using DiGi.BDL.Enums;
using DiGi.GML.Classes;
using DiGi.GML.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DiGi.GIS
{
    public static partial class Modify
    {
        public static List<GuidReference> AddRange(this GISModel gISModel, Stream stream)
        {
            if (stream == null)
            {
                return null;
            }

            FeatureCollection featureCollection = GML.Convert.ToGML<FeatureCollection>(stream)?.FirstOrDefault();
            if (featureCollection == null)
            {
                return null;
            }

            return gISModel.AddRange(featureCollection);
        }

        public static List<GuidReference> AddRange(this GISModel gISModel, FeatureCollection featureCollection)
        {
            if (gISModel == null || featureCollection == null)
            {
                return null;
            }

            List<IFeatureMember> featureMembers = featureCollection.featureMember;
            if (featureMembers == null || featureMembers.Count == 0)
            {
                return null;
            }

            List<GuidReference> result = new List<GuidReference>();
            foreach (IFeatureMember featureMember in featureMembers)
            {
                if (!(featureMember is IOT_ObiektGeometryczny))
                {
                    continue;
                }

                Areal2D areal2D = null;

                if (featureMember is OT_ADJA_A)
                {
                    areal2D = Convert.ToDiGi((OT_ADJA_A)featureMember);
                }
                else if (featureMember is OT_ADMS_A)
                {
                    areal2D = Convert.ToDiGi((OT_ADMS_A)featureMember);
                }
                else if (featureMember is OT_BUBD_A)
                {
                    areal2D = Convert.ToDiGi((OT_BUBD_A)featureMember);
                }

                if (areal2D != null)
                {
                    bool updated = gISModel.Update((dynamic)areal2D);
                    if (updated)
                    {
                        result.Add(new GuidReference(areal2D));
                    }
                }
            }

            return result;
        }

        public static List<StatisticalYearlyDoubleData> AddRange(this StatisticalDataCollection statisticalDataCollection, UnitYearlyValues unitYearlyValues)
        {
            if(statisticalDataCollection == null || unitYearlyValues == null)
            {
                return null;
            }

            HashSet<StatisticalYearlyDoubleData> result = new HashSet<StatisticalYearlyDoubleData>();

            List<YearlyValues> yearlyValuesList = unitYearlyValues.results;
            if (yearlyValuesList != null)
            {
                
                foreach (YearlyValues yearlyValues in yearlyValuesList)
                {
                    int id = yearlyValues.id;

                    if (!Enum.IsDefined(typeof(Variable), id))
                    {
                        continue;
                    }

                    Variable variable = (Variable)id;

                    List<YearlyValue> yearlyValueList = yearlyValues?.values;
                    if(yearlyValueList == null || yearlyValueList.Count == 0)
                    {
                        continue;
                    }

                    string reference = id.ToString();

                    StatisticalYearlyDoubleData statisticalYearlyDoubleData = statisticalDataCollection.Find<StatisticalYearlyDoubleData>(x => x.Reference == reference);
                    if(statisticalYearlyDoubleData == null)
                    {
                        statisticalYearlyDoubleData = new StatisticalYearlyDoubleData(Core.Query.Description(variable), reference);
                        statisticalDataCollection.Add(statisticalYearlyDoubleData);
                    }

                    foreach (YearlyValue yearlyValue in yearlyValueList)
                    {
                        if(yearlyValue == null)
                        {
                            continue;
                        }

                        if(!short.TryParse(yearlyValue.year, out short year))
                        {
                            continue;
                        }

                        statisticalYearlyDoubleData[year] = yearlyValue.val;
                    }
                }
            }

            return result.ToList();
        }
    }
}

