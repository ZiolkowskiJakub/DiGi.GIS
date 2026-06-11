using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Enums;
using DiGi.GIS.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a collection of orthophoto data, providing functionality to manage and retrieve spatial and temporal information.
    /// </summary>
    public class OrtoDatas : GuidObject, IGISGuidObject, IEnumerable<OrtoData>
    {
        [JsonInclude, JsonPropertyName("Reference")]
        private readonly string? reference = null;

        [JsonIgnore]
        private readonly SortedDictionary<DateTime, OrtoData> sortedDictionary = [];

        /// <summary>
        /// Initializes a new instance of the OrtoDatas class with a specified reference and values.
        /// </summary>
        /// <param name="reference">The reference identifier for the orthophoto data.</param>
        /// <param name="values">The collection of orthophoto data entries.</param>
        public OrtoDatas(string? reference, IEnumerable<OrtoData>? values)
        {
            this.reference = reference;
            Values = values;
        }

        /// <summary>
        /// Initializes a new instance of the OrtoDatas class by copying an existing instance.
        /// </summary>
        /// <param name="ortoDatas">The source orthophoto data collection to copy from.</param>
        public OrtoDatas(OrtoDatas? ortoDatas)
        {
            if (ortoDatas != null)
            {
                reference = ortoDatas.reference;
                Values = ortoDatas.Values;
            }
        }

        /// <summary>
        /// Initializes a new instance of the OrtoDatas class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the orthophoto data.</param>
        public OrtoDatas(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the reference identifier associated with the orthophoto data collection.
        /// </summary>
        [JsonIgnore]
        public string? Reference
        {
            get
            {
                return reference;
            }
        }

        [JsonInclude, JsonPropertyName("Values")]
        private IEnumerable<OrtoData>? Values
        {
            get
            {
                return sortedDictionary.Values;
            }
            set
            {
                sortedDictionary.Clear();
                if (value == null)
                {
                    return;
                }

                foreach (OrtoData ortoData in value)
                {
                    if (ortoData == null)
                    {
                        continue;
                    }

                    sortedDictionary[ortoData.DateTime] = ortoData;
                }
            }
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection of <see cref="OrtoData"/>.
        /// </summary>
        /// <returns>An enumerator for the orthophoto data collection.</returns>
        public IEnumerator<OrtoData> GetEnumerator()
        {
            return sortedDictionary?.Values == null ? new List<OrtoData>().GetEnumerator() : new List<OrtoData>(sortedDictionary.Values).GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>An enumerator for the orthophoto data collection.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Calculates the bounding box that encompasses all orthophoto data in the collection based on the provided geometry context.
        /// </summary>
        /// <param name="geometryContext">The context used to determine the coordinate system or projection for the bounding box.</param>
        /// <returns>A <see cref="BoundingBox2D"/> containing all entries, or null if no valid data exists or the context is undefined.</returns>
        public BoundingBox2D? GetBoundingBox(GeometryContext geometryContext)
        {
            if (geometryContext == GeometryContext.Undefined || sortedDictionary is null || sortedDictionary.Count == 0)
            {
                return null;
            }

            List<BoundingBox2D?> boundingBox2Ds = sortedDictionary.Values.ToList().ConvertAll(x => x?.GetBoundingBox(geometryContext));
            boundingBox2Ds.RemoveAll(x => x is null);

            if (boundingBox2Ds.Count == 0)
            {
                return null;
            }

            return new BoundingBox2D(boundingBox2Ds);
        }

        /// <summary>
        /// Reduces the collection by removing redundant entries where the binary data is identical to the preceding entry.
        /// </summary>
        public void Reduce()
        {
            if (sortedDictionary == null)
            {
                return;
            }

            List<OrtoData> ortoDatas = [.. sortedDictionary.Values];

            sortedDictionary.Clear();

            while (ortoDatas.Count > 0)
            {
                OrtoData ortoData = ortoDatas[0];
                ortoDatas.RemoveAt(0);

                if (ortoData is null)
                {
                    continue;
                }

                byte[]? bytes = ortoData?.Bytes;
                if (bytes == null || bytes.Length == 0)
                {
                    continue;
                }

                sortedDictionary[ortoData!.DateTime] = ortoData;

                int index = 0;

                for (int i = 0; i < ortoDatas.Count; i++)
                {
                    if (!Core.Query.Equals(bytes, ortoDatas[i].Bytes))
                    {
                        break;
                    }

                    index++;
                }

                if (index == 0)
                {
                    continue;
                }

                ortoDatas.RemoveRange(0, index);
            }
        }

        /// <summary>
        /// Attempts to retrieve the set of years covered by the orthophoto data collection.
        /// </summary>
        /// <param name="years">When this method returns, contains a hash set of all years between the minimum and maximum dates in the collection, or null if retrieval fails.</param>
        /// <returns>True if the range of years was successfully determined; otherwise, false.</returns>
        public bool TryGetYears(out HashSet<int>? years)
        {
            years = null;
            if (!TryGetDateTime(out DateTime dateTime_Min, out DateTime dateTime_Max))
            {
                return false;
            }

            years = [];
            for (int i = dateTime_Min.Year; i <= dateTime_Max.Year; i++)
            {
                years.Add(i);
            }

            return true;
        }

        /// <summary>
        /// Attempts to retrieve the minimum and maximum dates present in the orthophoto data collection.
        /// </summary>
        /// <param name="dateTime_Min">When this method returns, contains the earliest date in the collection if successful.</param>
        /// <param name="dateTime_Max">When this method returns, contains the latest date in the collection if successful.</param>
        /// <returns>True if the dates were successfully retrieved; otherwise, false.</returns>
        public bool TryGetDateTime(out DateTime dateTime_Min, out DateTime dateTime_Max)
        {
            dateTime_Min = default;
            dateTime_Max = default;
            if (sortedDictionary == null || sortedDictionary.Count == 0)
            {
                return false;
            }

            dateTime_Min = sortedDictionary.Keys.First();
            dateTime_Max = sortedDictionary.Keys.Last();
            return true;
        }

        /// <summary>
        /// Retrieves the raw bytes of the orthophoto data for a specific date.
        /// </summary>
        /// <param name="dateTime">The date for which to retrieve the bytes.</param>
        /// <returns>A byte array containing the orthophoto data, or null if no data is found for the specified date.</returns>
        public byte[]? GetBytes(DateTime dateTime)
        {
            OrtoData? ortoData = GetOrtoData(dateTime);
            if (ortoData == null)
            {
                return null;
            }

            return ortoData.Bytes;
        }

        /// <summary>
        /// Retrieves the orthophoto data object for a specific date, or the closest available entry preceding that date.
        /// </summary>
        /// <param name="dateTime">The target date to search for.</param>
        /// <returns>The <see cref="OrtoData"/> object associated with the specified date or the nearest lower value; otherwise, null.</returns>
        public OrtoData? GetOrtoData(DateTime dateTime)
        {
            if (!Core.Query.TryGetLowerValue(sortedDictionary, dateTime, out OrtoData? result))
            {
                return null;
            }

            return result;
        }
    }
}