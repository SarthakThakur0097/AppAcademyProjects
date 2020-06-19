using Library.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library
{
    public partial class AddState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void SaveState(object sender, EventArgs e)
        {
            string stateName = stateinput.Text;
        

            int? id = DatabaseHelper.Insert(@"
                insert into State (Name)
                values (@Name);
            ",
                new SqlParameter("@Name", stateName));


            //Response.Redirect("~/AuthorsList.aspx");

        }
    }
}