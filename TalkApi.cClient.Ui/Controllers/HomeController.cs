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
        private readonly ChatChannelApi _chatChannelApi;

        public HomeController(ChatChannelApi chatChannelApi)
        {
            _chatChannelApi = chatChannelApi;
        }


        public async Task<IActionResult> Index()
        {
            var channels = await _chatChannelApi.GetAllAsync();


            return View(channels);
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
