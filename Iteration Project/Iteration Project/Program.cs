﻿using System;
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


        List<string> intList = new List<string>();
        intList.Add("Hello!");
        intList.Add("Jesse");
        Console.WriteLine("Please type Jesse or Hello! to see the index for that word.");
        string index = Console.ReadLine();

        for (int i = 0; i < intList.Count; i++)
        {
            if (intList[i] == "Jesse")
            {
                Console.WriteLine(intList[i]);
            }
            else if (intList[i] == "Hello!")
            {
                Console.WriteLine(intList[i]);
            }
        }
        Console.ReadLine();

    }
}