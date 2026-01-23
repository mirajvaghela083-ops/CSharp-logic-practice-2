using System;
using System.Collections.Generic;
using System.Text;
//  Calculate the Factorial of a given number
namespace Logicbuildpractice
{
    internal class DoWhile9
    {
        internal static void fact()
        {
            Console.WriteLine("The number is : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int i = 1;

            int fact = 1;

            do
            {
                fact = fact * i;
                i++;
            } while (i <= number);
            Console.WriteLine(fact);
        }
    }
}
