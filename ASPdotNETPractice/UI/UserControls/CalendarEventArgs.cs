using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPdotNETPractice.UI.UserControls
{
    public class CalendarEventArgs : EventArgs
    {
        private bool _VisibilityState;

        public bool VisibilityState
        {
            get
            {
                return _VisibilityState;
            }

            set
            {
                _VisibilityState = value;
            }
        }

        public CalendarEventArgs(bool StateOfTheVisibility)
        {
            _VisibilityState = StateOfTheVisibility;
        }

    }
}