using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Reverse a number
//You are given an integer n. Return the integer formed by placing the digits of n in reverse order.


//Examples:
//Input: n = 25

//Output: 52

//Explanation: Reverse of 25 is 52.

namespace StriverA2ZDSA_CSharp.BasicMaths
{
    internal class Reverse_A_Number
    {
        public static void ReverseNumber()
        {
            Console.WriteLine("Enter a number to reverse:");
            int n = Convert.ToInt32(Console.ReadLine());
            int reversedNumber = 0;
            while (n > 0)
            {
                int digit = n % 10;
                reversedNumber = reversedNumber * 10 + digit;
                n /= 10;
            }
            Console.WriteLine("Reversed Number: " + reversedNumber);
        }
    }
}
