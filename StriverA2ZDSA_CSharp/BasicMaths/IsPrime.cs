using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StriverA2ZDSA_CSharp.BasicMaths
{
//Check for Prime Number
//You are given an integer n.You need to check if the number is prime or not.Return true if it is a prime number, otherwise return false.
//A prime number is a number which has no divisors except 1 and itself.
//Examples:
//Input: n = 5
//Output: true
//Explanation: The only divisors of 5 are 1 and 5 , So the number 5 is prime.
    internal class IsPrime
    {
        public bool isPrime(int n)
        {
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if(n%i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
