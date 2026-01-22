using System;
using System.Collections.Generic;
using System.Text;
// Count and print the number of digits in a given number
namespace Logicbuildpractice
{
    internal class DoWhile5
    {
        internal static void count()
        {
            Console.WriteLine("the number is :");
            int num = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            do
            {
                 num = num / 10;
            count++;
               
            } while (num > 0);
            Console.WriteLine(count);
        }
    }
}
