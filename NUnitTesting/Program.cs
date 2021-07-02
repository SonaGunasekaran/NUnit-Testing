using System;

namespace NUnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n1.Vending Machine\n2.Day Of Week\n3.TemperatureConversion");

            Console.WriteLine("Choose the Option: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    VendingMachine.ReadInput();
                    break;
                case 2:
                    DayOfWeek.ReadInput();
                    break;
                case 3:
                    TemperatureConversion.Convert();
                    break;

                default:
                    Console.WriteLine("Exit");
                    break;
                
            }
        }
    }
}
