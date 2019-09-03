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
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveBook()
        {
            string bookTitle = BookTitle.Text;
            string ISBN = ISBNGet.Text;
            int? authorsId = int.Parse(AuthorListChose.SelectedValue);
            int? libraryId = int.Parse(LibraryList.SelectedValue);


            int? id = DatabaseHelper.Insert(@"
                insert into item (title, isbn, authorId)
                values (@title, @isbn, @authorsId);
            ",
                new SqlParameter("@title", bookTitle),
                new SqlParameter("@isbn", ISBN),
                new SqlParameter("@authorsId", authorsId));

            int? CopyId = DatabaseHelper.Insert(@"
                insert into ItemCopy (ItemId, LibraryId)
                values (@ItemID, @LibraryId);
            ",
                new SqlParameter("@ItemId", id),
                new SqlParameter("@LibraryId", libraryId));

        }


        protected void SaveItem(object sender, EventArgs e)
        {
            saveBook();
            Response.Redirect("~/BookList.aspx");

            //Response.Redirect("~/AuthorsList.aspx");
        }
    }
}