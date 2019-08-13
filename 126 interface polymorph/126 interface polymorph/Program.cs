using System;

namespace _126_interface_polymorph
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable quit = new Employee();
            quit.Quit();
            Console.ReadLine();
        }
    }
}
