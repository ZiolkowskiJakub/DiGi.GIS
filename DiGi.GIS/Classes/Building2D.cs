using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Core.Interfaces;
using DiGi.GIS.Enums;
using DiGi.Geometry.Planar.Classes;

namespace DiGi.GIS.Classes
{
    public class Building2D : Areal2D
    {
        [JsonInclude, JsonPropertyName("Storeys")]
        private ushort storeys = 1;

        [JsonInclude, JsonPropertyName("BuildingGeneralFunction")]
        private BuildingGeneralFunction? buildingGeneralFunction;

        [JsonInclude, JsonPropertyName("BuildingSpecificFunctions")]
        private HashSet<BuildingSpecificFunction> buildingSpecificFunctions;

        [JsonInclude, JsonPropertyName("BuildingPhase")]
        private BuildingPhase? buildingPhase;

        public Building2D(Guid guid, string reference, PolygonalFace2D polygonalFace2D, ushort storeys, BuildingPhase? buildingPhase, BuildingGeneralFunction? buildingGeneralFunction, IEnumerable<BuildingSpecificFunction> buildingSpecificFunctions)
            : base(guid, reference, polygonalFace2D)
        {
            this.storeys = storeys;
            this.buildingPhase = buildingPhase;
            this.buildingGeneralFunction = buildingGeneralFunction;
            this.buildingSpecificFunctions = buildingSpecificFunctions == null ? null : new HashSet<BuildingSpecificFunction>(buildingSpecificFunctions);
        }

        public Building2D(Building2D building2D)
            : base(building2D)
        {
            if(building2D != null)
            {
                storeys = building2D.storeys;
                buildingPhase = building2D.buildingPhase;
                buildingGeneralFunction = building2D.buildingGeneralFunction;
                buildingSpecificFunctions = building2D.buildingSpecificFunctions == null ? null : new HashSet<BuildingSpecificFunction>(building2D.buildingSpecificFunctions);
            }
        }

        public Building2D(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public override ISerializableObject Clone()
        {
            return new Building2D(this);
        }

        [JsonIgnore]
        public BuildingPhase? BuildingPhase
        {
            get
            {
                return buildingPhase;
            }
        }

        [JsonIgnore]
        public HashSet<BuildingSpecificFunction> BuildingSpecificFunctions
        {
            get
            {
                return buildingSpecificFunctions == null ? null : new HashSet<BuildingSpecificFunction>(buildingSpecificFunctions);
            }
        }

        [JsonIgnore]
        public BuildingGeneralFunction? BuildingGeneralFunction
        {
            get
            {
                return buildingGeneralFunction;
            }
        }

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
