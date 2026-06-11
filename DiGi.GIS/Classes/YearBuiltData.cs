using DiGi.Core.Classes;
using DiGi.GIS.Enums;
using DiGi.GIS.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents data related to the year a building was constructed, supporting multiple sources of information.
    /// </summary>
    public class YearBuiltData : GuidObject, IYearBuiltData
    {
        [JsonInclude, JsonPropertyName("Reference")]
        private readonly string? reference;

        //[JsonInclude, JsonPropertyName("Year")]
        //public short Year;

        [JsonIgnore]
        private Dictionary<string, IYearBuilt>? yearBuilts;

        /// <summary>
        /// Initializes a new instance of the <see cref="YearBuiltData"/> class with a specified reference.
        /// </summary>
        /// <param name="reference">The reference identifier for this data object.</param>
        public YearBuiltData(string? reference)
        {
            this.reference = reference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="YearBuiltData"/> class by copying values from an existing instance.
        /// </summary>
        /// <param name="yearBuiltData">The source <see cref="YearBuiltData"/> object to copy data from.</param>
        public YearBuiltData(YearBuiltData? yearBuiltData)
        {
            if (yearBuiltData != null)
            {
                reference = yearBuiltData.reference;
                YearBuilts = yearBuiltData.YearBuilts;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="YearBuiltData"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the data.</param>
        public YearBuiltData(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the reference identifier associated with the year built data.
        /// </summary>
        [JsonIgnore]
        public string? Reference
        {
            get
            {
                return reference;
            }
        }

        /// <summary>
        /// Gets or sets the collection of year built entries from various sources.
        /// </summary>
        [JsonInclude, JsonPropertyName("YearBuilts")]
        public IEnumerable<IYearBuilt>? YearBuilts
        {
            get
            {
                return yearBuilts?.Values;
            }

            set
            {
                if (value == null)
                {
                    yearBuilts = null;
                    return;
                }

                yearBuilts = [];

                foreach (IYearBuilt yearBuilt in value)
                {
                    Add(yearBuilt);
                }
            }
        }

        /// <summary>
        /// Adds a specific year built entry to the collection.
        /// </summary>
        /// <param name="yearBuilt">The <see cref="IYearBuilt"/> entry to add.</param>
        /// <returns>True if the entry was successfully added; otherwise, false.</returns>
        public bool Add(IYearBuilt yearBuilt)
        {
            string? source = yearBuilt?.Source;
            if (source == null)
            {
                return false;
            }

            yearBuilts ??= [];

            yearBuilts[source] = yearBuilt!;
            return true;
        }

        /// <summary>
        /// Retrieves the most recent predicted year built entry based on its date.
        /// </summary>
        /// <returns>The latest <see cref="PredictedYearBuilt"/> instance, or null if no predictions exist.</returns>
        public PredictedYearBuilt? GetLatestPredictedYearBuilt()
        {
            List<PredictedYearBuilt>? predictedYearBuilts = GetPredictedYearBuilts();
            if (predictedYearBuilts == null || predictedYearBuilts.Count == 0)
            {
                return null;
            }

            PredictedYearBuilt result = predictedYearBuilts[0];
            for (int i = 1; i < predictedYearBuilts.Count; i++)
            {
                if (result.DateTime < predictedYearBuilts[i].DateTime)
                {
                    result = predictedYearBuilts[i];
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves a predicted year built entry that matches the specified date.
        /// </summary>
        /// <param name="dateTime">The date to search for.</param>
        /// <returns>The matching <see cref="PredictedYearBuilt"/> instance, or null if not found.</returns>
        public PredictedYearBuilt? GetPredictedYearBuilt(DateTime dateTime)
        {
            if (yearBuilts == null)
            {
                return null;
            }

            foreach (KeyValuePair<string, IYearBuilt> keyValuePair in yearBuilts)
            {
                if (keyValuePair.Value is PredictedYearBuilt predictedYearBuilt && dateTime.Equals(predictedYearBuilt.DateTime))
                {
                    return predictedYearBuilt;
                }
            }

            return null;
        }

        /// <summary>
        /// Retrieves all predicted year built entries available in the collection.
        /// </summary>
        /// <returns>A list of <see cref="PredictedYearBuilt"/> objects, or null if the collection is uninitialized.</returns>
        public List<PredictedYearBuilt>? GetPredictedYearBuilts()
        {
            if (yearBuilts == null)
            {
                return null;
            }

            List<PredictedYearBuilt> result = [];
            foreach (IYearBuilt yearBuilt in yearBuilts.Values)
            {
                if (yearBuilt is PredictedYearBuilt predictedYearBuilt)
                {
                    result.Add(predictedYearBuilt);
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves the year built entry provided by the user.
        /// </summary>
        /// <returns>The <see cref="UserYearBuilt"/> instance, or null if no user-provided data exists.</returns>
        public UserYearBuilt? GetUserYearBuilt()
        {
            if (!TryGetYearBuilt(Core.Query.Description(YearBuiltSource.User), out UserYearBuilt? result))
            {
                return null;
            }

            return result;
        }

        /// <summary>
        /// Retrieves all year built entries of a specific type.
        /// </summary>
        /// <typeparam name="TYearBuilt">The type of <see cref="IYearBuilt"/> to filter for.</typeparam>
        /// <returns>A list of entries of type <typeparamref name="TYearBuilt"/>, or null if the collection is uninitialized.</returns>
        public List<TYearBuilt>? GetYearBuilts<TYearBuilt>() where TYearBuilt : IYearBuilt
        {
            if (yearBuilts == null)
            {
                return null;
            }

            List<TYearBuilt> result = [];
            foreach (IYearBuilt? yearBuilt in yearBuilts.Values)
            {
                if (yearBuilt is TYearBuilt yearBuilt_Temp)
                {
                    result.Add(yearBuilt_Temp);
                }
            }

            return result;
        }

        /// <summary>
        /// Removes a year built entry from the collection based on its source identifier.
        /// </summary>
        /// <param name="source">The unique identifier of the source to remove.</param>
        /// <returns>True if the entry was successfully removed; otherwise, false.</returns>
        public bool Remove(string? source)
        {
            if (source == null || yearBuilts == null)
            {
                return false;
            }

            return yearBuilts.Remove(source);
        }

        /// <summary>
        /// Removes all predicted year built entries from the collection.
        /// </summary>
        /// <returns>True if one or more predicted entries were removed; otherwise, false.</returns>
        public bool RemovePredictedYearBuilts()
        {
            bool result = false;

            if (yearBuilts == null)
            {
                return result;
            }

            List<string> sources = [];
            foreach (KeyValuePair<string, IYearBuilt> keyValuePair in yearBuilts)
            {
                if (keyValuePair.Value is PredictedYearBuilt)
                {
                    sources.Add(keyValuePair.Key);
                }
            }

            foreach (string source in sources)
            {
                if (yearBuilts.Remove(source))
                {
                    result = true;
                }
            }

            return result;
        }

        /// <summary>
        /// Removes the year built entry provided by the user.
        /// </summary>
        /// <returns>True if the user entry was successfully removed; otherwise, false.</returns>
        public bool RemoveUserYearBuilt()
        {
            return Remove(Core.Query.Description(YearBuiltSource.User));
        }

        /// <summary>
        /// Sets a new predicted year built entry in the collection.
        /// </summary>
        /// <param name="dateTime">The date of the prediction.</param>
        /// <param name="year">The predicted construction year.</param>
        /// <returns>True if the prediction was successfully added; otherwise, false.</returns>
        public bool SetPredictedYearBuilt(DateTime dateTime, short year)
        {
            return Add(new PredictedYearBuilt(dateTime, year));
        }

        /// <summary>
        /// Sets a new user-provided year built entry in the collection.
        /// </summary>
        /// <param name="year">The construction year provided by the user.</param>
        /// <returns>True if the user entry was successfully added; otherwise, false.</returns>
        public bool SetUserYearBuilt(short year)
        {
            return Add(new UserYearBuilt(year));
        }

        /// <summary>
        /// Attempts to retrieve a year built entry of a specific type from a given source.
        /// </summary>
        /// <typeparam name="TYearBuilt">The expected type of the year built entry.</typeparam>
        /// <param name="source">The unique identifier of the source.</param>
        /// <param name="yearBuilt">When this method returns, contains the retrieved entry if successful; otherwise, default.</param>
        /// <returns>True if the entry was found and is of type <typeparamref name="TYearBuilt"/>; otherwise, false.</returns>
        public bool TryGetYearBuilt<TYearBuilt>(string? source, out TYearBuilt? yearBuilt) where TYearBuilt : IYearBuilt
        {
            yearBuilt = default;

            if (source == null || yearBuilts == null)
            {
                return false;
            }

            if (!yearBuilts.TryGetValue(source, out IYearBuilt yearBuilt_Temp) || yearBuilt_Temp is not TYearBuilt)
            {
                return false;
            }

            yearBuilt = (TYearBuilt)yearBuilt_Temp;
            return true;
        }
    }
}