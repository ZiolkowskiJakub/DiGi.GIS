using DiGi.BDL.Classes;
using DiGi.BDL.Enums;
using DiGi.BDOT10k.Classes;
using DiGi.BDOT10k.Interfaces;
using DiGi.Core.Classes;
using DiGi.GIS.Classes;
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
        /// <summary>
        /// Adds a range of features from the specified stream to the GIS model by converting the stream content to GML.
        /// </summary>
        /// <param name="gISModel">The GIS model instance to which the features should be added.</param>
        /// <param name="stream">The input stream containing the feature data in GML format.</param>
        /// <returns>A list of <see cref="GuidReference"/> for the successfully added features, or null if the stream is null or no valid feature collection was found.</returns>
        public static List<GuidReference>? AddRange(this GISModel? gISModel, Stream? stream)
        {
            if (stream == null)
            {
                return null;
            }

            FeatureCollection? featureCollection = GML.Convert.ToGML<FeatureCollection>(stream)?.FirstOrDefault();
            if (featureCollection == null)
            {
                return null;
            }

            return gISModel.AddRange(featureCollection);
        }

        /// <summary>
        /// Adds a range of features from the specified feature collection to the GIS model, filtering for specific geometry types.
        /// </summary>
        /// <param name="gISModel">The GIS model instance to which the features should be added.</param>
        /// <param name="featureCollection">The collection of GML features to process.</param>
        /// <returns>A list of <see cref="GuidReference"/> for the successfully updated features, or null if the model or feature collection is null or contains no valid members.</returns>
        public static List<GuidReference>? AddRange(this GISModel? gISModel, FeatureCollection? featureCollection)
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

            List<GuidReference> result = [];
            foreach (IFeatureMember featureMember in featureMembers)
            {
                if (featureMember is not IOT_ObiektGeometryczny)
                {
                    continue;
                }

                Areal2D? areal2D = null;

                if (featureMember is OT_ADJA_A oT_ADJA_A)
                {
                    areal2D = Convert.ToDiGi(oT_ADJA_A);
                }
                else if (featureMember is OT_ADMS_A oT_ADMS_A)
                {
                    areal2D = Convert.ToDiGi(oT_ADMS_A);
                }
                else if (featureMember is OT_BUBD_A oT_BUBD_A)
                {
                    areal2D = Convert.ToDiGi(oT_BUBD_A);
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

        /// <summary>
        /// Adds a range of yearly statistical values from the provided unit yearly values to the specified statistical data collection.
        /// </summary>
        /// <param name="statisticalDataCollection">The collection where the processed statistical data will be stored.</param>
        /// <param name="unitYearlyValues">The source object containing results and yearly values for units.</param>
        /// <returns>A list of <see cref="StatisticalYearlyDoubleData"/> that were processed, or null if either parameter is null.</returns>
        public static List<StatisticalYearlyDoubleData>? AddRange(this StatisticalDataCollection? statisticalDataCollection, UnitYearlyValues? unitYearlyValues)
        {
            if (statisticalDataCollection == null || unitYearlyValues == null)
            {
                return null;
            }

            HashSet<StatisticalYearlyDoubleData> result = [];

            List<YearlyValues>? yearlyValuesList = unitYearlyValues.results;
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

                    List<YearlyValue>? yearlyValueList = yearlyValues?.values;
                    if (yearlyValueList == null || yearlyValueList.Count == 0)
                    {
                        continue;
                    }

                    string reference = id.ToString();

                    StatisticalYearlyDoubleData? statisticalYearlyDoubleData = statisticalDataCollection.Find<StatisticalYearlyDoubleData>(x => x?.Reference == reference);
                    if (statisticalYearlyDoubleData == null)
                    {
                        statisticalYearlyDoubleData = new StatisticalYearlyDoubleData(Core.Query.Description(variable), reference);
                        statisticalDataCollection.Add(statisticalYearlyDoubleData);
                    }

                    foreach (YearlyValue yearlyValue in yearlyValueList)
                    {
                        if (yearlyValue == null)
                        {
                            continue;
                        }

                        if (!short.TryParse(yearlyValue.year, out short year))
                        {
                            continue;
                        }

                        statisticalYearlyDoubleData[year] = yearlyValue.val;
                    }
                }
            }

            return [.. result];
        }
    }
}