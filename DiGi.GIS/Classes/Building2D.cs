using DiGi.Core.Interfaces;
using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Enums;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents a 2D building with storey count, phase, and functional classification, extending Areal2D
    /// </summary>
    public class Building2D : Areal2D
    {
        [JsonInclude, JsonPropertyName("Storeys")]
        private readonly ushort storeys = 1;

        [JsonInclude, JsonPropertyName("BuildingGeneralFunction")]
        private readonly BuildingGeneralFunction? buildingGeneralFunction;

        [JsonInclude, JsonPropertyName("BuildingSpecificFunctions")]
        private readonly HashSet<BuildingSpecificFunction> buildingSpecificFunctions = [BuildingSpecificFunction.single_family_building];

        [JsonInclude, JsonPropertyName("BuildingPhase")]
        private readonly BuildingPhase? buildingPhase;

        /// <summary>
        /// Initializes a new instance of the Building2D class with all required properties
        /// </summary>
        /// <param name="guid">The unique identifier for the building</param>
        /// <param name="reference">An optional reference string</param>
        /// <param name="polygonalFace2D">The 2D polygonal face geometry</param>
        /// <param name="storeys">The number of storeys</param>
        /// <param name="buildingPhase">The current phase of the building</param>
        /// <param name="buildingGeneralFunction">The general function of the building</param>
        /// <param name="buildingSpecificFunctions">The specific functions of the building</param>
        public Building2D(Guid guid, string? reference, PolygonalFace2D? polygonalFace2D, ushort storeys, BuildingPhase? buildingPhase, BuildingGeneralFunction? buildingGeneralFunction, IEnumerable<BuildingSpecificFunction> buildingSpecificFunctions)
            : base(guid, reference, polygonalFace2D)
        {
            this.storeys = storeys;
            this.buildingPhase = buildingPhase;
            this.buildingGeneralFunction = buildingGeneralFunction;
            this.buildingSpecificFunctions = [.. buildingSpecificFunctions];
        }

        /// <summary>
        /// Initializes a new instance of the Building2D class as a deep copy of another Building2D
        /// </summary>
        /// <param name="building2D">The Building2D to copy, or null to create an empty instance</param>
        public Building2D(Building2D building2D)
            : base(building2D)
        {
            if (building2D != null)
            {
                storeys = building2D.storeys;
                buildingPhase = building2D.buildingPhase;
                buildingGeneralFunction = building2D.buildingGeneralFunction;
                buildingSpecificFunctions = [.. building2D.buildingSpecificFunctions];
            }
        }

        /// <summary>
        /// Initializes a new instance of the Building2D class from a JSON object
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the building data</param>
        public Building2D(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Creates a deep copy of this Building2D instance
        /// </summary>
        /// <returns>A new Building2D instance with the same data</returns>
        public override ISerializableObject? Clone()
        {
            return new Building2D(this);
        }

        /// <summary>
        /// Gets the current phase of the building (e.g., occupied, unoccupied, under construction, destroyed)
        /// </summary>
        [JsonIgnore]
        public BuildingPhase? BuildingPhase
        {
            get
            {
                return buildingPhase;
            }
        }

        /// <summary>
        /// Gets the set of specific functions for this building (e.g., single_family_building, hospital, school)
        /// </summary>
        [JsonIgnore]
        public HashSet<BuildingSpecificFunction> BuildingSpecificFunctions
        {
            get
            {
                return [.. buildingSpecificFunctions];
            }
        }

        /// <summary>
        /// Gets the general function of the building (e.g., residential, commercial, industrial, educational)
        /// </summary>
        [JsonIgnore]
        public BuildingGeneralFunction? BuildingGeneralFunction
        {
            get
            {
                return buildingGeneralFunction;
            }
        }

        /// <summary>
        /// Gets the number of storeys in the building
        /// </summary>
        [JsonIgnore]
        public ushort Storeys
        {
            get
            {
                return storeys;
            }
        }
    }
}