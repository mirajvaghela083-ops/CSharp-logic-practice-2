using System;
using System.Collections.Generic;
using System.Text;
// Print the multiplication table of a given number
namespace Logicbuildpractice
{
    internal class DoWhile2
    {
        internal static void multi()
        {
            Console.WriteLine("The number is :");
            int digit = Convert.ToInt32(Console.ReadLine());

            int i =  1 ;
            do
            {
                int multiplication = digit * i;             
                Console.WriteLine($"{digit} x {i} = {multiplication}");
                i++;
            } while (i <= 10);
           
        }
    }
}
