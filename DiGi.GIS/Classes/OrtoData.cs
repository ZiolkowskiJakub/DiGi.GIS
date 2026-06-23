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
    /// <summary>
    /// Represents orthophoto data, containing the image bytes, timestamp, location, and scale factor.
    /// </summary>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoData"/> class.
        /// </summary>
        /// <param name="dateTime">The date and time associated with the orthophoto data.</param>
        /// <param name="bytes">The bitmap image stored as bytes.</param>
        /// <param name="scale">The scale factor of the image.</param>
        /// <param name="location">The top-left corner coordinates of the picture.</param>
        public OrtoData(DateTime dateTime, byte[]? bytes, double scale, Point2D? location)
        {
            this.dateTime = dateTime;
            this.bytes = bytes;
            this.scale = scale;
            this.location = location;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoData"/> class by copying an existing instance.
        /// </summary>
        /// <param name="ortoData">The source orthophoto data to copy from.</param>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoData"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing orthophoto data.</param>
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

        /// <summary>
        /// Gets the date and time associated with the orthophoto data.
        /// </summary>
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

        /// <summary>
        /// Gets the scale factor of the orthophoto.
        /// </summary>
        [JsonIgnore]
        public double Scale
        {
            get
            {
                return scale;
            }
        }

        /// <summary>
        /// Transforms a point from orthophoto coordinates to world/GIS coordinates.
        /// </summary>
        /// <param name="point2D">The point in orthophoto coordinates.</param>
        /// <returns>The transformed point in world/GIS coordinates, or null if the input is null.</returns>
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

        /// <summary>
        /// Transforms a polygonal face from orthophoto coordinates to world/GIS coordinates.
        /// </summary>
        /// <param name="polygonalFace2D">The polygonal face in orthophoto coordinates.</param>
        /// <returns>The transformed polygonal face in world/GIS coordinates, or null if the input is null.</returns>
        public PolygonalFace2D? FromOrto(PolygonalFace2D? polygonalFace2D)
        {
            if (polygonalFace2D == null)
            {
                return null;
            }

            return Geometry.Planar.Query.Transform(polygonalFace2D, x => FromOrto(x));
        }

        /// <summary>
        /// Transforms a polygonal object from orthophoto coordinates to world/GIS coordinates.
        /// </summary>
        /// <param name="polygonal2D">The polygonal object in orthophoto coordinates.</param>
        /// <returns>The transformed polygonal object in world/GIS coordinates, or null if the input is null.</returns>
        public IPolygonal2D? FromOrto(IPolygonal2D? polygonal2D)
        {
            if (polygonal2D == null)
            {
                return null;
            }

            return Geometry.Planar.Query.Transform(polygonal2D, x => FromOrto(x));
        }

        /// <summary>
        /// Calculates the bounding box of the orthophoto data based on the specified geometry context.
        /// </summary>
        /// <param name="geometryContext">The coordinate system context (Local or Global) for the bounding box.</param>
        /// <returns>A <see cref="BoundingBox2D"/> representing the area, or null if location is missing or context is undefined.</returns>
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
            Point2D minPoint = new(location.X, location.Y - size.Height);
            Point2D maxPoint = new(location.X + size.Width, location.Y);

            return new BoundingBox2D(minPoint, maxPoint);
        }

        /// <summary>
        /// Retrieves the dimensions of the orthophoto image, adjusted for the specified geometry context.
        /// </summary>
        /// <param name="geometryContext">The coordinate system context (Local or Global) to determine scaling.</param>
        /// <returns>A <see cref="Size"/> object containing width and height, or null if undefined or bytes are missing.</returns>
        public Size? GetSize(GeometryContext geometryContext)
        {
            if (geometryContext == GeometryContext.Undefined)
            {
                return null;
            }

            Size? size = Query.Size(bytes);
            if (size is null)
            {
                return null;
            }

            if (geometryContext == GeometryContext.Local)
            {
                return size;
            }

            return size.GetScaled(1 / scale);
        }

        /// <summary>
        /// Transforms a point from world/GIS coordinates to orthophoto coordinates.
        /// </summary>
        /// <param name="point2D">The point in world/GIS coordinates.</param>
        /// <returns>The transformed point in orthophoto coordinates, or null if the input is null.</returns>
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

        /// <summary>
        /// Transforms a polygonal object from world/GIS coordinates to orthophoto coordinates.
        /// </summary>
        /// <param name="polygonal2D">The polygonal object in world/GIS coordinates.</param>
        /// <returns>The transformed polygonal object in orthophoto coordinates, or null if the input is null.</returns>
        public IPolygonal2D? ToOrto(IPolygonal2D? polygonal2D)
        {
            if (polygonal2D == null)
            {
                return null;
            }

            return Geometry.Planar.Query.Transform(polygonal2D, x => ToOrto(x));
        }

        /// <summary>
        /// Transforms a polygonal face from world/GIS coordinates to orthophoto coordinates.
        /// </summary>
        /// <param name="polygonalFace2D">The polygonal face in world/GIS coordinates.</param>
        /// <returns>The transformed polygonal face in orthophoto coordinates, or null if the input is null.</returns>
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