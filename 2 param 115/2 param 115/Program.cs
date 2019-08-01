using System;

namespace _2_param_115
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 math = new Class1();



            Console.WriteLine("Please type a number to Add");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please type a number to Add or press enter; this second number is optional.");
           string num = (Console.ReadLine());

            if (string.IsNullOrEmpty(num))
            {
               
                Console.WriteLine(math.Addition(num1));
            }

            else
            {
                int i = Convert.ToInt32(num);
                Console.WriteLine("Sum:" + math.Addition(num1, i));
            }
            Console.ReadLine();
        }
    }
}
