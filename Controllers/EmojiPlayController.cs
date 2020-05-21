using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmojiCharades.Data;
using EmojiCharades.Models.EmojiPlay;
using Microsoft.AspNetCore.Mvc;

namespace EmojiCharades.Controllers
{
    public class EmojiPlayController : Controller
    {
        /// <summary>
        /// DB context
        /// </summary>
        private DataContext _data;

        /// <summary>
        /// CONSTRUCT
        /// </summary>
        /// <param name="dataContext"></param>
        public EmojiPlayController(DataContext dataContext)
        {
            _data = dataContext;
        }

        /// <summary>
        /// Index
        /// </summary>
        /// <returns></returns>
        public IActionResult Index(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                IndexModel model = new IndexModel()
                {
                    id = id
                };
                return View(model);
            }
            return View(new IndexModel());
        }

        /// <summary>
        /// Test Action
        /// </summary>
        /// <returns></returns>
        public IActionResult test()
        {
            return View();
        }

        /// <summary>
        /// Get a Random Question
        /// </summary>
        /// <returns></returns>
        public JsonResult GetQuestion()
        {
            Random r = new Random();
            int rInt = r.Next(1, _data.Questions.Count());
            var quest = _data.Questions.Where(x=>x.id.Equals(rInt));
            return Json(quest);
        }
    }
}