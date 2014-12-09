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
    public partial class ViewNotes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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