﻿using Library.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library
{
    public partial class StateList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                DataTable dt = DatabaseHelper.Retrieve(@"
                    SELECT [State].Name
                    FROM [State]
                    
                ");

                States.DataSource = dt.Rows;
                States.DataBind();

            }
        }
    }
}