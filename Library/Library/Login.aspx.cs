using System;
using System.Data;
using Library.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Library
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            


            int username = int.Parse(Username.Text);
            string passWord = Password.Text;   

            DataTable dt = DatabaseHelper.Retrieve(@"
                    SELECT l.LibraryCardId
                    FROM Librarian l
                    WHERE l.LibraryCardId = @LibraryCardId AND " + "l.[LibPassword] = @Password ",
                    new System.Data.SqlClient.SqlParameter("@LibraryCardId",username),
                     new System.Data.SqlClient.SqlParameter("@Password", passWord)
                    );


            if (dt.Rows.Count==1)
            {
                FormsAuthentication.RedirectFromLoginPage(username.ToString(), true);

            }

           


        }


    }
}