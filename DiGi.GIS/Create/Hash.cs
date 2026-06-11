using DiGi.GML.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.GIS
{
    public static partial class Create
    {
        /// <summary>
        /// Computes a hash value for the specified string.
        /// </summary>
        /// <param name="string">The string to be hashed.</param>
        /// <returns>A long integer representing the computed hash of the string; returns 0 if the string is null or empty.</returns>
        public static long Hash(string? @string)
        {
            if (string.IsNullOrEmpty(@string))
            {
                return 0;
            }

            long result = 0;
            foreach (char @char in @string!)
            {
                result = (result * 31) + @char;
            }

            return result;
        }

        /// <summary>
        /// Computes a hash value for the specified collection of double-precision floating-point numbers.
        /// </summary>
        /// <param name="doubles">The collection of doubles to be hashed.</param>
        /// <returns>A long integer representing the computed hash of the collection; returns 0 if the collection is null or empty.</returns>
        public static long Hash(IEnumerable<double>? doubles)
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

        /// <summary>
        /// Computes a hash value for the specified collection of long integers.
        /// </summary>
        /// <param name="longs">The collection of longs to be hashed.</param>
        /// <returns>A long integer representing the computed hash of the collection; returns 0 if the collection is null or empty.</returns>
        public static long Hash(IEnumerable<long>? longs)
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

        /// <summary>
        /// Computes a hash value for the specified collection of geometry objects.
        /// </summary>
        /// <typeparam name="T">The type of geometry object, which must derive from <see cref="GML.Classes.Geometry"/>.</typeparam>
        /// <param name="geometries">The collection of geometries to be hashed.</param>
        /// <returns>A long integer representing the computed hash of the geometry collection; returns 0 if the collection is null or empty.</returns>
        public static long Hash<T>(IEnumerable<T>? geometries) where T : GML.Classes.Geometry
        {
            if (geometries == null || geometries.Count() == 0)
            {
                return 0;
            }

            List<long> hashes = [];
            foreach (T geometry in geometries)
            {
                if (geometry is Polygon)
                {
                    hashes.Add(Hash((Polygon)(object)geometry));
                }
                else if (geometry is LinearRing)
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

        /// <summary>
        /// Computes a hash value for the specified linear ring.
        /// </summary>
        /// <param name="linearRing">The linear ring to be hashed.</param>
        /// <returns>A long integer representing the computed hash of the linear ring; returns 0 if the object is null.</returns>
        public static long Hash(LinearRing? linearRing)
        {
            if (linearRing == null)
            {
                return 0;
            }

            List<long> hashes =
            [
                Hash(Core.Query.FullTypeName(linearRing.GetType())),
                Hash(linearRing.posList)
            ];

            return Hash(hashes);
        }

        /// <summary>
        /// Computes a hash value for the specified polygon.
        /// </summary>
        /// <param name="polygon">The polygon to be hashed.</param>
        /// <returns>A long integer representing the computed hash of the polygon; returns 0 if the object is null.</returns>
        public static long Hash(Polygon? polygon)
        {
            if (polygon == null)
            {
                return 0;
            }

            List<long> hashes =
            [
                Hash(Core.Query.FullTypeName(polygon.GetType())),
                Hash(polygon.exterior),
                Hash(polygon.interior),
            ];

            return Hash(hashes);
        }
    }
}