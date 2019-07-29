using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
        //string[] names = { "Jesse ", "Erik ", "Daniel ", "Adam " };
        //Console.WriteLine("Please write a last name.");
        //string lname = Console.ReadLine();
        //for (int j = 0; j < names.Length; j++)
        //{
        //     Console.WriteLine(names[j] + lname);
        //}
        //Console.ReadLine();


        //string[] names = { "Jesse ", "Erik ", "Daniel ", "Adam " };
        //Console.WriteLine("Please write a last name.");
        //string lname = Console.ReadLine();

        //for (int j = 0; j < 50; j++)
        //{
        //    Console.WriteLine(names[1] + lname);
        //}
        //Console.ReadLine();



        //string[] names = { "Jesse ", "Erik ", "Daniel ", "Adam " };
        //Console.WriteLine("Please write a last name.");
        //string lname = Console.ReadLine();

        //for (int j = 0; j < names.Length; j++)
        //{
        //    Console.WriteLine(names[j] + lname);
        //}
        //Console.ReadLine();


        //string[] names = { "Jesse ", "Erik ", "Daniel ", "Adam " };
        //Console.WriteLine("Please write a last name.");
        //string lname = Console.ReadLine();

        //for (int j = 0; j <= 2; j++)
        //{
        //    Console.WriteLine(names[j] + lname);
        //}
        //Console.ReadLine();


        //List<string> intList = new List<string>();
        //intList.Add("Hello");
        //intList.Add("Jesse");
        //Console.WriteLine("Please type Hello or Jesse to see the index value");
        //string index = Console.ReadLine();

        //for (int i = 0; i < intList.Count; i++)
        //{
        //    if (intList[i] == index)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        //Console.ReadLine();


        //List<string> intList = new List<string>();
        //intList.Add("Hello");
        //intList.Add("Jesse");
        //intList.Add("Adam");
        //Console.WriteLine("Please type a name or word to see the index value");
        //string index = Console.ReadLine();

        //for (int i = 0; i < intList.Count; i++)
        //{
        //    if (intList[i] == index)
        //    {
        //        Console.WriteLine(i);
        //    }

        //        else
        //    {
        //        Console.Write("That name or word is not in the list.");

        //    }
        //}
        //Console.ReadLine();


        ////////////8///////// not iterating through each item and then breaking
        List<string> intList = new List<string>();
        intList.Add("Hello");
        intList.Add("Jesse");
        intList.Add("Adam");
        Console.WriteLine("Please type a name or word to see the index value");
        string index = Console.ReadLine();

        for (int i = 0; i < intList.Count; i++)
        {
            if (intList[i] == index)
            {
                Console.WriteLine(i);
            }

            else if (i == intList.Count)
            {
                Console.WriteLine("That name or word is not in the list.");
            }
        }
        Console.ReadLine();



        //List<string> intList = new List<string>();
        //intList.Add("Hello");
        //intList.Add("Alex");
        //intList.Add("Alex");

        //foreach (string name in intList)
        //{
        //    if (name == "Alex")
        //    {
        //        Console.WriteLine(name + " has already appeared in the list.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Hello has not appeared in the list.");
        //    }
        //}
    }
}