using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace MadLib
{
    class MadLib
    {
        static void Main(string[] args)
        {
            WriteLine("CSF1 Homework: Mad Lib");
            Console.Title = "-====== CSF1 Homework: Mad Lib ======-";//names the Console Window
            Console.WriteLine("Please enter the information below as requested: ");
            Console.WriteLine("Enter your first noun (a person, place, or thing: ");
            string noun1 = Console.ReadLine();
            Console.WriteLine("Enter your first verb in PAST TENSE (i.e. swam, ran, played): ");
            string verb1 = Console.ReadLine();
            Console.WriteLine("Enter your first adjective (words that modify verbs (i.e. soon, swiflty, etc): ");
            string adjective1 = Console.ReadLine();
            Console.WriteLine("Enter another noun - PLURAL this time (people, places, or things: ");
            string noun2 = Console.ReadLine();
            Console.WriteLine("Enter another verb in standard PRESENT TENSE (i.e. swim, run, play): ");
            string verb2 = Console.ReadLine();
            Console.WriteLine("Enter another adjective (words that modify verbs (i.e. truly, madly, deeply, etc): ");
            string adjective2 = Console.ReadLine();
            Console.WriteLine("Enter another noun (a person, place, or thing: ");
            string noun3 = Console.ReadLine();
            Console.WriteLine("Enter another verb in standard PRESENT TENSE (i.e. swim, run, play): ");
            string verb3 = Console.ReadLine();
            Console.WriteLine("Enter another adjective (words that modify verbs (i.e. truly, madly, deeply, etc): ");
            string adjective3 = Console.ReadLine();


            Console.WriteLine($"I was going to be rich! I had just invented the world's first computerized {noun1}! I built it out of old {noun2}. The first time I {verb1} it on, it worked {adjective1}. I couldn't believe it! I was going to be {adjective2} rich! The next time I {verb2}, the {noun1} started to {verb3} quite {adjective3} . Looks like I'll have to keep my day {noun3}.  ");
        }//end Main()
    }//end class
}//end namespace