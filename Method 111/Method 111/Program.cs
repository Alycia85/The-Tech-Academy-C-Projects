using System;


namespace Method_111
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please type a number to add");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Class1 math = new Class1();
            
            int c = math.Sum(num1);
                         
            Console.WriteLine("The Value of the sum is " + c);


            
                Console.WriteLine("Please type a number to divide");
                int num3 = Convert.ToInt32(Console.ReadLine());

                int i = math.Divide(num3);

                 
                Console.WriteLine("The Value of the Division is " + i);


            
                Console.WriteLine("Please type a number to multiply");
                int num2 = Convert.ToInt32(Console.ReadLine());



                int f = math.Multiply(num2);

                
                Console.WriteLine("The Value of the Multiplication is " + f);
            
        }


    }
}