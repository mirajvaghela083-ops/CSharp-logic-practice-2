using System;
using System.Collections.Generic;
using System.Text;
// Reverse a given number
namespace Logicbuildpractice
{
    internal class DoWhile6
    {
        internal static void reverse()
        {
            Console.WriteLine("The number is :");
            int number = Convert.ToInt32(Console.ReadLine());

            int reverse = 0;

            do
            {
                int num = number % 10;
                reverse = reverse * 10 + num;
                number = number / 10;

            } while (number > 0);
            Console.WriteLine($"Reverse number is : {reverse}");
        }
    }
}
