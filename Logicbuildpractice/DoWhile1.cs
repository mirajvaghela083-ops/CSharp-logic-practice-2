using System;
using System.Collections.Generic;
using System.Text;
// Print all numbers from 1 to 10.
namespace Logicbuildpractice
{
    internal class DoWhile1
    {
        internal static void printNum()
        {
            int i = 0;
            do
            {
                i++;
                Console.WriteLine(i);
            } while (i < 10);
        }
    }
}
