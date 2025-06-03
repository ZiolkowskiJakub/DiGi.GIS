using DiGi.Core.Classes;
using DiGi.Geometry.Planar.Classes;
using DiGi.GIS.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace DiGi.GIS
{
    public static partial class Query
    {

        public static async Task<Dictionary<int, byte[]>> BytesDictionary(this Building2D building2D, IEnumerable<int> years, double offset = 5, double width = 320, bool squared = false)
        {
            if (building2D == null || years == null)
            {
                return null;
            }
            Dictionary<int, string> ortoDataUrlDictionary = OrtoDataUrlDictionary(building2D, years, offset, width, squared);

            return await BytesDictionary(ortoDataUrlDictionary);
        }

        public static async Task<Dictionary<int, byte[]>> BytesDictionary(this Building2D building2D, Range<int> years, double offset = 5, double width = 320, bool squared = false)
        {
            if (building2D == null || years == null)
            {
                return null;
            }

            List<int> years_Temp = new List<int>();
            for (int i = years.Min; i <= years.Max; i++)
            {
                years_Temp.Add(i);
            }

            return await BytesDictionary(building2D, years_Temp, offset, width, squared);
        }

        public static async Task<Dictionary<int, byte[]>> BytesDictionary(this Dictionary<int, string> ortoDataUrlDictionary)
        {
            if(ortoDataUrlDictionary == null || ortoDataUrlDictionary.Count == 0)
            {
                return null;
            }

            Func<int, string, Task<(int, byte[])?>> func = new Func<int, string, Task<(int, byte[])?>>(async (year, url) =>
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await httpClient.GetAsync(url);
                        if (response == null || !response.IsSuccessStatusCode)
                        {
                            return null;
                        }

                        using (Stream stream = await response.Content.ReadAsStreamAsync())
                        {
                            using (MemoryStream memoryStream = new MemoryStream())
                            {
                                stream.CopyTo(memoryStream);
                                return (year, memoryStream.ToArray());
                            }
                        }
                    }
                    catch (Exception exception)
                    {
                    }
                }

                return null;
            });

            List<Task<(int, byte[])?>> tasks = new List<Task<(int, byte[])?>>();

            foreach (KeyValuePair<int, string> keyValuePair in ortoDataUrlDictionary)
            {
                tasks.Add(func(keyValuePair.Key, keyValuePair.Value));
            }

            (int, byte[])?[] responses = await Task.WhenAll(tasks);

            Dictionary<int, byte[]> result = new Dictionary<int, byte[]>();
            for (int i = 0; i < responses.Length; i++)
            {
                (int, byte[])? response = responses[i];

                if (response != null && response.HasValue)
                {
                    result[responses[i].Value.Item1] = responses[i].Value.Item2;
                }
            }

            return result;
        }

        public static async Task<Dictionary<int, byte[]>> BytesDictionary(this BoundingBox2D boundingBox2D, IEnumerable<int> years, double scale)
        {
            if (years == null)
            {
                return null;
            }

            if (boundingBox2D == null || boundingBox2D.GetArea() < 1)
            {
                return null;
            }

            Dictionary<int, string> ortoDataUrlDictionary = OrtoDataUrlDictionary(boundingBox2D, years, scale);

            return await BytesDictionary(ortoDataUrlDictionary);
        }
    }
}

