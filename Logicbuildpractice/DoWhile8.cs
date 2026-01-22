using System;
using System.Collections.Generic;
using System.Text;
// Check whether a number is an Armstrong Number
namespace Logicbuildpractice
{
    internal class DoWhile8
    {
        internal static void armstrong()
        {
            Console.WriteLine("The number is :");
            int number = Convert.ToInt32(Console.ReadLine());

            double orignal = number;

            int temp = number ;

            double armstrong = 0;

            int count = 0;

            do
            {
                temp = temp / 10;
                count++;
            } while (temp > 0);

            temp = number ;

            do
            {
                int num = temp % 10;
                armstrong += Math.Pow(num, count);
                temp = temp / 10;

            } while (temp > 0);

            if (armstrong == orignal)

                Console.WriteLine($"it is armstrong number {armstrong}");
            else
                Console.WriteLine($"it is not an armstrong number {armstrong}");


        }
    }
}
