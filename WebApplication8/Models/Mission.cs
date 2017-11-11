using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication8.Models
{
    public class Mission
    {

        [Table("Mission")]
        public class Missions
        {
            
            [Key]
            public int id { get; set; }
            public string missionName { get; set; }
            public string missionPresidentName { get; set; }
            public string missionAddress { get; set; }
            public string missionLanguage { get; set; }
            public string missionClimate { get; set; }
            public string dominantReligion { get; set; }
            public HtmlString imgHtmlTag { get; set; }
        }
    }
}