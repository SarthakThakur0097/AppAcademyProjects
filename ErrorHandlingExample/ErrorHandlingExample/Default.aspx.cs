using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ErrorHandlingExample
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Sum_Click(object sender, EventArgs e)
        {

            int result, result2;
            
            bool intNum1 = int.TryParse(Number1.Text, out result);
            bool intNum2 = int.TryParse(Number2.Text, out result2);
            
            if(intNum1 && intNum2)
            {
                int toAdd = int.Parse(Number1.Text);
                int toAdd2 = int.Parse(Number2.Text);
                int sum = (toAdd + toAdd2);

                System.Diagnostics.Debug.Assert(sum != 21);
                Result.Text = "" + sum;
                
                Trace.Write("The sum is: " + sum);
            }
            else
            {
                Trace.Write("ParseError", "Did not enter valid numbers");
                Trace.Warn("ParseError", "Did not enter valid numbers");

            }

        }
    }
}