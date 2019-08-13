using System;
using System.Collections.Generic;

namespace _120_Employee_F_L_name
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee name = new Employee();
            name.Names = new List<string>() { "Sample", "Student" };
            name.SayName();
            Console.ReadLine();
        }
    }
}
