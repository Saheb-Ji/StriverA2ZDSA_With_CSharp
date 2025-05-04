using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StriverA2ZDSA_CSharp.LearnTheBasics
{
    public class InputOutput
    {
        public void InputOutputMet()
        {
            Console.WriteLine("Enter num: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered: " + num);
        }

    }
}
