using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Classes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiGi.GIS
{
    public static partial class Create
    {
        public static async Task<OrtoDatas> OrtoDatas(this Building2D building2D, Range<int> years, double offset = 5, double width = 320, bool reduce = true, bool squared = false)
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

            boundingBox2D.Offset(offset);

            if (squared && boundingBox2D.Width != boundingBox2D.Height)
            {
                double max_Temp = Math.Max(boundingBox2D.Width, boundingBox2D.Height);

                boundingBox2D = Geometry.Planar.Create.BoundingBox2D(boundingBox2D.GetCentroid(), max_Temp, max_Temp);
            }

            double scale = width / boundingBox2D.Width;

            return await OrtoDatas(boundingBox2D, building2D.Reference, years, scale, reduce);
        }

        public static async Task<OrtoDatas> OrtoDatas(this OrtoRange ortoRange, Range<int> years, double scale, bool reduce = true, bool squared = false)
        {
            if(double.IsNaN(scale))
            {
                return null;
            }

            BoundingBox2D boundingBox2D = ortoRange?.BoundingBox2D;
            if (boundingBox2D == null)
            {
                return null;
            }

            if (squared && boundingBox2D.Width != boundingBox2D.Height)
            {
                double max_Temp = Math.Max(boundingBox2D.Width, boundingBox2D.Height);

                boundingBox2D = Geometry.Planar.Create.BoundingBox2D(boundingBox2D.GetCentroid(), max_Temp, max_Temp);
            }

            return await OrtoDatas(boundingBox2D, ortoRange.UniqueId, years, scale, reduce);
        }

        public static async Task<OrtoDatas> OrtoDatas(this BoundingBox2D boundingBox2D, string reference, Range<int> years, double scale, bool reduce = true)
        {
            List<OrtoData> values = new List<OrtoData>();

            List<int> yearsList = years.ToSystem(1);
            if (yearsList.Count != 0)
            {
                Dictionary<int, byte[]> dictionary = await Query.BytesDictionary(boundingBox2D, yearsList, scale);
                if (dictionary != null && dictionary.Count != 0)
                {
                    foreach (KeyValuePair<int, byte[]> keyValuePair in dictionary)
                    {
                        OrtoData value = new OrtoData(new DateTime(keyValuePair.Key, 1, 1), keyValuePair.Value, scale, boundingBox2D.TopLeft);
                        values.Add(value);
                    }
                }
            }

            OrtoDatas result = new OrtoDatas(reference, values);
            if (reduce)
            {
                result.Reduce();
            }

            return result;
        }
    }
}
