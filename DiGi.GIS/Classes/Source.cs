using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public abstract class Source : GuidObject, ISource
    {
        /// <summary>
        /// Initializes a new instance of the Source class
        /// </summary>
        public Source()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Source class as a copy
        /// </summary>
        public Source(Source? source)
            : base(source)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Source class from a JSON object
        /// </summary>
        public Source(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}