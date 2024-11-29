using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Classes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiGi.GIS
{
    public static partial class Create
    {
        public static async Task<OrtoDatas> OrtoDatas(this Building2D building2D, Range<int> years, double offset = 5, double width = 300, bool reduce = true)
        {
            if(building2D == null || years == null)
            {
                return null;
            }

            BoundingBox2D boundingBox2D = building2D.PolygonalFace2D?.GetBoundingBox();
            if(boundingBox2D == null)
            {
                return null;
            }

            List<OrtoData> values = new List<OrtoData>();

            List<int> yearsList = years.ToSystem(1);
            if(yearsList.Count != 0)
            {
                Dictionary<int, byte[]> dictionary = await Query.BytesDictionary(boundingBox2D, yearsList, offset, width);
                if(dictionary != null && dictionary.Count != 0)
                {
                    double scale = boundingBox2D.Width / width;
                    foreach(KeyValuePair<int, byte[]> keyValuePair in dictionary)
                    {
                        OrtoData value = new OrtoData(new System.DateTime(keyValuePair.Key, 1, 1), keyValuePair.Value, scale, boundingBox2D.GetCentroid());
                        values.Add(value);
                    }
                }
            }

            OrtoDatas result = new OrtoDatas(building2D.Reference, values);
            if(reduce)
            {
                result.Reduce();
            }

            return result;
        }
    }
}
