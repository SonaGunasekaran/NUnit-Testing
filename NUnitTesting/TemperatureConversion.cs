using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTesting
{
    class TemperatureConversion
    {
       
            public const int CELSIUS = 1;
            public const int FAREN = 2;
            public static void Convert()
            {
                int celsius, faren;

                Random random = new Random();
            //calling the Next() method
                int choice = random.Next(1, 3);

                switch (choice)
                {
                    case CELSIUS:

                        Console.WriteLine("Enter the Temperature in Celsius(°C) : ");

                        celsius = int.Parse(Console.ReadLine());
                    //Convert  Celsius to Fahrenheit
                    faren = (celsius * 9) / 5 + 32;

                        Console.WriteLine("Temperature in Fahrenheit is(°F) : " + faren);

                        break;
                    case FAREN:

                        Console.WriteLine("Enter the Temperature in Fahrenheit(°F) : ");

                        faren = int.Parse(Console.ReadLine());
                    //Convert Fahrenheit to Celsius
                    celsius = (faren - 32) * 5 / 9;

                        Console.WriteLine("the Temperature in Celsius is(°F) : " + celsius);
                        break;
                }
                

            }
        }
    }

