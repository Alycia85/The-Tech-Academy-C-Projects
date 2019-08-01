using System;
using System.Collections.Generic;
using System.Text;

namespace Math_114
{
    class Class1
    {

        public int Divide(int num3)
        {
            int result = num3 / 5;

            return result;
        }



        public int Divide(double num1)
        {
            int result = Convert.ToInt32(num1 + 5);

            return result;
        }


        public int Divide(string num2)
        {
            int i = Convert.ToInt32(num2);
            int result = i * 5;

            return result;
        }















    }
}
