using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication8.Models
{
    public class QuestionReply
    {
        [Table("QuestionReply")]
        public class QuestionReplies
        {
            public int questionID { get; set; }
            public int replyID { get; set; }
        }
    }
}