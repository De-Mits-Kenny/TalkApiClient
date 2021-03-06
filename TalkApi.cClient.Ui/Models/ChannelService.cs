using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace TalkApi.cClient.Ui.Models
{
    public class ChannelService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ChannelService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IList<ChannelResponse>> GetAllAsync()
        {
            var httpClient = _httpClientFactory.CreateClient("TalkApi");
            var route = "/api/chat-channels";
            var result = await httpClient.GetAsync(route);
            result.EnsureSuccessStatusCode();
            return await result.Content.ReadAsAsync<IList<ChannelResponse>>();
        }

        public async Task<ChannelResponse> CreateAsync(ChannelResponse request)
        {
            var httpClient = _httpClientFactory.CreateClient("TalkApi");
            var route = "/api/chat-channels";
            var result = await httpClient.PostAsJsonAsync(route, request);
            result.EnsureSuccessStatusCode();
            return await result.Content.ReadAsAsync<ChannelResponse>();
        }
    }
}