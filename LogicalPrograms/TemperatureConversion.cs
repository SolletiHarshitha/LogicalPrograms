using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class TemperatureConversion
    {
        //Reading the input 
        public static void ReadInput()
        {
            Console.WriteLine("Enter the temperature in degrees : ");
            double temperature = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("To convert Temperature Choose an option");
            Console.WriteLine("1.Celsius to Fahrenheit");
            Console.WriteLine("2.Fahrenheit to Celsius");
            Console.WriteLine("Enter an option : ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    CelsiusToFahrenheit(temperature);
                    break;
                case 2:
                    FahrenheitToCelsius(temperature);
                    break;
            }
        }

        //Convert from celsius to fahrenheit
        private static void CelsiusToFahrenheit(double temperature)
        {
            double fahrenheit =(double) temperature * (9 / 5.0) + 32;
            Console.WriteLine("The temperature "+temperature+" celsius is converted to "+fahrenheit+" fahrenheit");
        }

        //Convert from fahrenheit to celsius
        private static void FahrenheitToCelsius(double temperature)
        {
            double celsius = (double) (temperature - 32) * (5 / 9.0);
            Console.WriteLine("The temperature "+temperature+" fahrenheit is converted to "+celsius+" celsius");
        }
    }
}
