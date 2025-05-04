using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StriverA2ZDSA_CSharp.LearnTheBasics
{
    internal class SwitchCase
    {
        public void PrintDay()
        {
            Console.WriteLine("Enter Day: ");
            int day = Convert.ToInt32(Console.ReadLine());
            // Example of switch case statement
            // This program checks the day of the week
            // and prints the corresponding name of the day.
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
    }
}
