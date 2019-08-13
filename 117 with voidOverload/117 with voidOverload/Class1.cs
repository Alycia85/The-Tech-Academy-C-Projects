using System;
using System.Collections.Generic;
using System.Text;

namespace _117_with_voidOverload
{
    class Class1
    {
        public void Divide (out int div, int num)
        {
           
            div = num / 2;

        }

        //method overide = same method name used more than once altering number of parameters or parameter type( int,dec, bool, etc.)
        public int Divide(int num)
        {

            int div = num / 2;

            return div;

        }
    }
}

   