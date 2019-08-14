using System;
using System.Collections.Generic;
using System.Text;

namespace _129_operation_overload
{
    public class Employee : Person
    {
        public int Id { get; set; }


        public static bool operator == (Employee emp1, Employee emp2)
        {

            bool isEqual;
            if (emp1.Id == emp2.Id)

            {
                isEqual = true;
            }
            else
            {
                isEqual = false;
            }
            return isEqual;
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {

            bool isEqual = false;
            if (emp1.Id != emp2.Id)
            {
                isEqual = true;
            }

            return isEqual;
        }
    }
}
