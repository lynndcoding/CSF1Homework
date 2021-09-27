using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace CSF1Homework
{
    class CSF1Homework
    {
        static void Main(string[] args)
        {
            WriteLine("CSF1 Homework: Fruit Loops");
            Console.Title = "-====== CSF1 Homework: Fruit Loops ======-";//names the Console Window

            string[] fruits = { "apple", "orange", "pear", "banana", "plum", "kumquat" };
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine($"At the index of {i} is {fruits[i]}");
            }//for prices

            //TODO Finish This ONE!!
            //Repeat the FruitLoop1 Exercise, but for each of the fruit names that you display, on the next line display a number of periods that is equal to the number of the index of the array.
            //Example:
            // 'Apple'
            //  .//one period


        }//end Main()
    }//end class
}//end namespace
