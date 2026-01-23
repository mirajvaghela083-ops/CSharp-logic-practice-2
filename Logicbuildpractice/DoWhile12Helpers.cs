namespace Logicbuildpractice
{
    internal static class DoWhile12Helpers
    {

        internal static void Menu()
        {
            int choice;
            do
            {
                Console.WriteLine(" # You can do multiple types of operation from the below menu !!\n");
                Console.WriteLine("\t\t\t \"MENU\"");
                Console.WriteLine(" 1. Add numbers ");
                Console.WriteLine(" 2. Subtract numbers ");
                Console.WriteLine(" 3. Find HCF ");
                Console.WriteLine(" 4. Exit \n");
                Console.WriteLine("NOTE : type number 0 when you want to get output\n\t you can put three number in hcf");

                Console.Write("\nEnter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DoWhile12.addNumbers();
                        break;

                    case 2:
                        DoWhile12.subNumbers();
                        break;
                    case 3:
                        DoWhile12.hcf();
                        break;
                    case 4:
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please select between 1 and 4.");
                        break;

                }
                if (choice != 4)
                {
                    Console.WriteLine("\nreturn to the menu");
                    Console.ReadLine();
                }


            } while (choice != 4);
    }
}