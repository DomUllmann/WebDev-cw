using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace WebDev.Models
{
    public class Breadcrumb
    {
        public int ID { get; set; }

        public int QuestionID { get; set; }

        public string ModuleID { get; set; }

        public int SubjectID { get; set; }

        public string SubjectName { get; set; }

        public int NoteID { get; set; }

    }

}