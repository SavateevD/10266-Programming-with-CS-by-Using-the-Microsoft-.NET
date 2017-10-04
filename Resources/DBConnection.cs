using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Resources
{
    public class DBConnection : IDisposable
    {

        public DBConnection()
        {
            Console.WriteLine("connection open...");
        }

        public void Execute()
        {
            Console.WriteLine("excuting....");
        }

        private bool isDisposed = false;
        ~DBConnection()
        {
            Dispose();
        }

        public void Dispose()
        {
            if (!isDisposed)
            {
                Console.WriteLine("close connection");
                GC.SuppressFinalize(this);
                isDisposed = true;
            }

        }
    }
}
