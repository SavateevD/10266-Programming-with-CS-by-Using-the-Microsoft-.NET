using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events
{
    
    public delegate void PressButtonDelegate(object sender, EventArgs args);
    
    public class MyButton
    {
        //public Action<object, EventArgs> ButtonPress = null;
        public event PressButtonDelegate ButtonPress = null;

        protected virtual void OnPress()
        {
            if (ButtonPress != null)
                ButtonPress(this, new EventArgs());
                    //ButtonPress.BeginInvoke(this, new EventArgs(), null, null);
        }
        
        public void Press()
        {
            OnPress();
        }
    }
}
