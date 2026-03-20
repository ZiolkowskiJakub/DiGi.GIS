using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Planar.Interfaces;
using DiGi.GIS.Enums;
using DiGi.GIS.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    public class OrtoData : SerializableObject, IGISObject
    {
        [JsonInclude, JsonPropertyName("Bytes")]
        private readonly byte[]? bytes;

        [JsonInclude, JsonPropertyName("DateTime")]
        private readonly DateTime dateTime;

        [JsonInclude, JsonPropertyName("Location")]
        private readonly Point2D? location;

        [JsonInclude, JsonPropertyName("Scale")]
        private readonly double scale;
        public OrtoData(DateTime dateTime, byte[]? bytes, double scale, Point2D? location)
        {
            this.dateTime = dateTime;
            this.bytes = bytes;
            this.scale = scale;
            this.location = location;
        }

        public OrtoData(OrtoData? ortoData)
        {
            if (ortoData != null)
            {
                dateTime = ortoData.dateTime;
                bytes = ortoData.bytes;
                scale = ortoData.scale;
                location = ortoData.location?.Clone<Point2D>();
            }
        }

        public OrtoData(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Bitmap image stored in bytes
        /// </summary>
        [JsonIgnore]
        public byte[]? Bytes
        {
            get
            {
                return bytes;
            }
        }

        [JsonIgnore]
        public DateTime DateTime
        {
            get
            {
                return dateTime;
            }
        }

        /// <summary>
        /// Top left corner of picture stored in bytes
        /// </summary>
        [JsonIgnore]
        public Point2D? Location
        {
            get
            {
                return location?.Clone<Point2D>();
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

        public Point2D? FromOrto(Point2D? point2D)
        {
            if (point2D == null)
            {
                return null;
            }

            Vector2D vector2D = new(point2D.X, -point2D.Y);
            vector2D.Scale(1 / scale);

            return point2D.GetMoved(vector2D);
        }

        public PolygonalFace2D? FromOrto(PolygonalFace2D? polygonalFace2D)
        {
            if (polygonalFace2D == null)
            {
                return null;
            }

            return Geometry.Planar.Query.Transform(polygonalFace2D, x => FromOrto(x));
        }

        public IPolygonal2D? FromOrto(IPolygonal2D? polygonal2D)
        {
            if (polygonal2D == null)
            {
                return null;
            }

            return Geometry.Planar.Query.Transform(polygonal2D, x => FromOrto(x));
        }

        public BoundingBox2D? GetBoundingBox(GeometryContext geometryContext)
        {
            if (location is null || geometryContext == GeometryContext.Undefined)
            {
                return null;
            }

            Size? size = GetSize(geometryContext);
            if (size is null)
            {
                return null;
            }

            if (geometryContext == GeometryContext.Local)
            {
                // Local: Top-Left is (0,0), Bottom-Right is (Width, -Height)
                return new BoundingBox2D(new Point2D(0, -size.Height), new Point2D(size.Width, 0));
            }

            // Global: Top-Left is 'location'. 
            // Bottom-Right is location moved by (Width, -Height)
            Point2D minPoint = new Point2D(location.X, location.Y - size.Height);
            Point2D maxPoint = new Point2D(location.X + size.Width, location.Y);

            return new BoundingBox2D(minPoint, maxPoint);
        }

        public Size? GetSize(GeometryContext geometryContext)
        {
            if(geometryContext == GeometryContext.Undefined)
            {
                return null;
            }

            Size? size = Query.Size(bytes);
            if(size is null)
            {
                return null;
            }

            if(geometryContext == GeometryContext.Local)
            {
                return size;
            }

            return size.GetScaled(1 / scale);
        }
        
        public Point2D? ToOrto(Point2D? point2D)
        {
            if (point2D == null)
            {
                return null;
            }

            Vector2D vector2D = new(location, point2D);

            vector2D.Scale(scale);

            return new Point2D(vector2D.X, -vector2D.Y);
        }

        public IPolygonal2D? ToOrto(IPolygonal2D? polygonal2D)
        {
            if (polygonal2D == null)
            {
                return null;
            }

            return Geometry.Planar.Query.Transform(polygonal2D, x => ToOrto(x));
        }

        public PolygonalFace2D? ToOrto(PolygonalFace2D? polygonalFace2D)
        {
            if (polygonalFace2D == null)
            {
                return null;
            }

            return Geometry.Planar.Query.Transform(polygonalFace2D, x => ToOrto(x));
        }
    }
}