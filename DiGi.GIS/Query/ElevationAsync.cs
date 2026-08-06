using DiGi.Geometry.Planar.Classes;
using DiGi.Geometry.Spatial.Classes;
using System;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;

namespace DiGi.GIS
{
    public static partial class Query
    {
        /// <summary>
        /// Asynchronously fetches the elevation for a 2D point using an HTTP client.
        /// </summary>
        /// <param name="httpClient">The HTTP client used to send the request.</param>
        /// <param name="point2D">The 2D point for which to retrieve the elevation.</param>
        /// <returns>A 3D point containing the original 2D coordinates and the fetched elevation, or null if the query fails or parameters are null.</returns>
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
                    return new Point3D(point2D.X, point2D.Y, elevation);
                }

                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}