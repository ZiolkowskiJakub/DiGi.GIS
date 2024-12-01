using System;
using System.IO;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Interfaces;

namespace DiGi.GIS.Classes
{
    public class OrtoData : SerializableObject, IGISObject
    {
        [JsonInclude, JsonPropertyName("DateTime")]
        private DateTime dateTime;

        [JsonInclude, JsonPropertyName("Bytes")]
        private byte[] bytes;

        [JsonInclude, JsonPropertyName("Scale")]
        private double scale;

        [JsonInclude, JsonPropertyName("Location")]
        private Point2D location;

        public OrtoData(DateTime dateTime, byte[] bytes, double scale, Point2D location)
        {
            this.dateTime = dateTime;
            this.bytes = bytes;
            this.scale = scale;
            this.location = location;
        }

        public OrtoData(OrtoData ortoData)
        {
            if (ortoData != null)
            {
                dateTime = ortoData.dateTime;
                bytes = ortoData.bytes;
                scale = ortoData.scale;
                location = ortoData.location?.Clone<Point2D>();
            }
        }

        public OrtoData(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public DateTime DateTime
        {
            get
            {
                return dateTime;
            }
        }

        [JsonIgnore]
        public byte[] Bytes
        {
            get
            {
                return bytes;
            }
        }

        [JsonIgnore]
        public double Scale
        {
            get
            {
                return scale;
            }
        }

        [JsonIgnore]
        public Point2D Location
        {
            get
            {
                return location?.Clone<Point2D>();
            }
        }

        public Point2D ToOrto(Point2D point2D)
        {
            if(point2D == null)
            {
                return null;
            }

            Vector2D vector2D = new Vector2D(location, point2D);

            vector2D.Scale(1 / scale);

            return new Point2D(vector2D.X, - vector2D.Y);
        }

        public Point2D FromOrto(Point2D point2D)
        {
            if (point2D == null)
            {
                return null;
            }

            Vector2D vector2D = new Vector2D(point2D.X, - point2D.Y);
            vector2D.Scale(scale);

            return point2D.GetMoved(vector2D);
        }
    }
}
