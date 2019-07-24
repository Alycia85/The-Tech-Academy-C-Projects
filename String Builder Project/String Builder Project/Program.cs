using System;
using System.Text;

namespace String_Builder_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Bob";
            //string word = " says";
            //string word2 = " Hellooo....!!";
            //Console.WriteLine(name + word + word2);
            //Console.ReadLine();

            //string name = "billy";
            //name = name.ToUpper();
            //Console.WriteLine(name);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Jesse.");
            sb.Append("\nI like to ride a bicycle.");
            sb.Append("\nI also enjoy ice cream.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
