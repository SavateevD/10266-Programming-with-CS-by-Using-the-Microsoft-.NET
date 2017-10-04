using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;

namespace Interoperation
{
    class Program
    {
        // Use DllImport to import the Win32 MessageBox function.
        [DllImport("user32.dll", CharSet = CharSet.Unicode )]
        public static extern int MessageBox(IntPtr hWnd, String text, 
            String caption, uint type);

        static void Main()
        {
            // Call the MessageBox function using platform invoke.

            Application excel = new Application();
            excel.Visible = true;
            excel.Workbooks.Add().Activate();

            MessageBox(new IntPtr(0), "Hello World!", "Hello Dialog",0);
            excel.Quit();
            excel = null;


        }

    }
}
