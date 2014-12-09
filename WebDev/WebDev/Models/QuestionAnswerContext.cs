using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace WebDev.Models
{
    public class QuestionAnswerContext : DbContext
    {
        public QuestionAnswerContext() : base("WebDev")
        {
        }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
    }
}