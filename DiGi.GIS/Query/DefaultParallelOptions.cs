using System.Threading.Tasks;

namespace DiGi.GIS
{
    public static partial class Query
    {
        public static ParallelOptions DefaultParallelOptions(double fraction = 0.9)
        {
            return new ParallelOptions()
            {
                MaxDegreeOfParallelism = DefaultProcessorCount(fraction)
            };
        }
    }
}