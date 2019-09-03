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
    public partial class LibrarianList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = DatabaseHelper.Retrieve(@"
                    SELECT Patron.FirstName
                    FROM Patron JOIN Librarian ON Patron.LibraryCardId = Librarian.LibraryCardId
                    
                ");

                Librarians.DataSource = dt.Rows;
                Librarians.DataBind();
            }
        }
    }
}