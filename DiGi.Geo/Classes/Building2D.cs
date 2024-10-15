using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Geo.Enums;
using DiGi.Geometry.Planar.Classes;

namespace DiGi.Geo.Classes
{
    public class Building2D : UniqueObject
    {
        [JsonInclude, JsonPropertyName("PolygonalFace2D")]
        private PolygonalFace2D polygonalFace2D = null;

        [JsonInclude, JsonPropertyName("Storeys")]
        private ushort storeys = 1;

        [JsonInclude, JsonPropertyName("Reference")]
        private string reference = null;

        [JsonInclude, JsonPropertyName("Occupancy")]
        private ushort occupancy = 0;

        [JsonInclude, JsonPropertyName("BuildingGeneralFunction")]
        private BuildingGeneralFunction? buildingGeneralFunction;

        [JsonInclude, JsonPropertyName("BuildingSpecificFunctions")]
        private HashSet<BuildingSpecificFunction> buildingSpecificFunctions;

        [JsonInclude, JsonPropertyName("BuildingPhase")]
        private BuildingPhase? buildingPhase;

        public Building2D(Guid guid, PolygonalFace2D polygonalFace2D, ushort storeys, string reference, ushort occupancy, BuildingPhase? buildingPhase, BuildingGeneralFunction? buildingGeneralFunction, IEnumerable<BuildingSpecificFunction> buildingSpecificFunctions)
            : base(guid)
        {
            polygonalFace2D = polygonalFace2D?.Clone<PolygonalFace2D>();
            this.storeys = storeys;
            this.reference = reference;
            this.occupancy = occupancy;
            this.buildingPhase = buildingPhase;
            this.buildingGeneralFunction = buildingGeneralFunction;
            this.buildingSpecificFunctions = buildingSpecificFunctions == null ? null : new HashSet<BuildingSpecificFunction>(buildingSpecificFunctions);
        }

        public Building2D(Building2D building2D)
            : base(building2D == null ? Guid.Empty : building2D.Guid)
        {
            if(building2D != null)
            {
                polygonalFace2D = building2D.polygonalFace2D?.Clone<PolygonalFace2D>();
                storeys = building2D.storeys;
                reference = building2D.reference;
                occupancy = building2D.occupancy;
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
        public PolygonalFace2D PolygonalFace2D
        {
            get
            {
                return polygonalFace2D?.Clone<PolygonalFace2D>();
            }
        }

    }
}
