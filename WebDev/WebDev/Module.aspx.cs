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

        public IQueryable<Notes> GetNotes([QueryString("ModuleID")] string moduleID)
        {
            var _db = new WebDev.Models.ModuleContext();
            IQueryable<Notes> query = _db.Notes;
            if (moduleID != null && moduleID.Length > 0)
            {
                query = query.Where(n => n.ModuleID == moduleID);
                query = query.OrderByDescending(n => n.Created);
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