using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_calc_p2
{

    public class Calculator
    {
        public string Add(string input)
        {
            if (input == "")
                return "0";

            else if (input.Length == 1)
            {
                return input;
            }

            string[] splitinput = input.Split(',', '\n');
            int sum = 0;
            if (input.EndsWith(",") == true)
                return "input not valid";
            for (int i = 0; i < splitinput.Length; i++)
            {
                sum += Int32.Parse(splitinput[i]);
            }

            return sum.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
