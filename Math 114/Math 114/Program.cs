using System;

namespace Math_114
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 math = new Class1();

            Console.WriteLine("Please type a number to divide");
            int num = Convert.ToInt32(Console.ReadLine());

            int i = math.Divide(num);


            Console.WriteLine("The Value of the Division is " + i);

                         
                double num1 = .25;

                 i = math.Divide(num1);


                Console.WriteLine("The Value of the Addition is " + i);


                string num2 = "10";

                i = math.Divide(num2);


                Console.WriteLine("The Value of the Quotient is " + i);
            

        }
    }
}
