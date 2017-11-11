using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication8.Models
{
    public class Reply
    {

        [Table("Reply")]
        public class Replies
        {

            [Key]
            public int replyID { get; set; }
            public string replyGiver { get; set; }
            public string replyText { get; set; }
            public DateTime date { get; set; }
            public int questionID { get; set; }
        }
    }
}