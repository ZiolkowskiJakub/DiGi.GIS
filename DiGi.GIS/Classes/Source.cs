using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    /// <summary>
    /// Represents an abstract base class for source objects within the GIS system.
    /// </summary>
    public abstract class Source : GuidObject, ISource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Source"/> class.
        /// </summary>
        public Source()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Source"/> class as a copy of an existing source.
        /// </summary>
        /// <param name="source">The source object to copy from.</param>
        public Source(Source? source)
            : base(source)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Source"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the source data.</param>
        public Source(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}