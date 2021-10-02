using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace TalkApi.cClient.Ui.Models
{
    public class ChatService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ChatService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IList<ChatResponse>> GetAllAsync()
        {
            var httpClient = _httpClientFactory.CreateClient("TalkApi");
            var route = "/api/chat-messages";
            var result = await httpClient.GetAsync(route);
            result.EnsureSuccessStatusCode();
            return await result.Content.ReadAsAsync<IList<ChatResponse>>();
        }

        public async Task<ChatResponse> CreateAsync(ChatResponse request)
        {
            var httpClient = _httpClientFactory.CreateClient("TalkApi");
            var route = "/api/chat-messages";
            var result = await httpClient.PostAsJsonAsync(route, request);
            result.EnsureSuccessStatusCode();
            return await result.Content.ReadAsAsync<ChatResponse>();
        }
    }
}