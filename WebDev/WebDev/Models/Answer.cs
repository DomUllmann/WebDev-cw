using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebDev.Models
{
    public class Answer
    {
        [ScaffoldColumn(false)]
        public int AnswerID { get; set; }

        [Required, StringLength(4000)]
        public string AnswerBody { get; set; }

        [Required, StringLength(128)]
        public string User { get; set; }

        [Required]
        public DateTimeOffset Created { get; set; }

        [Required]
        public bool Solved { get; set; }

        [Required]
        public int QuestionID { get; set; }
    }
}