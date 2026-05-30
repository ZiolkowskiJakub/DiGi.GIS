using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Enums;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents an administrative subdivision (e.g., city, village, colony) with optional occupancy data, extending AdministrativeAreal2D
    /// </summary>
    public class AdministrativeSubdivision : AdministrativeAreal2D
    {
        [JsonInclude, JsonPropertyName("AdministrativeSubdivisionType")]
        private readonly AdministrativeSubdivisionType administrativeSubdivisionType;

        [JsonInclude, JsonPropertyName("Occupancy")]
        private readonly uint? occupancy = 0;

        /// <summary>
        /// Initializes a new instance of the AdministrativeSubdivision class with all required properties
        /// </summary>
        /// <param name="guid">The unique identifier for the subdivision</param>
        /// <param name="reference">An optional reference string</param>
        /// <param name="code">A code for the subdivision</param>
        /// <param name="polygonalFace2D">The 2D polygonal face geometry</param>
        /// <param name="administrativeSubdivisionType">The type of the administrative subdivision</param>
        /// <param name="name">An optional name for the subdivision</param>
        /// <param name="occupancy">An optional maximum occupancy value</param>
        public AdministrativeSubdivision(Guid guid, string? reference, string code, PolygonalFace2D? polygonalFace2D, AdministrativeSubdivisionType administrativeSubdivisionType, string? name, uint? occupancy)
            : base(guid, reference, code, polygonalFace2D, name)
        {
            this.administrativeSubdivisionType = administrativeSubdivisionType;
            this.occupancy = occupancy;
        }

        /// <summary>
        /// Initializes a new instance of the AdministrativeSubdivision class as a deep copy of another AdministrativeSubdivision
        /// </summary>
        /// <param name="administrativeSubdivision">The AdministrativeSubdivision to copy, or null to create an empty instance</param>
        public AdministrativeSubdivision(AdministrativeSubdivision? administrativeSubdivision)
            : base(administrativeSubdivision)
        {
            if (administrativeSubdivision != null)
            {
                administrativeSubdivisionType = administrativeSubdivision.administrativeSubdivisionType;
                occupancy = administrativeSubdivision.occupancy;
            }
        }

        /// <summary>
        /// Initializes a new instance of the AdministrativeSubdivision class as a copy of another AdministrativeSubdivision with a new code
        /// </summary>
        /// <param name="administrativeSubdivision">The AdministrativeSubdivision to copy, or null to create an empty instance</param>
        /// <param name="code">The new code to assign to the copied subdivision</param>
        public AdministrativeSubdivision(AdministrativeSubdivision? administrativeSubdivision, string? code)
            : base(administrativeSubdivision, code)
        {
            if (administrativeSubdivision != null)
            {
                administrativeSubdivisionType = administrativeSubdivision.administrativeSubdivisionType;
                occupancy = administrativeSubdivision.occupancy;
            }
        }

        /// <summary>
        /// Initializes a new instance of the AdministrativeSubdivision class from a JSON object
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the subdivision data</param>
        public AdministrativeSubdivision(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the maximum occupancy of the subdivision
        /// </summary>
        [JsonIgnore]
        public uint? Occupancy
        {
            get
            {
                return occupancy;
            }
        }

        /// <summary>
        /// Gets the type of this administrative subdivision (e.g., city, village, colony, hamlet)
        /// </summary>
        [JsonIgnore]
        public AdministrativeSubdivisionType AdministrativeSubdivisionType
        {
            get
            {
                return administrativeSubdivisionType;
            }
        }
    }
}