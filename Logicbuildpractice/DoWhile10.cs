using System;
using System.Collections.Generic;
using System.Text;
//Print the Fibonacci Series up to required terms
namespace Logicbuildpractice
{
    internal class DoWhile10
    {
        internal static void fibonacci()
        {
            Console.WriteLine("The number is : ");
            int number = Convert.ToInt32(Console.ReadLine());

            long first = 0;
            long second = 1;
            long count = 0;

            do
            {
                long next = first + second;
                first = second;
                second = next;
                count++;

                Console.WriteLine(first + " ");
            } while (count < number );
          
        }
    }
}
