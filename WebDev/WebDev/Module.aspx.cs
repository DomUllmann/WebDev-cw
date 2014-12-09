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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public Breadcrumb GetBreadcrumbs([QueryString("ModuleID")] string moduleID)
        {

            Breadcrumb b = new Breadcrumb();
            if (moduleID != null)
            {
                var _db = new WebDev.Models.ModuleContext();
                Module m = _db.Modules.Find(moduleID);
                Subject s = _db.Subjects.Find(m.SubjectID);

                b.ModuleID = moduleID;
                b.SubjectID = s.SubjectID;
                b.SubjectName = s.SubjectName;
            }
            return b;
        }
        public IQueryable<Module> GetModules([QueryString("ModuleId")] string moduleID)
        {
            var _db = new WebDev.Models.ModuleContext();
            IQueryable<Module> query = _db.Modules;
            if (moduleID != null && moduleID.Length > 0)
            {
                query = query.Where(m => m.ModuleID == moduleID);
                return query;
            }
            else
            {
                query = query.Take(0);
                return query;
            }
        }

        public IQueryable<Question> GetQuestions([QueryString("ModuleID")] string moduleID)
        {
            var _db = new WebDev.Models.ModuleContext();
            IQueryable<Question> query = _db.Questions;
            if (moduleID != null && moduleID.Length > 0)
            {
                query = query.Where(q => q.ModuleID == moduleID);
                query = query.OrderByDescending(q => q.Created);
                query = query.Take(3);

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