using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebDev.Models
{
    public class Subject
    {
        [ScaffoldColumn(false)]
        public int SubjectID { get; set; }

        [Required, StringLength(100), Display(Name = "Subject Area")]
        public string SubjectName { get; set; }

        public virtual ICollection<Module> Modules { get; set; }
    }
}