using System;

namespace RomanN_p3
{

  
    public class CustomConverter
    {
        public string Convert(string number)
        {
            if (number == "")
            {
                return "";
            }

            for (int i = number.Length; i > 0 ; i--)
            {
                if (number.Length == 1)
                {
                    if (number == "1")
                        return "I";
                    if (number == "2")
                        return "II";
                    if (number == "3")
                        return "III";
                    if (number == "4")
                        return "IV";
                    if (number == "5")
                        return "V";
                    if (number == "6")
                        return "VI";
                    if (number == "7")
                        return "VII";
                    if (number == "8")
                        return "VIII";
                    if (number == "9")
                        return "IX";
                }

                if (number.Length == 2)
                {
                    if (number == "1")
                        return "X";
                    if (number == "2")
                        return "XX";
                    if (number == "3")
                        return "XXX";
                    if (number == "4")
                        return "XL";
                    if (number == "5")
                        return "L";
                    if (number == "6")
                        return "LX";
                    if (number == "7")
                        return "LXX";
                    if (number == "8")
                        return "LXXX";
                    if (number == "9")
                        return "XC";
                }
            }
            
            return null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kjnjHello World!");
        }

    }

}
