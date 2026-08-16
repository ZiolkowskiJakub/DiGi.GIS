using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Spatial.Classes;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace DiGi.GIS
{
    public static partial class Query
    {
        /// <summary>
        /// Asynchronously retrieves elevation data for a collection of 2D points with concurrency throttling.
        /// </summary>
        /// <param name="httpClient">The HTTP client instance used for sending requests.</param>
        /// <param name="point2Ds">The collection of 2D points to query elevation for.</param>
        /// <param name="maxConcurrentRequests">Maximum number of concurrent HTTP requests allowed.</param>
        /// <returns>A list of 3D points containing elevation data, or null if input parameters are null.</returns>
        public static async Task<List<Point3D>?> ElevationsAsync(this HttpClient? httpClient, IEnumerable<Point2D>? point2Ds, int maxConcurrentRequests = 10)
        {
            if (point2Ds == null || httpClient == null)
            {
                return null;
            }

            Point2D[] point2Ds_Array = [.. point2Ds];
            if (point2Ds_Array.Length == 0)
            {
                return [];
            }

            Point3D?[] point3Ds_Array = new Point3D?[point2Ds_Array.Length];
            using SemaphoreSlim semaphoreSlim = new(maxConcurrentRequests);

            List<Task> tasks = [];
            for (int i = 0; i < point2Ds_Array.Length; i++)
            {
                int index = i;
                Point2D point2D = point2Ds_Array[index];

                await semaphoreSlim.WaitAsync();

                tasks.Add(Task.Run(async () =>
                {
                    try
                    {
                        point3Ds_Array[index] = await ElevationAsync(httpClient, point2D);
                    }
                    finally
                    {
                        semaphoreSlim.Release();
                    }
                }));
            }

            await Task.WhenAll(tasks);

            List<Point3D> result = [];
            foreach (Point3D? point3D in point3Ds_Array)
            {
                if (point3D != null)
                {
                    result.Add(point3D);
                }
            }

            return result;
        }
    }
}