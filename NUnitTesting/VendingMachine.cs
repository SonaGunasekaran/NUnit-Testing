using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTesting
{
    class VendingMachine
    {
        public static void ReadInput()
        {
            //Get the input from user
            Console.WriteLine("Enter the amount : ");
            int amount = Convert.ToInt32(Console.ReadLine());
            CountCurrency(amount);

        }

        public static void CountCurrency(int amount)
        {
            int[] notes = new int[] { 2000, 500, 200, 100, 50, 20, 10, 5, 1 };
            int[] noteCounter = new int[9];

            // counting notes
            for (int i = 0; i < 9; i++)
            {
                if (amount >= notes[i])
                {
                    noteCounter[i] = amount / notes[i];
                    amount = amount - noteCounter[i] * notes[i];
                }
            }

            // Printing notes
            Console.WriteLine("Currency Count ");
            for (int i = 0; i < 9; i++)
            {
                if (noteCounter[i] != 0)
                {
                    Console.WriteLine(notes[i] + " : "
                        + noteCounter[i]);
                }
            }
        }

    }
}
