﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a temperature input type: \n" +
                "1. Celsius.\n" +
                "2. Fahrenheit.\n" +
                "3. Reaumur.\n" +
                "4. Kelvin.");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Enter a temperature in Celcius: ");
                    double celciusTemp = Convert.ToDouble(Console.ReadLine());
                    CelciusConverter(celciusTemp);
                    break;
                case "2":
                    Console.Write("Enter a temperature in Fahrenheit: ");
                    double fahrenheitTemp = Convert.ToDouble(Console.ReadLine());
                    FahrenheitConverter(fahrenheitTemp);
                    break;
                case "3":
                    Console.Write("Enter a temperature in Reaumur: ");
                    double reaumurTemp = Convert.ToDouble(Console.ReadLine());
                    ReaumurConverter(reaumurTemp);
                    break;
                case "4":
                    Console.Write("Enter a temperature in Kelvin: ");
                    double kelvinTemp = Convert.ToDouble(Console.ReadLine());
                    KelvinConverter(kelvinTemp);
                    break;
                default:
                    Console.Write("Enter a valid number between 1 and 4.");
                    break;
            }
            Console.ReadLine();
        }

        public static void CelciusConverter(double temp)
        {
            double fahrenheit = temp * 9 / 5 + 32;
            double kelvin = temp + 273.15;
            double reaumur = temp * 4 / 5;
            Console.WriteLine(temp + " Celcius converted -");
            Console.WriteLine("Fahrenheit: {0}", fahrenheit);
            Console.WriteLine("Kelvin: {0}", kelvin);
            Console.WriteLine("Reaumur: {0}", reaumur);
        }
    }
    }
}
