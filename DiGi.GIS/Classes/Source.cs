using DiGi.Core.Classes;
using DiGi.GIS.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Nodes;

namespace DiGi.GIS.Classes
{
    public abstract class Source : SerializableObject, ISource
    {
        public Source()
            : base()
        {

        }

        public Source(Source source)
            : base()
        {

        }

        public Source(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
