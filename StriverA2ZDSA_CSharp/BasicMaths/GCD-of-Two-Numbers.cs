using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//GCD of Two Numbers
//You are given two integers n1 and n2. You need find the Greatest Common Divisor (GCD) of the two given numbers. Return the GCD of the two numbers.

//The Greatest Common Divisor (GCD) of two integers is the largest positive integer that divides both of the integers.

//Examples:
//Input: n1 = 4, n2 = 6

//Output: 2

//Explanation: Divisors of n1 = 1, 2, 4, Divisors of n2 = 1, 2, 3, 6

//Greatest Common divisor = 2.


namespace StriverA2ZDSA_CSharp.BasicMaths
{
    internal class GCD_of_Two_Numbers
    {
        public int GCD(int n1, int n2)
        {
            // Base case
            if (n2 == 0)
                return n1;
            return GCD(n2, n1 % n2);
        }
    }
}
