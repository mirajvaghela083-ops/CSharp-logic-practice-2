using System;
using System.Collections.Generic;
using System.Text;
// Keep taking numbers until 0 is entered, then print the sum of all entered numbers
namespace Logicbuildpractice
{
    internal class DoWhile3
    {
        internal static void sum()
        {
            int number;
            int sum = 0;
            do
            {
                Console.WriteLine("The number is :");
                number = Convert.ToInt32(Console.ReadLine());

                sum = sum + number;


            } while (number != 0 );

            if(number == 0)
            {
                Console.WriteLine(sum);
            }
        }
    }
}
