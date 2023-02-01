/*
Author: Adil Kedir
Date: 1/26/23
Description: Console application to show even or odd numbers from selected value
*/


using System;
namespace Deliverable3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter an integer number between 1 and 100: ");
            try
            {
                int input = int.Parse(Console.ReadLine());

                Console.Write("Specify the series type: Even or Odd: ");
                string series = Console.ReadLine();

                if (series == "Odd")
                {
                    Console.Write("You have selected " + series + " series. The numbers between 0 and " + input + " are: ");
                    for (int i = 1; i < input; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }

                if (series == "Even")
                {
                    Console.WriteLine("You have selected " + series + " series. The number between 0 and " + input + " are: ");
                    for (int i = 0; i <= input; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }
            }// end of try
            catch
            {
                Console.WriteLine("Choose a number between 1 and 100");
            } // end of catch

        }
    }

    }

