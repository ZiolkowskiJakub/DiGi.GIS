using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents index data with an index value, reference, and name
    /// </summary>
    public class IndexData : UniqueObject, IGISUniqueObject
    {
        [JsonInclude, JsonPropertyName("Index")]
        private readonly int index;

        [JsonInclude, JsonPropertyName("Reference")]
        private readonly string? reference;

        [JsonInclude, JsonPropertyName("Name")]
        private readonly string? name;

        /// <summary>
        /// Initializes a new instance of the IndexData class with the specified index, reference, and name
        /// </summary>
        public IndexData(int index, string? reference, string? name)
            : base()
        {
            this.index = index;
            this.reference = reference;
            this.name = name;
        }

        /// <summary>
        /// Initializes a new instance of the IndexData class by copying another instance
        /// </summary>
        public IndexData(IndexData? indexData)
            : base(indexData)
        {
            if (indexData != null)
            {
                index = indexData.index;
                reference = indexData.reference;
                name = indexData.name;
            }
        }

        /// <summary>
        /// Initializes a new instance of the IndexData class from a JSON object
        /// </summary>
        public IndexData(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the index value
        /// </summary>
        [JsonIgnore]
        public int Index
        {
            get
            {
                return index;
            }
        }

        /// <summary>
        /// Gets the reference string
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
        /// Gets the name string
        /// </summary>
        [JsonIgnore]
        public string? Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Gets the unique identifier for this instance (the index value as a string)
        /// </summary>
        [JsonIgnore]
        public override string? UniqueId
        {
            get
            {
                return index.ToString();
            }
        }

        /// <summary>
        /// Returns the string representation of this instance
        /// </summary>
        public override string? ToString()
        {
            return string.Join("\t", index.ToString(), reference ?? string.Empty, name ?? string.Empty);
        }
    }
}