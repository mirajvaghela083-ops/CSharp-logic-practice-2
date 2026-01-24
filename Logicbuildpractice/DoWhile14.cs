using System;
using System.Collections.Generic;
using System.Text;
//Calculate the sum of even digits and sum of odd digits separately
namespace Logicbuildpractice
{
    internal class DoWhile14
    {
        internal static void evenOdd()
        {
            Console.WriteLine("The number is : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int even = 0;
            int odd = 0;

            do
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                    even += digit;
                else
                    odd += digit;
                number = number / 10;
            } while (number != 0);
            Console.WriteLine(even);
            Console.WriteLine(odd);

        }   
    }
}
