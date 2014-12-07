using System.Data.Entity;

namespace WebDev.Models
{
    public class ModuleContext : DbContext
    {
        public ModuleContext() : base("WebDev")
        {
        }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Module> Modules { get; set; }
    }
}