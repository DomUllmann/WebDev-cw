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
    }
}