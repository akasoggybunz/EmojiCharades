using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EmojiCharades.Controllers
{
    public class EmojiPlayController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult test()
        {
            return View();
        }
    }
}