using System;

namespace NUnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n1.Vending Machine");

            Console.WriteLine("Choose the Option: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    VendingMachine.ReadInput();
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
                
            }
        }
    }
}
