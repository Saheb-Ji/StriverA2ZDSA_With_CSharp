using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StriverA2ZDSA_CSharp.BasicMaths
{
    internal class CountDigits
    {
        public void CountDigitsInNumber()
        {
            // Count the number of digits in a number
            Console.WriteLine("Enter a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (n > 0)
            {
                n /= 10;
                count++;
            }
            Console.WriteLine("Number of digits: " + count);
        }
    }
}
