using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WidgetLibrary.Data;

namespace WidgetLibrary.Controls
{
    public partial class QuoteOfTheDay : System.Web.UI.UserControl
    {
        string myRandomQuote;
        bool random = false;
        public bool Randomize
        {
            get
            {
                return random;

            }
            set
            {
                random = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string myQuote = QuotesData.GetQuoteOfTheDay();
            Quote.Text = "Your quote of the day is " + myQuote + "\n";
            myRandomQuote = QuotesData.GetRandomQuote();
            RandomQuote.Text = "Your random quote is: " + myRandomQuote;

        }

      
        protected void QuoteButton_Click(object sender, EventArgs e)
        {
            string myRandomQuote = QuotesData.GetRandomQuote();
            RandomQuote.Text = "Your random quote is: " + myRandomQuote;
        }
    }
}