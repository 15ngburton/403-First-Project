using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication8.Models
{
    public class Question
    {
        public int id { get; set; }
        public string questionText { get; set; }
        public List<string> replyText { get; set; }
    }
}