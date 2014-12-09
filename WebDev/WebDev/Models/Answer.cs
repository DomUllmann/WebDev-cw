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

        [Required, StringLength(10000), Display(Name="Answer"), DataType(DataType.MultilineText)]
        public string AnswerBody { get; set; }

        [ScaffoldColumn(false),Required, StringLength(128)]
        public string User { get; set; }

        [ScaffoldColumn(false), Required]
        public DateTimeOffset Created { get; set; }

        [ScaffoldColumn(false), Required]
        public bool Solved { get; set; }

        [ScaffoldColumn(false), Required]
        public int QuestionID { get; set; }
    }
}