using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //IPrincipal user = User;
            //IIdentity identity = User.Identity;

            //if (!CustomUser.IsAdmin)
            //{
            //    Response.Redirect("~/NotAuthorized.aspx");
            //}
        }
        //protected void Logout_Click(object sender, EventArgs e)
        //{
        //    System.Web.Security.FormsAuthentication.SignOut();
        //    System.Web.Security.FormsAuthentication.RedirectToLoginPage();
        //    //Response.Redirect("~/Login.aspx");
        //}
    }
}