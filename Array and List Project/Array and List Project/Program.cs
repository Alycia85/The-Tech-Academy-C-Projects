using System;
using System.Collections.Generic;

namespace Array_and_List_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] stringArray = { "Bob", "Sally", "Joe", "Jim200", "Joe5000" };
            //Console.WriteLine("Please enter a number");
            //int input = Convert.ToInt32(Console.ReadLine()) ;

            //Console.WriteLine(stringArray[input]);
            //Console.ReadLine();






            //int[] numArray = {5, 1000, 2, 105, 5000};
            //Console.WriteLine("Please enter a number");
            //int input = Convert.ToInt32(Console.ReadLine());

            //if (input == 0)
            //{
            //    Console.WriteLine(numArray[input]);
            //    Console.ReadLine();
            //}

            //else if (input == 1)
            //{
            //    Console.WriteLine(numArray[input]);
            //    Console.ReadLine();
            //}

            //else if (input == 2)
            //{
            //    Console.WriteLine(numArray[input]);
            //    Console.ReadLine();
            //}

            //else if (input == 3)
            //{
            //    Console.WriteLine(numArray[input]);
            //    Console.ReadLine();
            //}

            //else if (input == 4)
            //{
            //    Console.WriteLine(numArray[input]);
            //    Console.ReadLine();
            //}

            //else
            //{
            //    Console.WriteLine("That number is not available.");
            //    Console.ReadLine();
            //}


            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(10);
            Console.WriteLine("Please enter a number");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(intList[input]);
            Console.ReadLine();

        }
    }
}