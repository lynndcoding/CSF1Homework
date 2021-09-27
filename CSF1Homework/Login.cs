using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class WarmupExerciseLogin
    {
        static void Main(string[] args)
        {
            Console.Title = "-====== Homework Exercise: Login ======-";//names the Console Window
            Console.WriteLine("Login");
            Console.Write("---------------------------------\n");


            Console.WriteLine("Enter your account number: ");
            int acctNumber = int.Parse(Console.ReadLine());

            switch (acctNumber)
            {
                case 9:
                    Console.WriteLine("You entered " + acctNumber + " as your account number.");
                    Console.WriteLine("That is correct!");
                    break;


                default:
                    Console.WriteLine("You entered " + acctNumber + " as your account number.");
                    Console.WriteLine("That is incorrect. Please restart the program, and try again.");
                    break;
            }//end switch

            if (acctNumber == 9)
                Console.WriteLine("Enter your pin number: ");
            int pinNumber = int.Parse(Console.ReadLine());

            switch (pinNumber)
            {
                case 2:
                    Console.WriteLine("You entered " + pinNumber + " as your pin number.");
                    Console.WriteLine("That is correct!");
                    break;

                default:
                    Console.WriteLine("You entered " + pinNumber + " as your pin number.");
                    Console.WriteLine("That is incorrect. Please restart the program, and try again.");
                    break;
            }//end switch
        }//end Main()
    }//end class
}//end namespace

