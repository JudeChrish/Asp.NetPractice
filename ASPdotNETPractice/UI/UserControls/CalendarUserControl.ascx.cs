using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ASPdotNETPractice.UI.UserControls;
using static ASPdotNETPractice.UI.UserControls.Delelgates;

namespace ASPdotNETPractice.UI.UserControls
{
    public partial class CalendarUserControl : System.Web.UI.UserControl
    {

        #region Properties
        public string SelectedDateFromCalendar
        {
            get
            {
                return DOBTextBox.Text;
            }            
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Calendar.Visible = false;
            }
        }

        protected void CalendarButton_Click(object sender, EventArgs e)
        {
            if (Calendar.Visible)
            {
                Calendar.Visible = false;
                CalendarEventArgs calendarEventArgs = new CalendarEventArgs(false);
                OnVisibilityChanged(calendarEventArgs);
            }
            else
            {
                Calendar.Visible = true;
                CalendarEventArgs calendarEventArgs = new CalendarEventArgs(true);
                OnVisibilityChanged(calendarEventArgs);
            }
        }

        protected void Calendar_SelectDate(object sender, EventArgs e)
        {
            DOBTextBox.Text = Calendar.SelectedDate.ToShortDateString();
            Calendar.Visible = false;
            CalendarEventArgs calendarEventArgs = new CalendarEventArgs(false);
            OnVisibilityChanged(calendarEventArgs);
        }

        public event CalendarVisibiltyChangedEventHandler VisibilityChangedEvent;

        protected virtual void OnVisibilityChanged(CalendarEventArgs e)
        {
            if(VisibilityChangedEvent!= null)
            {
                VisibilityChangedEvent(this, e);
            }
        }
    }    
   
}