using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library
{
    public partial class Site : System.Web.UI.MasterPage
    {
        //public Librarian CurrentUser
        //{
        //    get
        //    {
        //        Librarian librarian = null;

        //        BasePage basePage = Page as BasePage;
        //        if (basePage != null)
        //        {
        //            librarian = basePage.CurrentUser;
        //        }

        //        return librarian;
        //    }
        //}
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LogOut_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
        }
    }
}