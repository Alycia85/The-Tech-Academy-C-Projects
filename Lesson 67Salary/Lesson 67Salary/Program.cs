using System;

namespace Lesson_67Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            String hourly1 = Console.ReadLine();
            int hour1 = Convert.ToInt32(hourly1);
            Console.WriteLine("Hours worked per week?");
            String hourWk1 = Console.ReadLine();
            int Wk1 = Convert.ToInt32(hourWk1);

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            String hourly2 = Console.ReadLine();
            int hour2 = Convert.ToInt32(hourly2);
            Console.WriteLine("Hours worked per week?");
            String hourWk2 = Console.ReadLine();
            int Wk2 = Convert.ToInt32(hourWk2);

            Console.WriteLine("Weekly salary of Person 1: " + (hour1 * Wk1));
            Console.Read();
            Console.WriteLine("Weekly salary of Person 2: " + (hour2 * Wk2));
            Console.Read();
            Console.WriteLine("Does Person 1 make more money than Person 2 ?");
            Console.Read();
            int total1 = hour1 * Wk1;
            int total2 = hour2 * Wk2;
            bool isgreater = total1 > total2;
            Console.WriteLine(isgreater);
            Console.Read();
        }
    }
}
