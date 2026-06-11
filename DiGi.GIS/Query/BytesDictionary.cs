using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace DiGi.GIS
{
    public static partial class Query
    {
        /// <summary>
        /// Asynchronously retrieves a dictionary of byte arrays for specified years based on the provided building's geometry and image parameters.
        /// </summary>
        /// <param name="building2D">The 2D building object used to determine the area of interest.</param>
        /// <param name="years">A collection of years for which to retrieve data.</param>
        /// <param name="offset">The offset value applied to the image capture.</param>
        /// <param name="width">The desired width of the retrieved images.</param>
        /// <param name="squared">Indicates whether the resulting images should be squared.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a dictionary mapping years to their corresponding byte arrays, or null if the building or years collection is null.</returns>
        public static async Task<Dictionary<int, byte[]>?> BytesDictionary(this Building2D? building2D, IEnumerable<int>? years, double offset = 5, double width = 320, bool squared = false)
        {
            if (building2D == null || years == null)
            {
                return null;
            }

            Dictionary<int, string>? ortoDataUrlDictionary = OrtoDataUrlDictionary(building2D, years, offset, width, squared);

            return await BytesDictionary(ortoDataUrlDictionary);
        }

        /// <summary>
        /// Asynchronously retrieves a dictionary of byte arrays for a range of years based on the provided building's geometry and image parameters.
        /// </summary>
        /// <param name="building2D">The 2D building object used to determine the area of interest.</param>
        /// <param name="years">The range of years for which to retrieve data.</param>
        /// <param name="offset">The offset value applied to the image capture.</param>
        /// <param name="width">The desired width of the retrieved images.</param>
        /// <param name="squared">Indicates whether the resulting images should be squared.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a dictionary mapping years to their corresponding byte arrays, or null if the building or range is null.</returns>
        public static async Task<Dictionary<int, byte[]>?> BytesDictionary(this Building2D? building2D, Range<int>? years, double offset = 5, double width = 320, bool squared = false)
        {
            if (building2D == null || years == null)
            {
                return null;
            }

            List<int> years_Temp = [];
            for (int i = years.Min; i <= years.Max; i++)
            {
                years_Temp.Add(i);
            }

            return await BytesDictionary(building2D, years_Temp, offset, width, squared);
        }

        /// <summary>
        /// Asynchronously downloads data from a dictionary of URLs and returns the results as byte arrays.
        /// </summary>
        /// <param name="ortoDataUrlDictionary">A dictionary mapping years to their respective data source URLs.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a dictionary mapping years to the downloaded byte arrays, or null if the input dictionary is null or empty.</returns>
        public static async Task<Dictionary<int, byte[]>?> BytesDictionary(this Dictionary<int, string>? ortoDataUrlDictionary)
        {
            if (ortoDataUrlDictionary == null || ortoDataUrlDictionary.Count == 0)
            {
                return null;
            }

            Func<int, string, Task<(int, byte[])?>> func = new(async (year, url) =>
            {
                using HttpClient httpClient = new();

                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync(url);
                    if (response == null || !response.IsSuccessStatusCode)
                    {
                        return null;
                    }

                    using Stream stream = await response.Content.ReadAsStreamAsync();
                    using MemoryStream memoryStream = new();

                    stream.CopyTo(memoryStream);
                    return (year, memoryStream.ToArray());
                }
                catch
                {
                }

                return null;
            });

            List<Task<(int, byte[])?>> tasks = [];

            foreach (KeyValuePair<int, string> keyValuePair in ortoDataUrlDictionary)
            {
                tasks.Add(func(keyValuePair.Key, keyValuePair.Value));
            }

            (int, byte[])?[] responses = await Task.WhenAll(tasks);

            Dictionary<int, byte[]> result = [];
            for (int i = 0; i < responses.Length; i++)
            {
                (int, byte[])? response = responses[i];

                if (response != null && response.HasValue)
                {
                    result[response.Value.Item1] = response.Value.Item2;
                }
            }

            return result;
        }

        /// <summary>
        /// Asynchronously retrieves a dictionary of byte arrays for specified years within a bounding box at a given scale.
        /// </summary>
        /// <param name="boundingBox2D">The 2D bounding box defining the area of interest.</param>
        /// <param name="years">A collection of years for which to retrieve data.</param>
        /// <param name="scale">The scale factor used for the request.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a dictionary mapping years to their corresponding byte arrays, or null if inputs are invalid or the bounding box area is too small.</returns>
        public static async Task<Dictionary<int, byte[]>?> BytesDictionary(this BoundingBox2D? boundingBox2D, IEnumerable<int>? years, double scale)
        {
            if (years == null)
            {
                return null;
            }

            if (boundingBox2D == null || boundingBox2D.GetArea() < 1)
            {
                return null;
            }

            Dictionary<int, string>? ortoDataUrlDictionary = OrtoDataUrlDictionary(boundingBox2D, years, scale);

            return await BytesDictionary(ortoDataUrlDictionary);
        }

        /// <summary>
        /// Asynchronously retrieves a dictionary of byte arrays for specified years within a bounding box using a provided HttpClient.
        /// </summary>
        /// <param name="httpClient">The HTTP client used to perform the network requests.</param>
        /// <param name="boundingBox2D">The 2D bounding box defining the area of interest.</param>
        /// <param name="years">A collection of years for which to retrieve data.</param>
        /// <param name="scale">The scale factor used for the request.</param>
        /// <param name="initialRequestCount">The maximum number of concurrent network requests allowed.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a dictionary mapping years to their corresponding byte arrays, or null if inputs are invalid.</returns>
        public static async Task<Dictionary<int, byte[]>?> BytesDictionary(this HttpClient httpClient, BoundingBox2D? boundingBox2D, IEnumerable<int>? years, double scale, int initialRequestCount = 8)
        {
            if (years == null || httpClient is null)
            {
                return null;
            }

            if (boundingBox2D == null || boundingBox2D.GetArea() < 1)
            {
                return null;
            }

            Dictionary<int, string>? ortoDataUrlDictionary = OrtoDataUrlDictionary(boundingBox2D, years, scale);

            return await BytesDictionary(httpClient, ortoDataUrlDictionary, initialRequestCount);
        }

        /// <summary>
        /// Asynchronously downloads data from a dictionary of URLs using a provided HttpClient and a concurrency limit.
        /// </summary>
        /// <param name="httpClient">The HTTP client used to perform the network requests.</param>
        /// <param name="ortoDataUrlDictionary">A dictionary mapping years to their respective data source URLs.</param>
        /// <param name="initialRequestCount">The maximum number of concurrent network requests allowed.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a dictionary mapping years to the downloaded byte arrays, or null if inputs are invalid.</returns>
        public static async Task<Dictionary<int, byte[]>?> BytesDictionary(this HttpClient httpClient, Dictionary<int, string>? ortoDataUrlDictionary, int initialRequestCount = 8)
        {
            if (ortoDataUrlDictionary == null || ortoDataUrlDictionary.Count == 0 || httpClient == null)
            {
                return null;
            }

            // Semaphore limits the number of concurrent network requests
            using SemaphoreSlim semaphoreSlim = new(initialRequestCount);

            List<Task<KeyValuePair<int, byte[]>?>> tasks = [.. ortoDataUrlDictionary.Select(async (KeyValuePair<int, string> entry) =>
                {
                    await semaphoreSlim.WaitAsync();
                    try
                    {
                        // Use GetByteArrayAsync for better performance in netstandard 2.0
                        byte[] bytes = await httpClient.GetByteArrayAsync(entry.Value).ConfigureAwait(false);
                        return (KeyValuePair<int, byte[]>?)new KeyValuePair<int, byte[]>(entry.Key, bytes);
                    }
                    catch (Exception)
                    {
                        // Log exception if needed
                        return null;
                    }
                    finally
                    {
                        semaphoreSlim.Release();
                    }
                })];

            KeyValuePair<int, byte[]>?[] results = await Task.WhenAll(tasks).ConfigureAwait(false);

            Dictionary<int, byte[]> finalDictionary = [];
            foreach (KeyValuePair<int, byte[]>? result in results)
            {
                if (result.HasValue)
                {
                    finalDictionary[result.Value.Key] = result.Value.Value;
                }
            }

            return finalDictionary;
        }
    }
}