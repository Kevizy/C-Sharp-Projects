using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Fahrenheit_To_Celsius
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greets user
            Console.WriteLine("Convert Fahrenheit to Celsius.");

            Console.WriteLine("Enter degrees in fahrenheit:");
            // Sets value for todays high temperature 
            int degreesFahrenheit = int.Parse(Console.ReadLine());

            // Displays degrees fahrenheit to the console 
            Console.WriteLine("The temperature in fahrenheit is: {0}", degreesFahrenheit);

            // The formula to convert from fahrenheit to celsius is: (f-32)*5/9 

            // The numerator for the formula 
            int numerator = (degreesFahrenheit - 32) * 5;

            // The Denominator for the formula 
            int denominator = 9;

            // Divides the numerator and the denominator 
            int degreesCelsius = numerator / denominator;

            // Outputs degrees celsius to console 
            Console.WriteLine("The temperature in celsius is: {0}", degreesCelsius) ;


            // Tells user to press a key to terminate the console 
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine(); 
        }
    }
}
