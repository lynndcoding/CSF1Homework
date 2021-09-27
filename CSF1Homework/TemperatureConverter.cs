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

            //THIS SECTION IS FOR THE MENU: ONLY 2 CHOICES
            //int userInput = Console.ReadLine();
            //ConsoleKey userInput = Console.ReadKey(true).Key;


            //Do While ALWAYS runs once. It's BEST for menus!
            Console.WriteLine("Please select from the following menu:");
            string userInput = Console.ReadLine().ToLower();

            //bool repeat = true;//They want to use our program.

            do
            {
                Console.WriteLine("A) Convert Celsius to Fahrenheit\nB) Convert Fahrenheit to Celsius\n");
                switch (userInput)
                {
                    case "a":
                        Console.WriteLine("A) Convert Celsius to Fahrenheit\n\n");
                        break;

                    case "b":
                        Console.WriteLine("B) Convert Fahrenheit to Celsius\n\n");
                        //stop the loop
                        //(userInput != " ");//UPDATE
                        break;
                    default:
                        Console.WriteLine("That was not a valid option.\n ");
                        break;
                }//end switch

            } while (userInput != " ");//repeat is the CONDITION.

        }//end Main()
    }//end class
}//end namespace
