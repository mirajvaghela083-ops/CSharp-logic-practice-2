using System;
using System.Collections.Generic;
using System.Text;
// Keep taking numbers until 0 is entered, then print the largest number
namespace Logicbuildpractice
{
    internal class DoWhile4
    {
        internal static void largestNum()
        {
            int number;
            int largest = int.MinValue;
            do
            {
                Console.WriteLine("The number is :");
                number = Convert.ToInt32(Console.ReadLine());

                if(number != 0 && number > largest)
                {
                    largest = number;
                }

            } while (number != 0);
            Console.WriteLine(largest);
        }
    }                                                               
}
