using System;

namespace ConsoleApp2_lesson66_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number to be multiplied by 50");
            string numberMultiplied = Console.ReadLine();
            int numMultiplied = Convert.ToInt32(numberMultiplied);
            int Total = numMultiplied * 50;
            Console.WriteLine(Total);
            Console.ReadLine();

            Console.WriteLine("Type a number and the Computer will add 25");
            string numberAdded = Console.ReadLine();
            int numAdded = Convert.ToInt32(numberAdded);
            int totalAdd = numAdded + 25;
            Console.WriteLine(totalAdd);
            Console.ReadLine();

            Console.WriteLine("Type a whole number and the Computer will divide it by 12.5");
            string numberDivide = Console.ReadLine();
            int numDivide = Convert.ToInt32(numberDivide);
            double totalDivide = numDivide / 12.5;
            Console.WriteLine(totalDivide);
            Console.ReadLine();

            Console.WriteLine("Type a number and the Computer will check if it is greater than 50");
            string numberGreater = Console.ReadLine();
            int numGreater = Convert.ToInt32(numberGreater);
            bool totalGreater = numGreater > 50;
            Console.WriteLine(totalGreater);
            Console.ReadLine();

            Console.WriteLine("Type a number and the Computer will give Remainder ");
            string numberRemainder = Console.ReadLine();
            int numRemainder = Convert.ToInt32(numberRemainder);
            int totalRemainder = numRemainder % 7;
            Console.WriteLine(totalRemainder);
            Console.ReadLine();

        }
    }
}


//1. Takes an input from the user, multiplies it by 50, and prints the result to the console. (Note: make sure your code can take inputs larger than 10,000,000).

//2. Takes an input from the user, adds 25 to it, and prints the result to the console.

//3. Takes an input from the user, divides it by 12.5, and prints the result to the console.

//4. Takes an input from the user, checks if it is greater than 50, and prints the true/false result to the console.

//5. Takes an input from the user, divides it by 7, and prints the remainder to the console (tip: think % operator).