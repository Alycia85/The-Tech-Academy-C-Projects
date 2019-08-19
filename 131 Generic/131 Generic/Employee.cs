using System;
using System.Collections.Generic;
using System.Text;

namespace _131_Generic
{
    public class Employee<T>
    {
       public List<T> things { get; set; }
        public int Number { get; set; }
        public string Word { get; set; }

    
    }
}


