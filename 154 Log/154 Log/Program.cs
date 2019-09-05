using System;
using System.IO;

namespace _154_Log
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Type a number.");
            string text = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Student\Log\log.txt", text);

            Console.WriteLine(text);
        }
    }
}
