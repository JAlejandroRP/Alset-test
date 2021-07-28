using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ScaffoldIdentity.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ScaffoldIdentity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Shows the charts used
        /// </summary>
        /// <returns></returns>
        public IActionResult Charts()
        {
            return View();
        }

        /// <summary>
        /// Shows the used buttons used
        /// </summary>
        /// <returns></returns>
        public IActionResult Buttons()
        {
            return View();
        }

        /// <summary>
        /// Shows the cards used
        /// </summary>
        /// <returns></returns>
        public IActionResult Cards()
        {
            return View();
        }

        /// <summary>
        /// Shows the colors used
        /// </summary>
        /// <returns></returns>
        public IActionResult Colors()
        {
            return View();
        }

        /// <summary>
        /// Shows the borders used
        /// </summary>
        /// <returns></returns>
        public IActionResult Borders()
        {
            return View();
        }

        /// <summary>
        /// Shows animations used
        /// </summary>
        /// <returns></returns>
        public IActionResult Animations()
        {
            return View();
        }

        /// <summary>
        /// Shows other utilities
        /// </summary>
        /// <returns></returns>
        public IActionResult Other()
        {
            return View();
        }

        /// <summary>
        /// Shows the tables used
        /// </summary>
        /// <returns></returns>
        public IActionResult Tables()
        {
            return View();
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
