using System;

namespace Method_111
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please type a number to add");
            int num1 = Convert.ToInt32(Console.ReadLine());

          
                              


            int c = Sum;

             
            Console.WriteLine("The Value of the sum is " + c);


            
                Console.WriteLine("Please type a number to divide");
                int Divide1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please type a second number to divide");
                int Divide2 = Convert.ToInt32(Console.ReadLine());


                int h = Divide1;
                int k = Divide2;


                int i = Divide(h, k);

                 
                Console.WriteLine("The Value of the Division is " + i);


            
                Console.WriteLine("Please type a number to multiply");
                int Multiply1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please type a second number to multiply");
                int Multiply2 = Convert.ToInt32(Console.ReadLine());


                int d = Multiply1;
                int e = Multiply2;


                int f = Multiply(d, e);

                
                Console.WriteLine("The Value of the Multiplication is " + f);
            
        }


    }
}