using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Core;
using DiGi.Geometry.Planar.Classes;

namespace DiGi.GIS.Classes
{
    public abstract class Areal2D : Object2D
    {
        [JsonInclude, JsonPropertyName("PolygonalFace2D")]
        private PolygonalFace2D polygonalFace2D = null;

        public Areal2D(Guid guid, string reference, PolygonalFace2D polygonalFace2D)
            : base(guid, reference)
        {
            this.polygonalFace2D = polygonalFace2D?.Clone<PolygonalFace2D>();
        }

        public Areal2D(Areal2D areal2D)
            : base(areal2D)
        {
            if(areal2D != null)
            {
                polygonalFace2D = areal2D.polygonalFace2D?.Clone<PolygonalFace2D>();
            }
        }

        public Areal2D(JsonObject jsonObject)
            :base(jsonObject)
        {

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
