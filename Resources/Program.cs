using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Resources
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConnection c = null;
            using (c = new DBConnection())
            {
                
                c.Execute();
            }
            /*
            using (DBConnection c = new DBConnection())
            {
                c.Execute();
            }*/
            
            
            /*
            DBConnection c = null;
            try
            {
                c = new DBConnection();
                c.Execute();
            }
            finally
            {
                if (c != null)
                    c.Dispose();
            }*/
            
            //c = null;

            //GC.Collect();

            Console.ReadKey();


        }
    }
}
