using System;
using System.Collections.Generic;
namespace StringCalc__p1
{

  public class StringCalculator
    {
        public string Add(string input)
        {
            if (input == "")
            {
                return "0";
            }
            string[] operands = input.Split(',');

            if (operands.Length == 1)
            {
                return operands[0];
            }

            List<int> numbers = new List<int>();
            //how to add values in strings

            //Pendiente: how to add numbers with two digits
            for (int i = 0; i < operands.Length; i++)
            {
                if (operands[i] == "1")
                {
                    numbers.Add(1);
                }
                if (operands[i] == "2")
                {
                    numbers.Add(2);
                }
                if (operands[i] == "3")
                {
                    numbers.Add(3);
                }
                if (operands[i] == "4")
                {
                    numbers.Add(4);
                }
                if (operands[i] == "5")
                {
                    numbers.Add(5);
                }
                if (operands[i] == "6")
                {
                    numbers.Add(6);
                }
                if (operands[i] == "7")
                {
                    numbers.Add(7);
                }
                if (operands[i] == "8")
                {
                    numbers.Add(8);
                }
                if (operands[i] == "9")
                {
                    numbers.Add(9);
                }
            }

            int sum = 0;
            foreach (int numbr in numbers)
                sum += numbr;
            return sum.ToString();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
