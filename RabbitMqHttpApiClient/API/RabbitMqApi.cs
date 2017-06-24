using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RabbitMqHttpApiClient.API
{
    public partial class RabbitMqApi
    {
        private readonly HttpClient _http;

        public RabbitMqApi(string rabbitMqUrl, string username, string password)
        {
            var basicAuthHeader = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));
            _http = new HttpClient { Timeout = TimeSpan.FromMinutes(2) };
            _http.BaseAddress = new Uri(rabbitMqUrl);
            _http.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Basic", basicAuthHeader);
        }

        public RabbitMqApi(HttpClient httpClient)
        {
            if (httpClient == null)
            {
                throw new ArgumentNullException(nameof(httpClient));
            }

            _http = httpClient;
        }

        private async Task<T> DoGetCall<T>(string path)
        {
            return await DoCall<T>(path, HttpMethod.Get);
        }

        private async Task<T> DoCall<T>(string path, HttpMethod method, dynamic body = null)
        {
            HttpResponseMessage response;
            if (method == HttpMethod.Get)
            {
                response = await _http.GetAsync(path);
            }
            else if (method == HttpMethod.Post)
            {
                string messageBodyContent = JsonConvert.SerializeObject(body);
                response = await _http.PostAsync(path, new StringContent(messageBodyContent));
            }
            else if (method == HttpMethod.Put)
            {
                string messageBodyContent = JsonConvert.SerializeObject(body);
                response = await _http.PutAsync(path, new StringContent(messageBodyContent));
            }
            else
            {
                throw new Exception("method not implemented");
            }

            string result = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<T>(result);
            }
            else
            {
                throw new HttpRequestException(result);
            }
        }

        private async Task<bool> DoDeleteCall(string path)
        {
            HttpResponseMessage response = await _http.DeleteAsync(path);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                string result = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException(result);
            }
        }
    }
}