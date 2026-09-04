using System.Net;

namespace DiGi.GIS
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether a response status represents a transient condition that is worth retrying.
        /// <para>Transient means the request may well succeed if sent again unchanged: the gateway lost its upstream (502), the service is unavailable or restarting (503), the gateway timed out waiting (504), the server asked the client to retry (408, 429).</para>
        /// <para>Everything else is treated as a genuine fault and fails on the first attempt. In particular <see cref="HttpStatusCode.InternalServerError"/> is NOT transient - retrying only repeats whatever the server already failed at.</para>
        /// <para>This deliberately duplicates <c>DiGi.WebAPI.Query.IsTransient</c> rather than calling it. That assembly targets a current .NET and this one targets netstandard2.0, so it cannot be referenced from here. Keep the two in step if either is extended.</para>
        /// </summary>
        /// <param name="httpStatusCode">The status returned by the server.</param>
        /// <returns>True if the request should be retried; otherwise, false.</returns>
        public static bool IsTransient(this HttpStatusCode httpStatusCode)
        {
            switch (httpStatusCode)
            {
                case HttpStatusCode.BadGateway:
                case HttpStatusCode.ServiceUnavailable:
                case HttpStatusCode.GatewayTimeout:
                case HttpStatusCode.RequestTimeout:
                case (HttpStatusCode)429: // TooManyRequests - not defined in netstandard2.0
                    return true;

                default:
                    return false;
            }
        }
    }
}