using System;

namespace _126_interface_polymorph
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
