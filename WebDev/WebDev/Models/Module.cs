using System.ComponentModel.DataAnnotations;

namespace WebDev.Models
{
    public class Module
    {
        [StringLength(8), Display(Name = "Module")]
        public string ModuleID { get; set; }

        [Required, StringLength(100), Display(Name = "Title")]
        public string ModuleTitle { get; set; }

        [Required, StringLength(1000), Display(Name = "Module Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public int? SubjectID { get; set; }

        public virtual Subject Subject { get; set; }
    }
}