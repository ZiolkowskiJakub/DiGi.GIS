using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Spatial.Classes;
using System;
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
        /// <para>Points that could not be resolved are left out of the result, so it does not line up with the input. Prefer <see cref="ElevationsAsync(HttpClient, IReadOnlyList{Point2D}, int, int, TimeSpan, CancellationToken)"/> where each answer has to be matched back to the point it was asked for, or where a failing service should be retried rather than reported as points that have no elevation.</para>
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

            List<Point3D?>? point3Ds = await ElevationsAsync(httpClient, [.. point2Ds], maxConcurrentRequests, 0, TimeSpan.Zero).ConfigureAwait(false);
            if (point3Ds is null)
            {
                return null;
            }

            List<Point3D> result = [];
            foreach (Point3D? point3D in point3Ds)
            {
                if (point3D != null)
                {
                    result.Add(point3D);
                }
            }

            return result;
        }

        /// <summary>
        /// Asynchronously retrieves elevation data for a list of 2D points, keeping the answers in step with the points they were asked for.
        /// <para>The result has one entry per input point, at the same position, and holds null wherever the elevation could not be retrieved. A caller can therefore act on the points that failed - count them, report them, come back for them - instead of only seeing that fewer answers arrived than were asked for.</para>
        /// <para>Transient failures are retried through <see cref="ElevationAsync(HttpClient, Point2D, int, TimeSpan, CancellationToken)"/>, with the delay of each request staggered so that a burst rejected all at once does not retry all at once.</para>
        /// <para>Every point is one request, so this holds the whole list in flight against <paramref name="maxConcurrentRequests"/> and does not divide it up. A caller working through a large area should pass it a batch at a time.</para>
        /// </summary>
        /// <param name="httpClient">The HTTP client instance used for sending requests.</param>
        /// <param name="point2Ds">The list of 2D points to query elevation for.</param>
        /// <param name="maxConcurrentRequests">Maximum number of concurrent HTTP requests allowed; values below one are treated as one.</param>
        /// <param name="retryCount">The number of times a transient failure is retried for each point; zero sends each request once.</param>
        /// <param name="retryDelay">The delay before the first retry, doubling for each attempt after that.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A list of 3D points the same length as the input, holding null at the position of every point that could not be resolved, or null if input parameters are null.</returns>
        public static async Task<List<Point3D?>?> ElevationsAsync(this HttpClient? httpClient, IReadOnlyList<Point2D>? point2Ds, int maxConcurrentRequests, int retryCount, TimeSpan retryDelay, CancellationToken cancellationToken = default)
        {
            if (point2Ds == null || httpClient == null)
            {
                return null;
            }

            int count = point2Ds.Count;
            if (count == 0)
            {
                return [];
            }

            int maxConcurrentRequests_Temp = maxConcurrentRequests < 1 ? 1 : maxConcurrentRequests;

            Point3D?[] point3Ds_Array = new Point3D?[count];

            using SemaphoreSlim semaphoreSlim = new(maxConcurrentRequests_Temp);

            Task[] tasks = new Task[count];
            for (int i = 0; i < count; i++)
            {
                tasks[i] = ElevationAsync_Indexed(i);
            }

            await Task.WhenAll(tasks).ConfigureAwait(false);

            return [.. point3Ds_Array];

            // The wait sits inside the worker rather than around the loop that creates them. Were it outside, cancelling
            // would leave workers still running while this method returned and disposed the semaphore underneath them.
            async Task ElevationAsync_Indexed(int index)
            {
                await semaphoreSlim.WaitAsync(cancellationToken).ConfigureAwait(false);

                try
                {
                    // Staggered by position rather than at random: a shared Random is not safe to use from several
                    // threads, and the point of the stagger is only to keep simultaneous retries from staying simultaneous.
                    TimeSpan retryDelay_Staggered = TimeSpan.FromTicks(retryDelay.Ticks + (retryDelay.Ticks * (index % maxConcurrentRequests_Temp) / maxConcurrentRequests_Temp));

                    point3Ds_Array[index] = await ElevationAsync(httpClient, point2Ds[index], retryCount, retryDelay_Staggered, cancellationToken).ConfigureAwait(false);
                }
                finally
                {
                    semaphoreSlim.Release();
                }
            }
        }
    }
}
