using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public abstract class Source : GuidObject, ISource
    {
        public Source()
            : base()
        {

        }

        public Source(Source source)
            : base(source)
        {

        }

        public Source(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
