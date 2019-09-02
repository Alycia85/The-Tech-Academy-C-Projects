using System;
using System.Collections.Generic;
using System.Linq;

namespace _140_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                List<Employee> employees = new List<Employee>();
                employees.Add(new Employee() { FirstName = "Nancy", LastName = "Job", EmployeeId = 1 });
                employees.Add(new Employee() { FirstName = "Andrew", LastName = "Job", EmployeeId = 2 });
                employees.Add(new Employee() { FirstName = "Janet", LastName = "Job", EmployeeId = 3 });
                employees.Add(new Employee() { FirstName = "Janet", LastName = "Nancy", EmployeeId = 4 });
                employees.Add(new Employee() { FirstName = "Janet", LastName = "Andrew", EmployeeId = 5 });
                employees.Add(new Employee() { FirstName = "Janet", LastName = "Janet", EmployeeId = 6 });
                employees.Add(new Employee() { FirstName = "Joe", LastName = "Jim", EmployeeId = 7 });
                employees.Add(new Employee() { FirstName = "Joe", LastName = "And", EmployeeId = 8 });
                employees.Add(new Employee() { FirstName = "Joe", LastName = "Sally", EmployeeId = 9 });
                employees.Add(new Employee() { FirstName = "Andrew", LastName = "Job", EmployeeId = 10 });

                //List<Employee> name = new List<Employee>();

                //foreach (Employee joe in employees)
                //{
                //    if (joe.FirstName == "Joe")
                //    {
                //        name.Add(joe);
                //        Console.WriteLine(joe.FirstName);
                //    }
                //}

                ////add foreach to verify joe worked
                //foreach (Employee joe in employees)
                //{
                //    if (joe.FirstName == "Joe")
                //    {
                //        name.Add(joe);
                //        Console.WriteLine(joe.FirstName + " " + joe.LastName);
                //    }
                //}
                //Console.Read();




                List<Employee> empList = employees.Where(employee => employee.FirstName == "Joe").ToList();
               
                foreach (Employee joe in empList)
                {
                    Console.WriteLine(joe.FirstName + " " + joe.LastName);
                }



                List<Employee> idList = employees.Where(employee => employee.EmployeeId > 5).ToList();

                foreach (Employee joe in idList)
                {
                    Console.WriteLine(joe.FirstName + " " + joe.LastName + " " + joe.EmployeeId);
                }
            }


        }


    }
}
