using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StriverA2ZDSA_CSharp.BasicMaths
{
    internal class ArmstrongNumber
    {
        //Check if the Number is Armstrong
        //You are given an integer n.You need to check whether it is an armstrong number or not.Return true if it is an armstrong number, otherwise return false.

        //An armstrong number is a number which is equal to the sum of the digits of the number, raised to the power of the number of digits.

        //Examples:
        //Input: n = 153
        //Output: true

        public bool IsArmstrong(int n)
        {
            int originalNumber = n;
            int sum = 0;
            int count = 0;
            // Count the number of digits
            while (n > 0)
            {
                n /= 10;
                count++;
            }
            n = originalNumber;
            // Calculate the sum of the digits raised to the power of the number of digits
            while (n > 0)
            {
                int digit = n % 10;
                sum += (int)Math.Pow(digit, count);
                n /= 10;
            }
            return sum == originalNumber;
        }
    }
}
