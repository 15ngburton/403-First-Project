using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication8.Models
{
    public class Question
    {

        [Table("Question")]
        public class Questions
        {

            [Key]
            public int id { get; set; }
            public string questionGiver { get; set; }
            public string questionText { get; set; }
            public DateTime date { get; set; }
            public List<Reply> replyList { get; set; }
        }
    }
}