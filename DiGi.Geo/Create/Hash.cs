using DiGi.GML.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Geo
{
    public static partial class Create
    {
        public static long Hash(string @string)
        {
            if (string.IsNullOrEmpty(@string))
            {
                return 0;
            }

            long result = 0;
            foreach (char @char in @string)
            {
                result = (result * 31) + @char;
            }

            return result;
        }

        public static long Hash(IEnumerable<double> doubles)
        {
            if (doubles == null || doubles.Count() == 0)
            {
                return 0;
            }

            long result = 17;
            foreach (double @double in doubles)
            {
                result = result * 31 + @double.GetHashCode();
            }

            return result;
        }

        public static long Hash(IEnumerable<long> longs)
        {
            if (longs == null || longs.Count() == 0)
            {
                return 0;
            }

            long result = 17;
            foreach (long @long in longs)
            {
                result = result * 31 + @long.GetHashCode();
            }

            return result;
        }

        public static long Hash<T>(IEnumerable<T> geometries) where T : GML.Classes.Geometry
        {
            if (geometries == null || geometries.Count() == 0)
            {
                return 0;
            }

            List<long> hashes = new List<long>();
            foreach (T geometry in geometries)
            {
                if(geometry is Polygon)
                {
                    hashes.Add(Hash((Polygon)(object)geometry));
                }
                else if(geometry is LinearRing)
                {
                    hashes.Add(Hash((LinearRing)(object)geometry));
                }
                else
                {
                    throw new System.NotImplementedException();
                }
            }

            return Hash(hashes);
        }

        public static long Hash(LinearRing linearRing)
        {
            if (linearRing == null)
            {
                return 0;
            }

            List<long> hashes = new List<long>()
            {
                Hash(Core.Query.FullTypeName(linearRing.GetType())),
                Hash(linearRing.posList)
            };

            return Hash(hashes);
        }

        public static long Hash(Polygon polygon)
        {
            if (polygon == null)
            {
                return 0;
            }

            List<long> hashes = new List<long>()
            {
                Hash(Core.Query.FullTypeName(polygon.GetType())),
                Hash(polygon.exterior),
                Hash(polygon.interior),
            };

            return Hash(hashes);
        }
    }
}
