using System;
using System.Collections.Generic;

namespace _131_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> str = new Employee<string>();

            str.things = new List<string>()
            {
                "Bob",
                "Jo"
            };
         
            Employee<int> num = new Employee<int>();

            num.things = new List<int>()
            {
                5, 7, 10
            };

          

                foreach (string Thing in str.things)
                {
                    Console.WriteLine(Thing);
                }
           
                foreach (int Thing in num.things)
                {
                Console.WriteLine(Thing);
                }
            Console.ReadLine();

           
        }
    }
}
