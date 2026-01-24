using System;
using System.Collections.Generic;
using System.Text;
// Find the sum of digits of a given number
namespace Logicbuildpractice
{
    internal class DoWhile13
    {
        internal static void sumOfNumber()
        {
            Console.WriteLine("The number is :");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            do
            {
                int num = number % 10;
                sum += num;
                number = number / 10;


            } while (number > 0);
            Console.WriteLine($"the sum of given digit is {sum}");
                
        }
    }
}
