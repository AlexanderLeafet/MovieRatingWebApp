using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRating.Models;
using Newtonsoft.Json;

namespace MovieRating.Controllers
{
    public class HomeController : Controller
    {
        

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HistoryIndex()
        {
            return View();
        }

        public ActionResult GetMovieList()
        {
            var json = System.IO.File.ReadAllText(Server.MapPath(@"~/Content/JsonData.json"));
            List<MovieInfo> movieInfoList = JsonConvert.DeserializeObject<List<MovieInfo>>(json);
            
            return Json(movieInfoList, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetMovieList2019()
        {
            var json = System.IO.File.ReadAllText(Server.MapPath(@"~/Content/JsonData2019.json"));
            List<MovieInfo> movieInfoList = JsonConvert.DeserializeObject<List<MovieInfo>>(json);

            return Json(movieInfoList, JsonRequestBehavior.AllowGet);
        }

    }
}