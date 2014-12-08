using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace WebDev.Account
{
    public partial class ManageDegree : System.Web.UI.Page
    {
        protected string SuccessMessage
        {
            get;
            private set;
        }
      
       // private bool HasDegree(ApplicationUserManager manager)
       // {
       //     return manager.HasPassword(User.Identity.GetUserId());
       // }

        protected void Page_Load(object sender, EventArgs e)
        {
            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();

     
                    ChangeDegree.Visible = true;
                

                // Render success message
                var message = Request.QueryString["m"];
                if (message != null)
                {
                    // Strip the query string from action
                    Form.Action = ResolveUrl("~/Account/Manage");
                }
            
        }

        protected void ChangeDegree_Click(object sender, EventArgs e)
        {
            //if (IsValid)
            //{
                var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
                var signInManager = Context.GetOwinContext().Get<ApplicationSignInManager>();
                IdentityResult result = manager.ChangeDegree(User.Identity.GetUserId(), degree.Text);
                if (result.Succeeded)
                {
                    var user = manager.FindById(User.Identity.GetUserId());
                    signInManager.SignIn( user, isPersistent: false, rememberBrowser: false);
                    //Response.Redirect("~/Account/Manage?m=ChangePwdSuccess");
                }
                else
                {
                    AddErrors(result);
                }
            //}
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

        
    }
}