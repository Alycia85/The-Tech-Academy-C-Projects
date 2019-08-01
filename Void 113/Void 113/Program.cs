using System;

namespace Void_113
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 operation = new Class1();


            Console.WriteLine("Please type a number to divide");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            int num;
            
            operation.Divide(asds: out num, num: num1);

            //operation.Divide(out num1, num);


            
            Console.WriteLine("The second number/ output variable: {0}", num);
            Console.ReadLine();

        }
    }
}
