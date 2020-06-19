using Library.Data;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library
{
    public partial class CheckOutPatron : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void CheckOut_Book(object sender, EventArgs e)
        {
            int librarianId = int.Parse(LibrarianList.SelectedValue);
            int bookId = int.Parse(BookList.SelectedValue);
            int PatronIdInput = int.Parse(PatronList.SelectedValue);
            int itemCopyId = int.Parse(BookList.SelectedValue);

           
            DateTime current = DateTime.UtcNow;

         


            int? id = DatabaseHelper.Insert(@"
                insert into PatronCheckout (LibrarianId, PatronId, ItemCopyId, ReservedOn)
                values (@LibrarianId, @PatronId, @ItemCopyId, @ReservedOn);
            ",
              new SqlParameter("@LibrarianId", librarianId),
              new SqlParameter("@PatronId", PatronIdInput),
              new SqlParameter("@ItemCopyId", itemCopyId),
              new SqlParameter("@ReservedOn", current)
              );

        }
    }
}