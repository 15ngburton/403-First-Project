<<<<<<< HEAD
﻿using System;
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
            missionList.Add(new Missions() { id = 2, missionName = "Burchev Albania Mission", missionPresidentName = "Gerald Carol", missionAddress = "P.O. Box 278 37th Steet Post Office, Albania", missionLanguage = "Albanian", missionClimate = "Temparate", dominantReligion = "Christian Orthodox", imgFileName = "" });
            missionList.Add(new Missions() { id = 3, missionName = "Brasilia Brasil Mission", missionPresidentName = "Guiermo Fracucci", missionAddress = "3785 Palace Way, Brasilia, Brazil", missionLanguage = "Portuguese", missionClimate = "Rainy", dominantReligion = "Catholic", imgFileName = "" });
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
=======
﻿using System;
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
>>>>>>> 4ed55e3a9fe6dc2d1e6ac82b8f50aa9b93d5ff2c
}