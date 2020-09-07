using System.Threading.Tasks;
using System.Net.Http;

namespace Hsf.ApplicationProcess.August2020.Data.RestClientBuild
{
    public class RestClient : IRestClient
    {
        private readonly HttpClient _client;

        public RestClient()
        {
            _client = new HttpClient();
        }

        /// <inheritdoc />
        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            return await _client.GetAsync(url);
        }
    }
}
