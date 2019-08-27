using System;

namespace _134_enum
{
    class Program
    {
        static void Main(string[] args)
        {
           

            try
            {
                Console.WriteLine("Please enter the day of the week.");
                var day = Console.ReadLine();
                DaysOfTheWeek days = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), day);

                int value;
                if (int.TryParse(day, out value))
                {
                    Console.WriteLine("This is a number. Please enter a day of the week.");
                }
                else
                {
                    for (int i = 0; i < 7; i++)
                    {
                        if (days == (DaysOfTheWeek)i)
                        {
                            Console.WriteLine("You have entered: " + days);
                        }
                    }

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            
            finally
            {
                Console.ReadLine();
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

