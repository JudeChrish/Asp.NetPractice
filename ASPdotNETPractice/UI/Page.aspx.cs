using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPdotNETPractice.UI.UserControls;

namespace ASPdotNETPractice.UI
{
    public partial class Page1 : System.Web.UI.Page
    {
        public int counter = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Calendar1.VisibilityChangedEvent += Calendar1_VisibilityChangedEvent;
        }

        private void Calendar1_VisibilityChangedEvent(object sender, CalendarEventArgs e)
        {
            Response.Write("doing stuff using event. Calendar Visibility status = " + e.VisibilityState.ToString());
        }

        protected void PrintonScreen_ButtonClick(object sender, EventArgs e)
        {
            Response.Write(Calendar1.SelectedDateFromCalendar);
        }
    }
}