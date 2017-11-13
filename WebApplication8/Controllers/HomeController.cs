using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static WebApplication8.Models.Mission;
using static WebApplication8.Models.Question;
using static WebApplication8.Models.Reply;
using static WebApplication8.Models.QuestionReply;

namespace WebApplication8.Controllers
{

    public class HomeController : Controller
    {
        //Define Lists for all model objects
        static List<Missions> missionList = new List<Missions>();
        static Stack<Questions> questionStack = new Stack<Questions>();
        static List<Replies> replyList = new List<Replies>();
        static List<QuestionReplies> questionReplyList = new List<QuestionReplies>();

        static int menuSelection;

        //Loads data structures
        public void loadMissionInfo()
        {
            //Load Mission Info if the missionList is empty
            if (!missionList.Any())
            {
                missionList.Add(item: new Missions() { id = 1, missionName = "Nevada Las Vegas Mission", missionPresidentName = "Gerald Carol", missionAddress = "P.O. Box 278 37th Steet Post Office, Las Vegas, Nevada", missionLanguage = "English", missionClimate = "Hot and Dry", dominantReligion = "Atheist", imgFileName = "battleborn.png" });
                missionList.Add(new Missions() { id = 2, missionName = "Taiwan Taipei Mission", missionPresidentName = "Xhang Cho", missionAddress = "3785 Palace Way, Taipei, Taiwan", missionLanguage = "Mandarin Chinese", missionClimate = "Humid", dominantReligion = "Buddhism", imgFileName = "taiwan.png" });
                missionList.Add(new Missions() { id = 3, missionName = "England London Mission", missionPresidentName = "Mark Stevenson", missionAddress = "380 S. Piccadily Way, London, UK 483703", missionLanguage = "English", missionClimate = "Cold", dominantReligion = "Church of England", imgFileName = "england.png" });
            }

            //Load Questions Info if the questionStack is empty
            if (!questionStack.Any())
            {
                replyList.Add(new Replies() { replyGiver = "Harold Carr", replyID = 1, replyText = "Read your scriptures and pray" });
                replyList.Add(new Replies() { replyGiver = "Carol Harper", replyID = 2, replyText = "Yes" });
                replyList.Add(new Replies() { replyGiver = "Karen Scharff", replyID = 3, replyText = "Look at the white handbook." });
                questionReplyList.Add(new QuestionReplies { replyID = 1, questionID = 1 });
                questionReplyList.Add(new QuestionReplies { replyID = 2, questionID = 2 });
                questionReplyList.Add(new QuestionReplies { replyID = 3, questionID = 3 });
                questionStack.Push(new Questions() { questionID = 1, questionGiver = "Jared Falke", questionText = "How can I best prepare spiritually to be a missionary?", date = new DateTime(2016, 5, 8, 22, 15, 8), replyID = 1 });
                questionStack.Push(new Questions() { questionID = 2, questionGiver = "Scott McFry", questionText = "Do I have to meet physical requirements to serve a mission?", date = new DateTime(2016, 12, 30, 12, 55, 22), replyID = 2 });
                questionStack.Push(new Questions() { questionID = 3, questionGiver = "Tyler Green", questionText = "What is a typical day for a missionary like?", date = new DateTime(2017, 8, 20, 15, 2, 17), replyID = 3 });

            }

        }

        //Home page
        public ActionResult Index()
        {  
            return View();
        }

        //About page
        public ActionResult About()
        {
            return View();
        }

        //Contact page
        public ActionResult Contact()
        {
            List<String> menuItems = new List<String>();
            return View();
        }

        //Mission page
        public ActionResult Mission()
        {
            loadMissionInfo();
            return View();
        }

        //Mission Details Page
        [HttpGet]
        public ActionResult MissionDetails(int menu)
        {
            loadMissionInfo();
            //Load data structures into viewbag
            ViewBag.QuestionList = questionStack;
            ViewBag.MissionClass = missionList[menu - 1];
            ViewBag.ReplyList = replyList;
            ViewBag.QuestionReplyList = questionReplyList;
            menuSelection = menu;
            return View();
        }

        [HttpPost]
        public ActionResult MissionDetails(string submit)
        {
            //What happens when the user tries to post a question.
            if (submit == "Post")
            {
                string qText = Request["questionText"];
                string qName = Request["questionName"];
                questionStack.Push(new Questions() { questionGiver = qName, questionText = qText, date = DateTime.Now });
            }
            //What happens when the user tries to post a reply.
            else if (submit == "Reply")
            {
                /*string rText = Request["replyBox"];
                string rName = Request["replyName"];
                replyList.Add(new Replies { questionID = ViewBag.QuestionNumber, replyGiver = rName, replyText = rText });
            */
            }
            //Load the ViewBag with DataStructures
            ViewBag.ReplyList = replyList;
            ViewBag.QuestionReplyList = questionReplyList;
            ViewBag.QuestionList = questionStack;
            ViewBag.MissionClass = missionList[menuSelection - 1];

            return View();
        }
    }
}