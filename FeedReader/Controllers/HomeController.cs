using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tweetinvi.Models;


namespace FeedReader.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCuttentTime()
        {
            return Content(DateTime.Now.ToLongTimeString());
        }
    }
}