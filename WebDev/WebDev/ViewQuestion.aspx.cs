using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebDev.Models;
using System.Web.ModelBinding;

namespace WebDev
{
    public partial class ViewQuestion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        
        }

        public Breadcrumb GetBreadcrumbs([QueryString("QuestionID")] int? questionID)
        {

            Breadcrumb b = new Breadcrumb();
            if (questionID.HasValue)
            {
                var _db = new WebDev.Models.ModuleContext();
                Question q = _db.Questions.Find(questionID);
                Module m = _db.Modules.Find(q.ModuleID);
                Subject s = _db.Subjects.Find(m.SubjectID);

                b.ModuleID = m.ModuleID;
                b.SubjectID = s.SubjectID;
                b.SubjectName = s.SubjectName;
            }

            return b;
        }
        public IQueryable<Answer> GetAnswers([QueryString("QuestionID")] int? questionID)
        {
            var _db = new WebDev.Models.ModuleContext();
            IQueryable<Answer> query = _db.Answers;
            if (questionID.HasValue && questionID > 0)
            {
                query = query.Where(a => a.QuestionID == questionID);
                query = query.OrderByDescending(a => a.Created);
                

                return query;
            }
            else
            {
                query = query.Take(0);
                return query;
            }
        }

        public IQueryable<Question> GetQuestions([QueryString("QuestionID")] int? questionID)
        {
            var _db = new WebDev.Models.ModuleContext();
            IQueryable<Question> query = _db.Questions;
            if (questionID.HasValue && questionID > 0)
            {
                query = query.Where(q => q.QuestionID == questionID);

                return query;
            }
            else
            {
                query = query.Take(0);
                return query;
            }

        }
        public void addAnswerForm_addItem([QueryString("QuestionID")] int questionID)
        {
            var item = new Answer();
            item.Created = System.DateTimeOffset.Now;
            item.Solved = false;
            item.QuestionID = questionID;
            item.User = Page.User.Identity.Name;

            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                using (ModuleContext db = new ModuleContext())
                {
                    db.Answers.Add(item);
                    db.SaveChanges();
                }
            }
        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            string questionID = Page.ClientQueryString;
            Response.Redirect("~/ViewQuestion.aspx?" + questionID);
        }

        protected void addStudentForm_ItemAdded(object sender, FormViewInsertedEventArgs e)
        {
            string questionID = Page.ClientQueryString;
            Response.Redirect("~/ViewQuestion.aspx?" + questionID);
        }
    }
}