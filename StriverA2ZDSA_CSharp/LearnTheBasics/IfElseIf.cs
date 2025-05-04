using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StriverA2ZDSA_CSharp.LearnTheBasics
{
     public class IfElseIf
    {
        public void IfElseIfMet()
        {
            // Example of if-else if-else statement
            // This program checks the grade based on marks
            // and prints the corresponding grade.
            Console.WriteLine("Enter your marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks >= 90)
            {
                Console.WriteLine("Grade A");
            }
            else if (marks >= 70)
            {
                Console.WriteLine("Grade B");
            }
            else if (marks >= 50)
            {
                Console.WriteLine("Grade C");
            }
            else if (marks >= 35)
            {
                Console.WriteLine("Grade D");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
        
        
    }
}
