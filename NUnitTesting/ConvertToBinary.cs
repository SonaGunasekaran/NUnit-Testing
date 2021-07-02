using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTesting
{
    class ConvertToBinary
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
			int[] bin = new int[32];
			int i = 0;
			while (num > 0)
			{
				bin[i] = num % 2;

				num /= 2;

				i++;

			}
			for (int j = i - 1; j >= 0; j--)
			{
				Console.Write(bin[j]);
			}

		}


	}
}
