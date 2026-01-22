using System;
using System.Collections.Generic;
using System.Text;
// Check whether a number is a Palindrome .
namespace Logicbuildpractice
{
    internal class DoWhile7
    {
        internal static void palindrome()
        {
            Console.WriteLine("The number is : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int reverse = 0;
            int orginal = number;

            do
            {
                int num = number % 10;
                reverse = reverse * 10 + num;
                number = number / 10;

            } while (number > 0);

            if (reverse == orginal)
            
                Console.WriteLine($"it is palindrome {reverse}");
            
            else
                Console.WriteLine($"it is not palindrome {reverse}");

         
        }
    }
}
