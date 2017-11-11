using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static WebApplication8.Models.Mission;
using static WebApplication8.Models.Question;
using static WebApplication8.Models.Reply;

namespace WebApplication8.Controllers
{

    public class HomeController : Controller
    {
        static List<Missions> missionList = new List<Missions>();
        static List<Questions> questionList = new List<Questions>();

        public ActionResult Index()
        {
            if (!missionList.Any())
            {
                missionList.Add(item: new Missions() { id = 1, missionName = "Nevada Las Vegas Mission", missionPresidentName = "Gerald Carol", missionAddress = "P.O. Box 278 37th Steet Post Office, Las Vegas, Nevada", missionLanguage = "English", missionClimate = "Hot and Dry", dominantReligion = "Atheist", imgHtmlTag = new  HtmlString("<img src='~/Content/lasVegas.jpg' alt = 'Mission Pic'>") });
                missionList.Add(new Missions() { id = 2, missionName = "Taiwan Taipei Mission", missionPresidentName = "Xhang Cho", missionAddress = "3785 Palace Way, Taipei, Taiwan", missionLanguage = "Mandarin Chinese", missionClimate = "Humid", dominantReligion = "Buddhism", imgHtmlTag = new HtmlString("<img src='~/Content/lasVegas.jpg' alt = 'Mission Pic'>") });
                missionList.Add(new Missions() { id = 3, missionName = "England London Mission", missionPresidentName = "Mark Stevenson", missionAddress = "380 S. Piccadily Way, London, UK 483703", missionLanguage = "English", missionClimate = "Cold", dominantReligion = "Church of England", imgHtmlTag = new HtmlString("<img src='~/Content/lasVegas.jpg' alt = 'Mission Pic'>") });
            }

            if (!questionList.Any())
            {
                questionList.Add(new Questions() { id = 1, questionGiver = "Jared Falke", questionText = "How can I best prepare spiritually to be a missionary?", date = new DateTime(2016, 5, 8, 22, 15, 8) });
                questionList.Add(new Questions() { id = 2, questionGiver = "Scott McFry", questionText = "Do I have to meet physical requirements to serve a mission?", date = new DateTime(2016, 12, 30, 12, 55, 22) });
                questionList.Add(new Questions() { id = 3, questionGiver = "Tyler Green", questionText = "What is a typical day for a missionary like?", date = new DateTime(2017, 8, 20, 15, 2, 17) });
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
            ViewBag.QuestionList = questionList;
            ViewBag.QuestionList.Reverse();
            ViewBag.MissionClass = missionList[menu - 1];
            return View();
        }
    }
}