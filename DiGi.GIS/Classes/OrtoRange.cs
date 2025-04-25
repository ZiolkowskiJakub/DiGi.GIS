using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Interfaces;

namespace DiGi.GIS.Classes
{
    public class OrtoRange : GuidObject, IGISUniqueObject
    {
        [JsonInclude, JsonPropertyName("BoundingBox2D")]
        private BoundingBox2D boundingBox2D = null;

        [JsonInclude, JsonPropertyName("References_Inside")]
        private HashSet<string> references_Inside;

        [JsonInclude, JsonPropertyName("References_Intersect")]
        private HashSet<string> references_Intersect;

        public OrtoRange(Guid guid, BoundingBox2D boundingBox2D, IEnumerable<string> references_Inside, IEnumerable<string> references_Intersect)
            : base(guid)
        {
            this.boundingBox2D = boundingBox2D?.Clone<BoundingBox2D>();
            this.references_Inside = references_Inside == null ? null : new HashSet<string>(references_Inside);
            this.references_Intersect = references_Intersect == null ? null : new HashSet<string>(references_Intersect);
        }

        public OrtoRange(BoundingBox2D boundingBox2D, IEnumerable<string> references_Inside, IEnumerable<string> references_Intersect)
            : base(Guid.NewGuid())
        {
            this.boundingBox2D = boundingBox2D?.Clone<BoundingBox2D>();
            this.references_Inside = references_Inside == null ? null : new HashSet<string>(references_Inside);
            this.references_Intersect = references_Intersect == null ? null : new HashSet<string>(references_Intersect);
        }

        public OrtoRange(OrtoRange ortoRange)
            : base(ortoRange)
        {
            if(ortoRange != null)
            {
                boundingBox2D = ortoRange.boundingBox2D?.Clone<BoundingBox2D>();
                references_Inside = ortoRange.references_Inside == null ? null : new HashSet<string>(ortoRange.references_Inside);
                references_Intersect = ortoRange.references_Intersect == null ? null : new HashSet<string>(ortoRange.references_Intersect);
            }
        }

        public OrtoRange(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        [JsonIgnore]
        public BoundingBox2D BoundingBox2D
        {
            get
            {
                return boundingBox2D?.Clone<BoundingBox2D>();
            }
        }

        [JsonIgnore]
        public HashSet<string> References_InRange
        {
            get
            {
                if (references_Inside == null && references_Intersect == null)
                {
                    return null;
                }

                HashSet<string> result = new HashSet<string>();

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

        [JsonIgnore]
        public HashSet<string> References_Inside
        {
            get
            {
                return references_Inside == null ? null : new HashSet<string>(references_Inside);
            }
        }

        [JsonIgnore]
        public HashSet<string> References_Intersect
        {
            get
            {
                return references_Intersect == null ? null : new HashSet<string>(references_Intersect);
            }
        }

        public bool Contains(string reference)
        {
            return (references_Inside != null && references_Inside.Contains(reference)) || (references_Intersect != null && references_Intersect.Contains(reference));
        }

        public bool InRange(string reference)
        {
            return (references_Inside != null && references_Inside.Contains(reference)) || (references_Intersect != null && references_Intersect.Contains(reference));
        }

        public bool Inside(string reference)
        {
            return references_Inside != null && references_Inside.Contains(reference);
        }

        public bool Intersect(string reference)
        {
            return references_Intersect != null && references_Intersect.Contains(reference);
        }
    }
}
