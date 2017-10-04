using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events
{
    public class MyWindow
    {

        public void MyWindowButtonHandler(object sender, EventArgs args)
        {
            Console.WriteLine("Обработка нажатия на кнопку");
        }
    }
}
