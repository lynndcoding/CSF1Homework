using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class CSF1HomeworkATM
    {
        static void Main(string[] args)
        {

            Console.Title = "-====== Homework: ATM Application ======-";//names the Console Window
            Console.WriteLine("ATM Application");
            Console.Write("---------------------------------\n");

            int acctNumber = 9, acctCompare, pinNumber = 2, pinCompare, menuChoice;
            int startBalance = 5000, deposit, withdraw, runningBalance;

            Console.WriteLine("Please enter your account number: ");//request acct number from user
            acctCompare = int.Parse(Console.ReadLine());//read acctNumber

            if (acctCompare == acctNumber)
            {
                Console.WriteLine("Please enter your pin number: ");//if user enters correct acct number, ask for their pin
            }

            if (acctCompare != acctNumber)//compare account number from user, if not matching, start over
            {
                Console.WriteLine("Input not recognized. Please exit the program and start over.");//if user enters incorrect acct number, start over
            }

            pinCompare = int.Parse(Console.ReadLine());//read pinNumber
            if (pinCompare != pinNumber)//compare account number and pin number from user, if not matching, start over
            {
                Console.WriteLine("Input not recognized. Please exit the program and start over.");//if user enters incorrect pin number, start over
            }


            Console.WriteLine("Would you like to Make a Deposit, a Withdrawal or Check Your Account Balance? Y/N: ");
            ConsoleKey runProgram = Console.ReadKey(true).Key; //COUNTER

            while (runProgram == ConsoleKey.Y)
            {
                runProgram = Console.ReadKey(true).Key;

                if (pinCompare == pinNumber)//compare account number and pin number from user, if matching display menu options
                {
                    Console.WriteLine("Please select from the following options:");
                    Console.Write("---------------------------------\n");
                    Console.WriteLine("1) Make a Deposit");
                    Console.WriteLine("2) Make a Withdrawal");
                    Console.WriteLine("3) Check Account Balance");
                    Console.WriteLine("4) Exit Program");
                    menuChoice = int.Parse(Console.ReadLine());
                    switch (menuChoice)
                    {
                        case 1:
                            Console.WriteLine("Please enter the amount you are depositing.");
                            deposit = int.Parse(Console.ReadLine());
                            runningBalance = startBalance + deposit;
                            Console.WriteLine("Your previous balance was " + startBalance);
                            Console.WriteLine("You deposited " + deposit);
                            Console.WriteLine("Your current balance is now " + runningBalance);
                            break;

                        case 2:
                            Console.WriteLine("Please enter the amount you wish to withdraw.");
                            {
                                withdraw = int.Parse(Console.ReadLine());
                                if (startBalance >= withdraw)
                                {
                                    if (withdraw != 0)
                                    {
                                        Console.WriteLine("Please take the withdraw you requested totaling " + withdraw);
                                        runningBalance = startBalance - withdraw;
                                        Console.WriteLine("Your previous balance was " + startBalance);
                                        Console.WriteLine("You are withdrawing " + withdraw);
                                        Console.WriteLine("Your current balance is now " + runningBalance);
                                    }//end if modulus
                                }//end if balance > withdraw
                                else
                                    Console.WriteLine("Your account does not have a sufficient balance to withdraw " + withdraw);
                            }//end if withdraw
                            break;

                        case 3:
                            Console.WriteLine("The current balance in your account is " + startBalance);
                            break;

                        case 4:
                            Console.WriteLine("You have chosen to exit the program. Thank you for your business.");
                            break;
                        default:
                            Console.WriteLine("Input not recognized. Please select from the menu.");//if user does not enter correct acct or pin number, start over.
                            break;
                    }//end switch MenuChoice
                }//end ifCompare userInput
            }//end while continue
        }//end Main()
    }//end class
}//end namespace

