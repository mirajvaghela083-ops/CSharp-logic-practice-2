using System;
using System.Collections.Generic;
using System.Text;
// Count how many positive numbers were entered before a negative number
namespace Logicbuildpractice
{
    internal class DoWhile15
    {
        internal static void countPositive()
        {
            int number;
            int count = 0;
            do
            {
                Console.WriteLine("Enter the numbers :");
                number = Convert.ToInt32(Console.ReadLine());

               
                if (number > 0)
                count++;

                
            } while (number >= 0);
            Console.WriteLine($"The count is {count}");
        }

    }
}
