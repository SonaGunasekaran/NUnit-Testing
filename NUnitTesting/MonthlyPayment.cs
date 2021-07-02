using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTesting
{
    class MonthlyPayment
    {
        public static void ReadInput()
        {
            //Get input from user
            Console.WriteLine("Enter the Principal amount : ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Rate of interest : ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the number of years : ");
            double n = Convert.ToDouble(Console.ReadLine());
            MonthlyWage(p, r, n);
        }



        public static void MonthlyWage(double p, double r, double n)
        {


            // rate of interest and number of payments for monthly payments
            r /= 1200;
            n *= 12;

            //calcute payment
            double payment = (p * r) / (1 - Math.Pow(1 + r, n * -1));

            Console.WriteLine(payment);


        }
    }
}
    

