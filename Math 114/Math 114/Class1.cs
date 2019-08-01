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



        public int Divide(double num3)
        {
            int result = Convert.ToInt32(num3 + 5);

            return result;
        }


        public int Divide(string num3)
        {
            int i = Convert.ToInt32(num3);
            int result = i * 5;

            return result;
        }















    }
}
