using System;

namespace Insurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string yourAge = Console.ReadLine();
            int yrAge = Convert.ToInt32(yourAge);
            Console.Read();

            Console.WriteLine("Have you ever had a DUI?");
            string DUI = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("How many Speeding Tickets do you have?");
            string yourTickets = Console.ReadLine();
            int yrTickets = Convert.ToInt32(yourTickets);
            Console.Read();

            Console.WriteLine("Qualified?");
            bool isQualified = (yrAge >= 15 && DUI == "no" && yrTickets <=3) ;
            Console.WriteLine(isQualified);
            Console.ReadLine();
        }
    }
}
