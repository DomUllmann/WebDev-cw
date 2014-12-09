using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebDev.Models
{
    public class Notes
    {

        [ScaffoldColumn(false)]
        public int NotesID { get; set; }

        [Required, StringLength(250)]
        public string NotesTitle { get; set; }

        [Required, StringLength(10000)]
        public string NotesBody { get; set; }

        [Required, StringLength(128)]
        public string User { get; set; }

        [Required]
        public DateTimeOffset Created { get; set; }

        [Required, StringLength(128)]
        public string UserModified { get; set; }

        [Required]
        public DateTimeOffset Modified { get; set; }



        [Required, StringLength(8)]
        public string ModuleID { get; set; }
    
    }


}