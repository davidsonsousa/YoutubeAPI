using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using YoutubeApi.Models;

namespace YoutubeApi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Single video";
            return View("Index", "single.js");
        }

        public ActionResult PlayerStatus()
        {
            ViewBag.Title = "Player status";
            return View("Index", "player-status.js");
        }

        public ActionResult CustomVideo()
        {
            ViewBag.Title = "Single custom video";

            return View(FakeDb.Videos.First());
        }

        public ActionResult VideoGallery()
        {
            ViewBag.Title = "VideoGallery";

            return View(FakeDb.Videos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
