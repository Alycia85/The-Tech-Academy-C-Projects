using System;

namespace _134_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the day of the week.");
            string day = Console.ReadLine();

            try
            {
                DaysOfTheWeek days = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), day);
                Console.WriteLine("You have entered: " + days);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

        }
            
            
            

            public enum DaysOfTheWeek
            {
                Monday,
                Tuesday,
                Wednesday,
                Thursday,
                Friday,
                Saturday,
                Sunday

            }
    
    }
}

