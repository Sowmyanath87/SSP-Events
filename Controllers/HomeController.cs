using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSP_Events.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "𝗦𝗧𝗢𝗥𝗜𝗘𝗦 𝗕𝗬 𝗦𝗥𝗜𝗡𝗜𝗩𝗔𝗦 𝗣𝗨𝗧𝗧𝗔";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "SSP contact Details";

            return View();
        }

        public ActionResult InstaReels()
        {
            ViewBag.Message = "Insta Reels";

            return View();
        }
    }
}