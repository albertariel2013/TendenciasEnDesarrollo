using System;
using System.Collections.Generic;
namespace Range_p2
{

    public class Container
    {
        public bool Contains(string Interval, string input1)
        {
            bool result = false;
            List<int> Elements = new List<int>();
            char[] CArray = Interval.ToCharArray();
            char[] CArray2 = input1.ToCharArray();

            char FirstDigit = CArray[1];
            char LastDigit = CArray[CArray.Length - 1];
            int LastNumber1;

            if(LastDigit == ')')
            {
                LastNumber1 = LastDigit - '0';
                LastNumber1 -= 1;
            }

            else    //lastnumber  = ]
            {
                LastNumber1 = LastDigit - '0';
                
            }

            char FirstDigit2 = CArray2[1];
            char LastDigit2 = CArray2[CArray2.Length - 1];
            int LastNumber2;

            if (LastDigit2 == ')')
            {
                LastNumber2 = LastDigit - '0';
                LastNumber2 -= 1;
            }

            else    //lastnumber  = ]
            {
                LastNumber2 = LastDigit - '0';

            }


            for(int i = FirstDigit; i <= LastNumber1; i++)
            {
                Elements.Add(i);
            }

            if (Elements.Contains(LastNumber2))
                result = true;

            return result;

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Container container = new Container();
            bool result = container.Contains("[2,6)", "[2,4]");
        }
    }
}
