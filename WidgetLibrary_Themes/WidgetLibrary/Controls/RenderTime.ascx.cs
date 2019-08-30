using System;

namespace WidgetLibrary.Controls
{
    public partial class RenderTime : System.Web.UI.UserControl
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            var now = DateTime.UtcNow;

            Message.Text = "Page rendered at: " + now;
            
        }
    }
}