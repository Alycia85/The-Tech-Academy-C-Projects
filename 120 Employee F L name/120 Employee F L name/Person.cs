using System;
using System.Collections.Generic;
using System.Text;

namespace _120_Employee_F_L_name
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
