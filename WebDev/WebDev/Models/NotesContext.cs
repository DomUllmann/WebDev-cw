using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebDev.Models
{
    public class NotesContext : DbContext
    {
        public NotesContext()
            : base("WebDev")
        {
        }
        public DbSet<Notes> Notes { get; set; }
        
    }
}