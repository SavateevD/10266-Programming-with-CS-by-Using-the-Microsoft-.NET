using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collections
{
    public class ReadonlyStorage<MyType>
        where MyType : IComparable<MyType>
    {
        MyType data;

        public ReadonlyStorage(MyType data)
        {
            this.data = data;
        }

        public bool IsGreater(MyType d)
        {
            return data.CompareTo(d) > 0;
        }
        
        
        
        
        
        
        public MyType Data
        {
            get { return data;  }
        }
    }
}
