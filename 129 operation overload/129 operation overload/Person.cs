﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _129_operation_overload
{
    public class Person
    {

        public string firstName { get; set; }
        public string lastName { get; set; }


        public void SayName()
        {

            {
                Console.WriteLine("Name: " + firstName + " " + lastName);
            }

        }
    }
}
