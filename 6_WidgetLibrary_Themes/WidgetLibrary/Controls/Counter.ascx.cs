using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WidgetLibrary.Controls
{
    public partial class Counter : System.Web.UI.UserControl
    {
        string counterKey = "CounterProp";

        public int CounterProp
        {
            get
            {
                object viewStateInt = ViewState[counterKey];

                if(viewStateInt!=null)
                {
                    return (int)viewStateInt;
                }
                else
                {
                    return 0;
                }
                 
            }
            set
            {
                ViewState[counterKey] = value;
            }
        }
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Increase_Click(object sender, EventArgs e)
        {
            CounterProp++;
            Clicks.Text = "" + CounterProp;
        }

        protected void Decrease_Click(object sender, EventArgs e)
        {
            CounterProp--;
            Clicks.Text = "" + CounterProp;
        }
    }
}