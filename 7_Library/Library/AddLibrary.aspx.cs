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
    public partial class AddLibrary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Library(object sender, EventArgs e)
        {
            string libraryName = LibName.Text;
            string address = AddressInput.Text;
            string city = CityInput.Text; 
            

            int? stateId = int.Parse(StateList.SelectedValue);


            int? id = DatabaseHelper.Insert(@"
                insert into Library (LocationName, AddressLine1, City, StateId)
                values (@LocationName, @AddressLine1, @City, @StateId);
            ",
                new SqlParameter("@LocationName", libraryName),
                new SqlParameter("@AddressLine1", address),
                new SqlParameter("@City", city),
                new SqlParameter("@StateId", stateId));
                ;
              
        }

    }
}