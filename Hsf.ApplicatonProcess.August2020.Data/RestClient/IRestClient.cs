using System.Net.Http;
using System.Threading.Tasks;

namespace Hsf.ApplicationProcess.August2020.Data.RestClientBuild
{

    /// <summary>
    ///     Contains generic methods for RESTful communication using JSON format.
    /// </summary>
    public interface IRestClient
    {
        /// <summary>
        ///     Sends a Get request to a specified URL
        /// </summary>
        /// <param name="url">Request URL</param>
        /// <returns>Http response messages</returns>
        Task<HttpResponseMessage> GetAsync(string url);
    }
}
