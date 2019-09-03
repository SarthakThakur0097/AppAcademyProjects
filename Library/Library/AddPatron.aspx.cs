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
    public partial class AddPatron : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SavePatron(object sender, EventArgs e)
        {
            string firstName = FirstNameInput.Text;
            string lastName = LastNameInput.Text;
            string email = emailInput.Text;
            string address = AddressInput.Text;
            string city = CityInput.Text;
            string zipCode = ZipInput.Text;

            int? stateId = int.Parse(StateList.SelectedValue);

            // int? authorsId = int.Parse(AuthorListChose.SelectedValue);

            int? id = DatabaseHelper.Insert(@"
                insert into Patron (FirstName, LastName, EmailAddress, AddressLine1, ZipCode, StateId, City)
                values (@FirstName, @LastName, @EmailAddress, @AddressLine1, @ZipCode, @StateId, @City);
            ",
                new SqlParameter("@FirstName", firstName),
                new SqlParameter("@LastName", lastName),
                new SqlParameter("@EmailAddress", email),
                new SqlParameter("@AddressLine1", address),
                new SqlParameter("@ZipCode", zipCode),
                new SqlParameter("@StateId", stateId),
                new SqlParameter("@City", city)) ;
        }
    }
}