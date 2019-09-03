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
    public partial class BookCopies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = DatabaseHelper.Retrieve(@"
                    SELECT IC.ItemId, IC.Id AS ItemCopyID, L.Id AS LibraryID, I.Title, L.LocationName
                        FROM ItemCopy IC
                        JOIN Item I ON I.Id = IC.ItemId 
                        JOIN [Library] L ON L.Id = IC.LibraryId
                ");

                Books.DataSource = dt.Rows;
                Books.DataBind();
            }
        }
    }
}