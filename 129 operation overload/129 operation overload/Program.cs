using System;

namespace _129_operation_overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee id1 = new Employee()
            {
               
                Id = 5
            };
            Employee id2 = new Employee()
            {
                Id = 7
            };

            Console.WriteLine(id1 == id2);
            Console.ReadLine();

        }
    }
}
