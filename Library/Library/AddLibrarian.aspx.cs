using Library.Data;
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library
{
    public partial class AddLibrarian : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveLibrarian(object sender, EventArgs e)
        {

            //            SELECT Patron.FirstName, Patron.LastName, Patron.EmailAddress, Patron.AddressLine1, Patron.City, Patron.StateId, Patron.ZipCode
            //FROM Patron;
            DataTable dt = DatabaseHelper.Retrieve(@"
                    SELECT Author.FirstName, Author.LastName, Item.Title
                    FROM Author JOIN Item ON Author.Id = Item.AuthorId
                    
                ");



            int libraryId =int.Parse(LibraryList.SelectedValue);
            int libraryCardId = int.Parse(PatronList.SelectedValue);
           


            int? id = DatabaseHelper.Insert(@"
                insert into Librarian (LibraryCardId, LibraryId)
                values (@LibraryCardId, @LibraryId);
            ",
                new SqlParameter("@LibraryCardId", libraryCardId),
                new SqlParameter("@LibraryId", libraryId));
            ;

        }
    }
}