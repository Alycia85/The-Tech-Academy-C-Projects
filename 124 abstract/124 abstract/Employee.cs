using System;
using System.Collections.Generic;
using System.Text;

namespace _124_abstract
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine(firsName + " " + lastName);
        }
    }
}
