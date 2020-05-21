using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EmojiCharades.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EmojiCharades.Models;

namespace EmojiCharades.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DataContext _dataContext;
        public HomeController(ILogger<HomeController> logger,
            DataContext data)
        {
            _dataContext = data;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var questions = _dataContext.Questions.ToList();
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
