/*
Name: Sasa Subotic
Date: 9/17/2019
Class: ISM 4300
Project Name: Deliverable 3, Arrays
*/

using System;

namespace Deliverable_3_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Changes color of the console and adds a date and time.
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("System Date/Time: " + DateTime.Now + Environment.NewLine);

            // Manually populated array below
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            Console.WriteLine("The value is 25 in element #25 of the array.");
            Console.WriteLine("Executing array below, please wait:");
            Console.WriteLine("__________________________________________________________________________");
            Console.WriteLine("");

            // The foreach loop allows the loop to use the values inputted manually in the array
            foreach (int i in numbers)
            {
                Console.Write("Element value = " + i + Environment.NewLine);
            }
            // End of the program, allows user to click to exit.
            Console.WriteLine("");
            Console.WriteLine("__________________________________________________________________________");
            Console.WriteLine("Execution complete...");
            Console.WriteLine("Press any key to exit the program ..");
            Console.ReadKey(true);
        }
    }
}
