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
        private readonly HttpClient Http;

        public RabbitMqApi(string rabbitMqUrl, string username, string password)
        {
            var basicAuthHeader = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));
            Http = new HttpClient { Timeout = TimeSpan.FromMinutes(2) };
            Http.BaseAddress = new Uri(rabbitMqUrl);
            Http.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Basic", basicAuthHeader);
        }

        public RabbitMqApi(HttpClient httpClient)
        {
            if (httpClient == null)
            {
                throw new ArgumentNullException(nameof(httpClient));
            }

            Http = httpClient;
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
                response = await Http.GetAsync(path);
            }
            else if (method == HttpMethod.Post)
            {
                string messageBodyContent = JsonConvert.SerializeObject(body);
                response = await Http.PostAsync(path, new StringContent(messageBodyContent));
            }
            else if (method == HttpMethod.Put)
            {
                string messageBodyContent = JsonConvert.SerializeObject(body);
                response = await Http.PutAsync(path, new StringContent(messageBodyContent));
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
            HttpResponseMessage response = await Http.DeleteAsync(path);

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