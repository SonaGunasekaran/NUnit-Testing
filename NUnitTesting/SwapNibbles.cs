using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTesting
{
    class SwapNibbles
    {
        public static void ReadInput()
        {
            //Get the input from user
            Console.WriteLine("Enter the decimal Number : ");
            int decNum = Convert.ToInt32(Console.ReadLine());
            ToBinary(decNum);
        }

        public static void ToBinary(int num)
        {
            // Swapping Nibbles using shift operation
            int bin = ((num & 0x0F) << 4 | (num & 0xF0) >> 4);
            Console.WriteLine(PowerOfTwo(bin));
        }
        //Check power of Two
        static bool PowerOfTwo(int bin)
        {
            if (bin == 0)
                return false;

            while (bin != 1)
            {
                if (bin % 2 != 0)
                    return false;

                bin = bin / 2;
            }
            return true;
        }
    }
}
