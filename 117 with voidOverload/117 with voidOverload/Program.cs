using System;

namespace _117_with_voidOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            //create class object by call consturctor
                Class1 operation = new Class1();


                Console.WriteLine("Please type a whole even number to divide");
                int num1 = Convert.ToInt32(Console.ReadLine());

                int num;
                

                operation.Divide(out num, num1) ;


                //out (parameter)
                Console.WriteLine("The number you entered divided by two equals: " + num);
                //return (variable from class)
                Console.WriteLine("The number you entered divided by two equals: " + operation.Divide(num1));
                Console.ReadLine();

            
        }
    }
}
