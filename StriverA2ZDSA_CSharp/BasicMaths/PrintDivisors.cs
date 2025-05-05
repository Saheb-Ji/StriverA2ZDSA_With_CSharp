using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StriverA2ZDSA_CSharp.BasicMaths
{
//Divisors of a Number
//You are given an integer n.You need to find all the divisors of n. Return all the divisors of n as an array or list in a sorted order.

//A number which completely divides another number is called it's divisor.

//Examples:
//Input: n = 6
//Output = [1, 2, 3, 6]

//Explanation: The divisors of 6 are 1, 2, 3, 6.
    internal class PrintDivisors
    {
        
        public void printDivisors(int n) {
            ArrayList list = new ArrayList();
            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    list.Add(i);
                }
                if (i != n / i)
                {
                    list.Add(n/i);
                }
            }
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
