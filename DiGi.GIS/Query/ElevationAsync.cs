using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Spatial.Classes;
using System;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace DiGi.GIS
{
    public static partial class Query
    {
        /// <summary>
        /// Asynchronously fetches the elevation for a 2D point using an HTTP client.
        /// <para>The public GUGiK elevation service answers <c>0</c> (or <c>-0</c>) with HTTP 200 for coordinates outside its terrain model coverage (e.g. over the sea or across national borders) or over water bodies. This is treated as a no-data sentinel and resolved to null rather than a valid sea-level measurement.</para>
        /// </summary>
        /// <param name="httpClient">The HTTP client used to send the request.</param>
        /// <param name="point2D">The 2D point for which to retrieve the elevation.</param>
        /// <returns>A 3D point containing the original 2D coordinates and the fetched elevation, or null if the query fails, parameters are null, or the service answers with the zero no-data sentinel.</returns>
        public static async Task<Point3D?> ElevationAsync(this HttpClient? httpClient, Point2D? point2D)
        {
            if (point2D == null || httpClient is null)
            {
                return null;
            }

            string? url = Url_Elevation(point2D);
            if (string.IsNullOrWhiteSpace(url))
            {
                return null;
            }

            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseContent = await response.Content.ReadAsStringAsync();

                // The API returns a simple string representing the number (e.g., "115.4")
                if (double.TryParse(responseContent, NumberStyles.Any, CultureInfo.InvariantCulture, out double elevation))
                {
                    if (elevation == 0)
                    {
                        return null;
                    }

                    return new Point3D(point2D.X, point2D.Y, elevation);
                }

                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Asynchronously fetches the elevation for a 2D point, retrying conditions that are worth retrying.
        /// <para>Unlike <see cref="ElevationAsync(HttpClient, Point2D)"/>, which gives up on the first failure of any kind, this tells a transient condition apart from a genuine one through <see cref="IsTransient(HttpStatusCode)"/> and sends the request again. That matters when many points are fetched at once: a service answering 429 to a burst would otherwise be recorded as a run of points that have no elevation, and nothing would go back for them.</para>
        /// <para>The public GUGiK elevation service answers <c>0</c> (or <c>-0</c>) with HTTP 200 for coordinates outside its terrain model coverage or over water bodies. This is treated as a no-data sentinel and resolved to null rather than a valid measurement.</para>
        /// <para>The delay doubles after each attempt, and a <c>Retry-After</c> the server sends takes the place of the delay for the attempt that follows it. An answer carrying content that is not a number is a considered answer and is not retried; an empty one is not an answer at all and is.</para>
        /// <para>This path treats <see cref="HttpStatusCode.InternalServerError"/> as worth retrying, which the shared <see cref="IsTransient(HttpStatusCode)"/> policy deliberately does not. A public elevation service asked for hundreds of thousands of single points answers 500 to load and answers correctly moments later, and points really were lost to giving up on it.</para>
        /// </summary>
        /// <param name="httpClient">The HTTP client used to send the request.</param>
        /// <param name="point2D">The 2D point for which to retrieve the elevation.</param>
        /// <param name="retryCount">The number of times a transient failure is retried; zero sends the request once.</param>
        /// <param name="retryDelay">The delay before the first retry, doubling for each attempt after that.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A 3D point containing the original 2D coordinates and the fetched elevation, or null if the query fails, parameters are null, or the service answers with the zero no-data sentinel.</returns>
        public static async Task<Point3D?> ElevationAsync(this HttpClient? httpClient, Point2D? point2D, int retryCount, TimeSpan retryDelay, CancellationToken cancellationToken = default)
        {
            if (point2D == null || httpClient is null)
            {
                return null;
            }

            string? url = Url_Elevation(point2D);
            if (string.IsNullOrWhiteSpace(url))
            {
                return null;
            }

            TimeSpan delay = retryDelay < TimeSpan.Zero ? TimeSpan.Zero : retryDelay;

            for (int attempt = 0; ; attempt++)
            {
                cancellationToken.ThrowIfCancellationRequested();

                try
                {
                    using (HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url, cancellationToken).ConfigureAwait(false))
                    {
                        if (httpResponseMessage.IsSuccessStatusCode)
                        {
                            // ReadAsStringAsync takes no cancellation token on netstandard2.0.
                            string responseContent = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);

                            // The API returns a simple string representing the number (e.g., "115.4")
                            if (double.TryParse(responseContent, NumberStyles.Any, CultureInfo.InvariantCulture, out double elevation))
                            {
                                if (elevation == 0)
                                {
                                    return null;
                                }

                                return new Point3D(point2D.X, point2D.Y, elevation);
                            }

                            // An answer with something in it that cannot be read is not going to read differently
                            // next time. An empty one is not an answer at all - a body cut short, or a success with
                            // nothing behind it - and asking again is exactly what recovers it.
                            if (!string.IsNullOrWhiteSpace(responseContent) || attempt >= retryCount)
                            {
                                return null;
                            }
                        }
                        else
                        {
                            if (attempt >= retryCount || !(httpResponseMessage.StatusCode.IsTransient() || httpResponseMessage.StatusCode == HttpStatusCode.InternalServerError))
                            {
                                return null;
                            }

                            if (httpResponseMessage.Headers.RetryAfter?.Delta is TimeSpan delta && delta > TimeSpan.Zero)
                            {
                                delay = delta;
                            }
                        }
                    }
                }
                catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
                {
                    // The caller asked to stop. Every other OperationCanceledException reaching here is the client's own
                    // timeout, which arrives as a TaskCanceledException with the token unsignalled and is worth retrying.
                    throw;
                }
                catch (Exception)
                {
                    if (attempt >= retryCount)
                    {
                        return null;
                    }
                }

                await Task.Delay(delay, cancellationToken).ConfigureAwait(false);

                if (delay <= TimeSpan.FromTicks(TimeSpan.MaxValue.Ticks / 2))
                {
                    delay = TimeSpan.FromTicks(delay.Ticks * 2);
                }
            }
        }
    }
}