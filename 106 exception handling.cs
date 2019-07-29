using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {


        //List<int> intList = new List<int>();
        //intList.Add(40);
        //intList.Add(10);

        //Console.WriteLine("Pick a number.");
        //int numberTwo = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Dividing numbers...");



        //for (int j = 0; j < intList.Count; j++)
        //{
        //    int numOne = intList[j] / numberTwo;
        //    Console.WriteLine(intList[j] + " divided by " + numberTwo + " equals " + numOne);
        //}


        //Console.ReadLine();

        //3.System.DivideByZeroException: 'Attempted to divide by zero.'
        //4. States error in debugging do I want to continue.
        //4. System.FormatException: 'Input string was not in a correct format.'


        try
        {
           List<int> intList = new List<int>();
        intList.Add(40);
        intList.Add(10);

        Console.WriteLine("Pick a number.");
        int numberTwo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dividing numbers...");



        for (int j = 0; j < intList.Count; j++)
        {
            int numOne = intList[j] / numberTwo;
            Console.WriteLine(intList[j] + " divided by " + numberTwo + " equals " + numOne);
        }


        Console.ReadLine();
        }    
        catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
            }
           catch (DivideByZeroException ex)//ex not used here, will use if want change to system message
            {
                Console.WriteLine("Please don't divide by zero.");
           }
           catch (Exception ex)
          {
               Console.WriteLine(ex.Message);
           }
          finally
          {
            Console.WriteLine("Program has emerged from the try/catch block and continued on with execution.");
                Console.ReadLine();
            }








    }
}
