using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebDev.Models
{
    public class Question
    {
        [ScaffoldColumn(false)]
        public int QuestionID { get; set; }

        [Required, StringLength(250)]
        public string QuestionTitle { get; set; }

        [Required, StringLength(4000)]
        public string QuestionBody { get; set; }

        [Required, StringLength(128)]
        public string User { get; set; }

        [Required]
        public DateTimeOffset Created { get; set; }

        [Required]
        public bool Solved { get; set; }

        [Required, StringLength(8)]
        public string ModuleID { get; set; }

    }
}