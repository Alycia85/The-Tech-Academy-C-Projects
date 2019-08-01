using System;

namespace Math_114
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 math = new Class1();

            Console.WriteLine("Please type a number to divide");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int i = math.Divide(num3);


            Console.WriteLine("The Value of the Division is " + i);
        }
    }
}
