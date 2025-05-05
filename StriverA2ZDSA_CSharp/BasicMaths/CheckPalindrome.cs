using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StriverA2ZDSA_CSharp.BasicMaths
{
    internal class CheckPalindrome
    {
        public bool IsPalindrome(int n)
        {
            if (n < 0)
                return false;
            int temp = n;
            int rev = 0;
            while (n > 0)
            {
                int digit = n % 10;
                rev = rev * 10 + digit;
                n /= 10;
            }
            if (temp == rev)
                return true;
            else
                return false;
        }
    }
}
