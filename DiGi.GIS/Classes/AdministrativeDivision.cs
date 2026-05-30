using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Enums;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents an administrative division with a specific type, extending AdministrativeAreal2D
    /// </summary>
    public class AdministrativeDivision : AdministrativeAreal2D
    {
        [JsonInclude, JsonPropertyName("AdministrativeDivisionType")]
        private readonly AdministrativeDivisionType administrativeDivisionType;

        /// <summary>
        /// Initializes a new instance of the AdministrativeDivision class with all required properties
        /// </summary>
        /// <param name="guid">The unique identifier for the division</param>
        /// <param name="reference">An optional reference string</param>
        /// <param name="code">An optional code for the division</param>
        /// <param name="polygonalFace2D">The 2D polygonal face geometry</param>
        /// <param name="administrativeDivisionType">The type of the administrative division</param>
        /// <param name="name">The name of the division</param>
        public AdministrativeDivision(Guid guid, string? reference, string? code, PolygonalFace2D? polygonalFace2D, AdministrativeDivisionType administrativeDivisionType, string name)
            : base(guid, reference, code, polygonalFace2D, name)
        {
            this.administrativeDivisionType = administrativeDivisionType;
        }

        /// <summary>
        /// Initializes a new instance of the AdministrativeDivision class as a deep copy of another AdministrativeDivision
        /// </summary>
        /// <param name="administrativeDivision">The AdministrativeDivision to copy, or null to create an empty instance</param>
        public AdministrativeDivision(AdministrativeDivision? administrativeDivision)
            : base(administrativeDivision)
        {
            if (administrativeDivision != null)
            {
                administrativeDivisionType = administrativeDivision.administrativeDivisionType;
            }
        }

        /// <summary>
        /// Initializes a new instance of the AdministrativeDivision class as a copy of another AdministrativeDivision with a new code
        /// </summary>
        /// <param name="administrativeDivision">The AdministrativeDivision to copy, or null to create an empty instance</param>
        /// <param name="code">The new code to assign to the copied division</param>
        public AdministrativeDivision(AdministrativeDivision? administrativeDivision, string? code)
            : base(administrativeDivision, code)
        {
            if (administrativeDivision != null)
            {
                administrativeDivisionType = administrativeDivision.administrativeDivisionType;
            }
        }

        /// <summary>
        /// Initializes a new instance of the AdministrativeDivision class from a JSON object
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the division data</param>
        public AdministrativeDivision(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the type of this administrative division (e.g., country, voivodeship, county, municipality)
        /// </summary>
        [JsonIgnore]
        public AdministrativeDivisionType AdministrativeDivisionType
        {
            get
            {
                return administrativeDivisionType;
            }
        }
    }
}