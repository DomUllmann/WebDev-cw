using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebDev.Models;

namespace WebDev
{
    public partial class EditNotes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        public Breadcrumb GetBreadcrumbs([QueryString("NotesID")] int? notesID)
        {

            Breadcrumb b = new Breadcrumb();
            if (notesID != null)
            {
                var _db = new WebDev.Models.ModuleContext();

                Notes n = _db.Notes.Find(notesID);
                Module m = _db.Modules.Find(n.ModuleID);
                Subject s = _db.Subjects.Find(m.SubjectID);
        

                b.ModuleID = m.ModuleID;
                b.SubjectID = s.SubjectID;
                b.SubjectName = s.SubjectName;
            }
            return b;
        }

        public IQueryable<Notes> GetNotes([QueryString("NotesID")] int? notesID)
        {
            var _db = new WebDev.Models.ModuleContext();
            IQueryable<Notes> query = _db.Notes;
            if (notesID.HasValue && notesID > 0)
            {
                query = query.Where(n => n.NotesID == notesID);

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