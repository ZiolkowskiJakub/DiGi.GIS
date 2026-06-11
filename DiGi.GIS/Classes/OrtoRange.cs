using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents an <see cref="OrtoRange"/> object that inherits from <see cref="GuidObject"/> and implements the <see cref="IGISUniqueObject"/> interface.
    /// </summary>
    public class OrtoRange : GuidObject, IGISUniqueObject
    {
        [JsonInclude, JsonPropertyName("BoundingBox2D")]
        private readonly BoundingBox2D? boundingBox2D = null;

        [JsonInclude, JsonPropertyName("References_Inside")]
        private readonly HashSet<string>? references_Inside;

        [JsonInclude, JsonPropertyName("References_Intersect")]
        private readonly HashSet<string>? references_Intersect;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoRange"/> class.
        /// </summary>
        /// <param name="guid">The unique identifier for the <see cref="OrtoRange"/>.</param>
        /// <param name="boundingBox2D">The optional <see cref="BoundingBox2D"/> that defines the spatial boundaries of the range.</param>
        /// <param name="references_Inside">An optional collection of <see cref="string"/> references located inside the range.</param>
        /// <param name="references_Intersect">An optional collection of <see cref="string"/> references that intersect with the range.</param>
        public OrtoRange(Guid guid, BoundingBox2D? boundingBox2D, IEnumerable<string>? references_Inside, IEnumerable<string>? references_Intersect)
            : base(guid)
        {
            this.boundingBox2D = boundingBox2D?.Clone<BoundingBox2D>();
            this.references_Inside = references_Inside == null ? null : [.. references_Inside];
            this.references_Intersect = references_Intersect == null ? null : [.. references_Intersect];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoRange"/> class.
        /// </summary>
        /// <param name="boundingBox2D">The optional <see cref="BoundingBox2D"/> that defines the spatial boundaries of the range.</param>
        /// <param name="references_Inside">An optional <see cref="IEnumerable{T}"/> of <see cref="string"/> containing references located inside the range.</param>
        /// <param name="references_Intersect">An optional <see cref="IEnumerable{T}"/> of <see cref="string"/> containing references that intersect with the range.</param>
        public OrtoRange(BoundingBox2D? boundingBox2D, IEnumerable<string>? references_Inside, IEnumerable<string>? references_Intersect)
            : base(Guid.NewGuid())
        {
            this.boundingBox2D = boundingBox2D?.Clone<BoundingBox2D>();
            this.references_Inside = references_Inside == null ? null : [.. references_Inside];
            this.references_Intersect = references_Intersect == null ? null : [.. references_Intersect];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoRange"/> class using the specified <see cref="OrtoRange"/> instance.
        /// </summary>
        /// <param name="ortoRange">The <see cref="OrtoRange"/> instance to copy from.</param>
        public OrtoRange(OrtoRange? ortoRange)
            : base(ortoRange)
        {
            if (ortoRange != null)
            {
                boundingBox2D = ortoRange.boundingBox2D?.Clone<BoundingBox2D>();
                references_Inside = ortoRange.references_Inside == null ? null : [.. ortoRange.references_Inside];
                references_Intersect = ortoRange.references_Intersect == null ? null : [.. ortoRange.references_Intersect];
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrtoRange"/> class using the specified <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> used to initialize the current instance.</param>
        public OrtoRange(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the <see cref="BoundingBox2D"/> that defines the axis-aligned bounding box of the object in two-dimensional space.
        /// This value is null if no bounding box is defined.
        /// </summary>
        [JsonIgnore]
        public BoundingBox2D? BoundingBox2D
        {
            get
            {
                return boundingBox2D?.Clone<BoundingBox2D>();
            }
        }

        /// <summary>
        /// Gets or sets the <see cref="HashSet{T}"/> of <see cref="string"/> references that are within the specified range.
        /// </summary>
        /// <value>
        /// A <see cref="HashSet{T}"/> containing string references, or <see langword="null"/> if no references are in range.
        /// </value>
        [JsonIgnore]
        public HashSet<string>? References_InRange
        {
            get
            {
                if (references_Inside == null && references_Intersect == null)
                {
                    return null;
                }

                HashSet<string> result = [];

                if (references_Inside != null)
                {
                    foreach (string reference in references_Inside)
                    {
                        result.Add(reference);
                    }
                }

                if (references_Intersect != null)
                {
                    foreach (string reference in references_Intersect)
                    {
                        result.Add(reference);
                    }
                }

                return result;
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="HashSet{T}"/> of <see cref="string"/> values representing the references contained inside the current object.
        /// </summary>
        [JsonIgnore]
        public HashSet<string>? References_Inside
        {
            get
            {
                return references_Inside == null ? null : [.. references_Inside];
            }
        }

        /// <summary>
        /// Gets or sets a <see cref="HashSet{T}"/> of <see cref="string"/> objects representing the intersection of references.
        /// </summary>
        [JsonIgnore]
        public HashSet<string>? References_Intersect
        {
            get
            {
                return references_Intersect == null ? null : [.. references_Intersect];
            }
        }

        /// <summary>
        /// Determines whether the collection contains a specific string reference.
        /// </summary>
        /// <param name="reference">The <see cref="string"/> reference to locate in the collection.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the specified <see cref="string"/> was found.</returns>
        public bool Contains(string? reference)
        {
            if (reference == null)
            {
                return false;
            }

            return (references_Inside != null && references_Inside.Contains(reference)) || (references_Intersect != null && references_Intersect.Contains(reference));
        }

        /// <summary>
        /// Determines whether the specified reference is within the valid range.
        /// </summary>
        /// <param name="reference">The <see cref="string"/> reference to evaluate.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the <see cref="string"/> reference is in range.</returns>
        public bool InRange(string? reference)
        {
            if (reference == null)
            {
                return false;
            }

            return (references_Inside != null && references_Inside.Contains(reference)) || (references_Intersect != null && references_Intersect.Contains(reference));
        }

        /// <summary>
        /// Determines whether the specified reference is contained within the current context.
        /// </summary>
        /// <param name="reference">The string reference to evaluate.</param>
        /// <returns>A boolean value indicating true if the reference is inside; otherwise, false.</returns>
        public bool Inside(string? reference)
        {
            if (reference == null)
            {
                return false;
            }

            return references_Inside != null && references_Inside.Contains(reference);
        }

        /// <summary>
        /// Determines whether there is an intersection with the specified reference string.
        /// </summary>
        /// <param name="reference">The nullable <see cref="string"/> reference to intersect with.</param>
        /// <returns>A <see cref="bool"/> value indicating whether the intersection occurred.</returns>
        public bool Intersect(string? reference)
        {
            if (reference == null)
            {
                return false;
            }

            return references_Intersect != null && references_Intersect.Contains(reference);
        }
    }
}