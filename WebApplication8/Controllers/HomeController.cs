using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static WebApplication8.Models.Mission;

namespace WebApplication8.Controllers
{
    
    public class HomeController : Controller
    {
        static List<Missions> missionList = new List<Missions>();
        public ActionResult Index()
        {
            missionList.Add(new Missions() { id = 1, missionName = "England London Mission", missionPresidentName = "Mark Stevenson", missionAddress = "380 S. Piccadily Way, London, UK 483703", missionLanguage = "English", missionClimate = "Cold", dominantReligion = "Church of England", imgFileName = "" });

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}