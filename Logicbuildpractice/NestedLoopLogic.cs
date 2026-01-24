using System;
using System.Collections.Generic;
using System.Text;
// Print the multiplication table for all numbers from 1 to 10 .
namespace Logicbuildpractice
{
    internal class NestedLoopLogic
    {
        internal static void multiplicationTable()
        {
            int number = 1;
            do
            {

                int i = 1;
                do
                {

                    int num = number * i;
                    Console.WriteLine($"{number} x {i} = {num}");
                    i++;
                } while (i <= 10);

                Console.WriteLine();
                number++;

            } while (number <= 10);

        }
    }
}
