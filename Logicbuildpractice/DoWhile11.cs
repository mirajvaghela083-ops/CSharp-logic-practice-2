using System;
using System.Collections.Generic;
using System.Text;
//   Find the HCF (Highest Common Factor) of given numbers
namespace Logicbuildpractice
{
    internal class DoWhile11
    {
        internal static void hcf()
        {
            Console.WriteLine("The number is : ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The number is : ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The number is : ");
            int number3 = Convert.ToInt32(Console.ReadLine());

            if (number <= 0 || number2 <= 0 || number3 <= 0)
            {
                Console.WriteLine("Please enter positive numbers only.");
                return;
            }

            int x = 1;
            int hcf = 1;
            do
            {
                if (number % x == 0 && number2 % x == 0 && number3 % x == 0)
                {
                    hcf = x;
                }
                x++;
            } while (x <= number && x <= number2 && x <= number3);
            Console.WriteLine(hcf);



        }
    }
}
