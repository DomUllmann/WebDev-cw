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
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Breadcrumb> Breadcrumbs { get; set; }
        public DbSet<Notes> Notes { get; set; }

    }
}