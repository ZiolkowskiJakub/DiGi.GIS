using System;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static int DefaultProcessorCount(double fraction = 0.9)
        {
            int result = System.Convert.ToInt32(Environment.ProcessorCount * fraction);
            if (result <= 0)
            {
                result = 1;
            }

            return result;
        }
    }
}