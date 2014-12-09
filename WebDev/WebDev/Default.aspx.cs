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
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Subject> GetSubjects()
        {
            var _db = new WebDev.Models.ModuleContext();
            IQueryable<Subject> query = _db.Subjects;
            return query;
        }
    }
}