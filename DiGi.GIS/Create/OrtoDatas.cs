using DiGi.Core;
using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Classes;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DiGi.GIS
{
    public static partial class Create
    {
        /// <summary>
        /// Asynchronously retrieves orthophoto data for a specified building within a given range of years.
        /// </summary>
        /// <param name="building2D">The building object used to determine the area of interest.</param>
        /// <param name="years">The range of years for which to retrieve orthophoto data.</param>
        /// <param name="offset">The offset distance to expand the bounding box around the building.</param>
        /// <param name="width">The desired width of the resulting image data.</param>
        /// <param name="reduce">A value indicating whether to reduce the result set.</param>
        /// <param name="squared">A value indicating whether the requested area should be forced into a square shape.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the OrtoDatas if successful; otherwise, null.</returns>
        public static async Task<OrtoDatas?> OrtoDatas(this Building2D? building2D, Range<int>? years, double offset = 5, double width = 320, bool reduce = true, bool squared = false)
        {
            if (building2D == null || years == null)
            {
                return null;
            }

            BoundingBox2D? boundingBox2D = building2D.PolygonalFace2D?.GetBoundingBox();
            if (boundingBox2D is null)
            {
                return null;
            }

            boundingBox2D.Offset(offset);

            if (squared && boundingBox2D.Width != boundingBox2D.Height)
            {
                double max_Temp = Math.Max(boundingBox2D.Width, boundingBox2D.Height);

                boundingBox2D = Geometry.Planar.Create.BoundingBox2D(boundingBox2D.GetCentroid(), max_Temp, max_Temp);
            }

            if (boundingBox2D is null)
            {
                return null;
            }

            double scale = width / boundingBox2D.Width;

            return await OrtoDatas(boundingBox2D, building2D.Reference, years, scale, reduce);
        }

        /// <summary>
        /// Asynchronously retrieves orthophoto data for a specified building using a provided HttpClient and within a given range of years.
        /// </summary>
        /// <param name="httpClient">The HTTP client used to perform the network requests.</param>
        /// <param name="building2D">The building object used to determine the area of interest.</param>
        /// <param name="years">The range of years for which to retrieve orthophoto data.</param>
        /// <param name="offset">The offset distance to expand the bounding box around the building.</param>
        /// <param name="width">The desired width of the resulting image data.</param>
        /// <param name="reduce">A value indicating whether to reduce the result set.</param>
        /// <param name="squared">A value indicating whether the requested area should be forced into a square shape.</param>
        /// <param name="initialRequestCount">The initial number of requests to perform when querying data.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the OrtoDatas if successful; otherwise, null.</returns>
        public static async Task<OrtoDatas?> OrtoDatas(this HttpClient httpClient, Building2D? building2D, Range<int>? years, double offset = 5, double width = 320, bool reduce = true, bool squared = false, int initialRequestCount = 8)
        {
            if (building2D is null || years is null || httpClient is null)
            {
                return null;
            }

            BoundingBox2D? boundingBox2D = building2D.PolygonalFace2D?.GetBoundingBox();
            if (boundingBox2D is null)
            {
                return null;
            }

            boundingBox2D.Offset(offset);

            if (squared && boundingBox2D.Width != boundingBox2D.Height)
            {
                double max_Temp = Math.Max(boundingBox2D.Width, boundingBox2D.Height);

                boundingBox2D = Geometry.Planar.Create.BoundingBox2D(boundingBox2D.GetCentroid(), max_Temp, max_Temp);
            }

            if (boundingBox2D is null)
            {
                return null;
            }

            double scale = width / boundingBox2D.Width;

            return await OrtoDatas(httpClient, boundingBox2D, building2D.Reference, years, scale, reduce, initialRequestCount);
        }

        /// <summary>
        /// Asynchronously retrieves orthophoto data based on an existing OrtoRange and a specified year range.
        /// </summary>
        /// <param name="ortoRange">The source range containing the bounding box and unique identifier.</param>
        /// <param name="years">The range of years for which to retrieve orthophoto data.</param>
        /// <param name="scale">The scale factor used for the image request.</param>
        /// <param name="reduce">A value indicating whether to reduce the result set.</param>
        /// <param name="squared">A value indicating whether the requested area should be forced into a square shape.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the OrtoDatas if successful; otherwise, null.</returns>
        public static async Task<OrtoDatas?> OrtoDatas(this OrtoRange? ortoRange, Range<int>? years, double scale, bool reduce = true, bool squared = false)
        {
            if (double.IsNaN(scale))
            {
                return null;
            }

            BoundingBox2D? boundingBox2D = ortoRange?.BoundingBox2D;
            if (boundingBox2D == null)
            {
                return null;
            }

            if (squared && boundingBox2D.Width != boundingBox2D.Height)
            {
                double max_Temp = Math.Max(boundingBox2D.Width, boundingBox2D.Height);

                boundingBox2D = Geometry.Planar.Create.BoundingBox2D(boundingBox2D.GetCentroid(), max_Temp, max_Temp);
            }

            return await OrtoDatas(boundingBox2D, ortoRange?.UniqueId, years, scale, reduce);
        }

        /// <summary>
        /// Asynchronously retrieves orthophoto data for a specific bounding box and year range.
        /// </summary>
        /// <param name="boundingBox2D">The geographic area to retrieve data for.</param>
        /// <param name="reference">A reference string associated with the requested data.</param>
        /// <param name="years">The range of years for which to retrieve orthophoto data.</param>
        /// <param name="scale">The scale factor used for the image request.</param>
        /// <param name="reduce">A value indicating whether to reduce the result set.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the OrtoDatas if successful; otherwise, null.</returns>
        public static async Task<OrtoDatas?> OrtoDatas(this BoundingBox2D? boundingBox2D, string? reference, Range<int>? years, double scale, bool reduce = true)
        {
            if (boundingBox2D is null)
            {
                return null;
            }

            List<OrtoData> values = [];

            List<int>? yearsList = years.ToSystem(1);
            if (yearsList is null)
            {
                return null;
            }

            if (yearsList.Count != 0)
            {
                Dictionary<int, byte[]>? dictionary = await Query.BytesDictionary(boundingBox2D, yearsList, scale);
                if (dictionary != null && dictionary.Count != 0)
                {
                    foreach (KeyValuePair<int, byte[]> keyValuePair in dictionary)
                    {
                        OrtoData value = new(new DateTime(keyValuePair.Key, 1, 1), keyValuePair.Value, scale, boundingBox2D.TopLeft);
                        values.Add(value);
                    }
                }
            }

            OrtoDatas result = new(reference, values);
            if (reduce)
            {
                result.Reduce();
            }

            return result;
        }

        /// <summary>
        /// Asynchronously retrieves orthophoto data for a specific bounding box using a provided HttpClient and year range.
        /// </summary>
        /// <param name="httpClient">The HTTP client used to perform the network requests.</param>
        /// <param name="boundingBox2D">The geographic area to retrieve data for.</param>
        /// <param name="reference">A reference string associated with the requested data.</param>
        /// <param name="years">The range of years for which to retrieve orthophoto data.</param>
        /// <param name="scale">The scale factor used for the image request.</param>
        /// <param name="reduce">A value indicating whether to reduce the result set.</param>
        /// <param name="initialRequestCount">The initial number of requests to perform when querying data.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the OrtoDatas if successful; otherwise, null.</returns>
        public static async Task<OrtoDatas?> OrtoDatas(this HttpClient httpClient, BoundingBox2D? boundingBox2D, string? reference, Range<int>? years, double scale, bool reduce = true, int initialRequestCount = 8)
        {
            if (boundingBox2D is null || httpClient is null)
            {
                return null;
            }

            List<OrtoData> values = [];

            List<int>? yearsList = years.ToSystem(1);
            if (yearsList is null)
            {
                return null;
            }

            if (yearsList.Count != 0)
            {
                Dictionary<int, byte[]>? dictionary = await Query.BytesDictionary(httpClient, boundingBox2D, yearsList, scale, initialRequestCount);
                if (dictionary != null && dictionary.Count != 0)
                {
                    foreach (KeyValuePair<int, byte[]> keyValuePair in dictionary)
                    {
                        OrtoData value = new(new DateTime(keyValuePair.Key, 1, 1), keyValuePair.Value, scale, boundingBox2D.TopLeft);
                        values.Add(value);
                    }
                }
            }

            OrtoDatas result = new(reference, values);
            if (reduce)
            {
                result.Reduce();
            }

            return result;
        }
    }
}