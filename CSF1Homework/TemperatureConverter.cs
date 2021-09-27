using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class TemperatureConverter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CSF1 Homework: Temperature Converter");
            Console.Title = "-====== CSF1 Homework: Temperature Converter ======-";//names the Console Window

            Console.WriteLine("Please enter a temperature in degrees celsius: ");
            double celsiusTemp = double.Parse(Console.ReadLine());
            double celsTofahr = (celsiusTemp * (9.0 / 5.0) + 32);

            Console.WriteLine("Please enter a temperature in degrees fahrenheit: ");
            double fahrenheitTemp = double.Parse(Console.ReadLine());
            double fahrTocels = (fahrenheitTemp - 32) / (9.0 / 5.0);

            Console.WriteLine("Would you like to see the conversions? Y/N:");
            ConsoleKey runProgram = Console.ReadKey(true).Key; //COUNTER

            while (runProgram == ConsoleKey.Y)
            {
                runProgram = Console.ReadKey(true).Key;
                Console.WriteLine("Please select from the following options:\nA) Convert Celsius to Fahrenheit\n B) Convert Fahrenheit to Celsius\n");
                string menuChoice = Console.ReadLine().ToLower();

                switch (menuChoice)
                {
                    case "a":
                        Console.WriteLine(" You entered " + celsiusTemp + " degrees celsius." +
                           "This converts to a temperature of " + celsTofahr + " degrees Fahrenheit\n\n");
                        break;

                    case "b":
                        Console.WriteLine("B) Convert Fahrenheit to Celsius\n\n");
                        Console.WriteLine(" You entered " + fahrenheitTemp + " degrees fahrenheit." +
                           "This converts to a temperature of " + fahrTocels + "degrees celsius\n\n");
                        break;

                    default:
                        Console.WriteLine("That was not a valid option. ");
                        break;
                }//end switch
            }//end while
        }//end Main()
    }//end class
}//end namespace
