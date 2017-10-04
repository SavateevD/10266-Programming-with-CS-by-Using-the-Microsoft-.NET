using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events
{
    class Switcher
    {

        public event Action Switch;

        public void SwitchOn()
        {
            if (Switch != null)
                Switch();
        }
    }
}
