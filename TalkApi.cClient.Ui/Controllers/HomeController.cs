using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TalkApi.cClient.Ui.Models;

namespace TalkApi.cClient.Ui.Controllers
{
    public class HomeController : Controller
    {
        private readonly ChannelService _channelService;
        private readonly ChatService _chatService;

        public HomeController(ChannelService channelService, ChatService chatService)
        {
            _channelService = channelService;
            _chatService = chatService;
        }


        public async Task<IActionResult> Index()
        {
            var channels = await _channelService.GetAllAsync();


            return View(channels);
        }

        public async Task<IActionResult> Channels()
        {
            var channels = await _channelService.GetAllAsync();


            return View(channels);
        }

        public async Task<IActionResult> Messages()
        {
            var messages = await _chatService.GetAllAsync();


            return View(messages);
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



    }
}
