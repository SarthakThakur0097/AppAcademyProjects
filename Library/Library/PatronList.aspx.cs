using Library.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library
{
    public partial class PatronList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DataTable dt = DatabaseHelper.Retrieve(@"
                    SELECT Patron.FirstName
                    FROM Patron
                    
                ");

            Patrons.DataSource = dt.Rows;
            Patrons.DataBind();

        }
    }
}