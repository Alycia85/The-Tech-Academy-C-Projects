using System;
using System.Collections.Generic;

namespace _124_abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee name = new Employee() { firsName = "Sample", lastName = "Student" };
            name.SayName();
            Console.ReadLine();
        }
    }
}
