using System;

namespace Shipping_Quote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("What does the package weigh?");
            float pkW = Convert.ToInt32(Console.ReadLine());

            if (pkW >= 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }

            else
            {
                Console.WriteLine("What is the package height?");
                float pkH = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the package Width?");
                float pkWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the package Length?");
                float pkL = Convert.ToInt32(Console.ReadLine());

                if (pkH + pkWidth + pkL >= 50)

                    Console.WriteLine("Package too big to be shipped via Package Express.");


                else
                {
                    double dimension = pkH + pkWidth + pkL;
                    double mult = dimension * pkW;
                    double quote = mult / 100;
                    Console.WriteLine("Quote: " + "$" + quote);
                }

                Console.ReadLine();
            }
        }
    }
}