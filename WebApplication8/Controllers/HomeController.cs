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
            if (!missionList.Any())
            {
                missionList.Add(new Missions() { id = 1, missionName = "Nevada Las Vegas Mission", missionPresidentName = "Gerald Carol", missionAddress = "P.O. Box 278 37th Steet Post Office, Las Vegas, Nevada", missionLanguage = "English", missionClimate = "Hot and Dry", dominantReligion = "Atheist" });
                missionList.Add(new Missions() { id = 2, missionName = "Taiwan Taipei Mission", missionPresidentName = "Xhang Cho", missionAddress = "3785 Palace Way, Taipei, Taiwan", missionLanguage = "Mandarin Chinese", missionClimate = "Humid", dominantReligion = "Buddhism"});
                missionList.Add(new Missions() { id = 3, missionName = "England London Mission", missionPresidentName = "Mark Stevenson", missionAddress = "380 S. Piccadily Way, London, UK 483703", missionLanguage = "English", missionClimate = "Cold", dominantReligion = "Church of England" });
            }

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

        public ActionResult Mission()
        {
            return View();
        }

        public ActionResult MissionDetails(int menu)
        {
            ViewBag.MissionClass = missionList[menu - 1];
            return View();
        }
    }
}