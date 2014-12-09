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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public Breadcrumb GetBreadcrumbs([QueryString("SubjectID")] int? subjectID)
        {

            Breadcrumb b = new Breadcrumb();
            if (subjectID.HasValue)
            {
                var _db = new WebDev.Models.ModuleContext();
                Subject s = _db.Subjects.Find(subjectID);

                b.SubjectID = s.SubjectID;
                b.SubjectName = s.SubjectName;
            }
            return b;
        }

        public IQueryable<Module> GetModules([QueryString("SubjectID")] int? subjectID)
        {
            var _db = new WebDev.Models.ModuleContext();
            IQueryable<Module> query = _db.Modules;
            if (subjectID.HasValue && subjectID > 0)
            {
                query = query.Where(m => m.SubjectID == subjectID);
            }
            return query;
        }

        public IQueryable<Subject> GetSubjects([QueryString("SubjectID")] int? subjectID)
        {
            var _db = new WebDev.Models.ModuleContext();
            IQueryable<Subject> query = _db.Subjects;
            if (subjectID.HasValue && subjectID > 0)
            {
                query = query.Where(s => s.SubjectID == subjectID);
            }
            return query;
        }

    }
}