using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WidgetLibrary.Data;
namespace WidgetLibrary.Controls
{
    public partial class WeatherControl : System.Web.UI.UserControl
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
   
        }

        protected void zipButton_Click(object sender, EventArgs e)
        {

            string checkIfValidZip = zipInput.Text;
            if(IsPostBack && Page.IsValid)
            {
                errorMessage.Text = "";
                Dictionary<string, string> theWeather = WeatherData.CallApi(checkIfValidZip);
                temp.Text = temp.Text + theWeather["Temperature"];

                temp_min.Text = "Temperature Minumum: " + theWeather["Temperature Min"  ];
                temp_max.Text = "Temperature Maximum: " + theWeather["Temperature Max"];
                pressure.Text = "Presure: " + theWeather["Pressure"];
                humidity.Text = "Humidity: " + theWeather["Humidity"];
                wind_speed.Text = "Wind Speed" + theWeather["Temperature Max"];
            }
        }
        protected bool checkIfNumber(string toCheck)
        {
            bool checkIfNumber = int.TryParse(toCheck, out int result);
            if (checkIfNumber && toCheck.Length==5)
            {
                return true;
            }
            return false;
        }
      
    }
}