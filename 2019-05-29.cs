using System;

namespace RomanN_p2
{
    class Program
    {
        static void Main(string[] args)     //Roman Numerals part 2
        {
            /*
             * Numbers:
             * I = 1;
             * V = 5;
             * X = 10;
             * L = 50;
             * C = 100;
             * D = 500;
             * M = 1000;
             * 
             * 
             * */

            //converting the number to a char array, so i can iterate over it
            int Number = 193;
            string i_example = Number.ToString();
            char[] digits = i_example.ToCharArray();

            //know how many digits does my number have.
            int nodigits = digits.Length;
            string answer = "";

            //iteration

            for (int i = 0; i < digits.Length; i++)
            {
                if (nodigits == 5)
                    Console.WriteLine("Invalid Number. Roman Numbers must be 4 digits long");

                if (nodigits == 4)  //max roman number is 4999
                {
                    switch (digits[i])
                    {
                        case  '1':
                            {
                                answer += "M";
                                nodigits--;
                                break;
                            }
                        case '2':
                            {
                                answer += "MM";
                                nodigits--;
                                break;
                            }
                        case '3':
                            {
                                answer += "MMM";
                                nodigits--;
                                break;
                            }
                        case '4':
                            {
                                answer += "MMMM";
                                nodigits--;
                                break;
                            }
                            
                    }
                    continue;
                
                }

                if(nodigits == 3)
                {
                    switch (digits[i])
                    {
                        case '1':
                            {
                                answer += "C";
                                nodigits--;
                                break;
                            }
                        case '2':
                            {
                                answer += "CC";
                                nodigits--;
                                break;
                            }
                        case '3':
                            {
                                answer += "CCC";
                                nodigits--;
                                break;
                            }
                        case '4':
                            {
                                answer += "CD";
                                nodigits--;
                                break;
                            }
                        case '5':
                            {
                                answer += "D";
                                nodigits--;
                                break;
                            }
                        case '6':
                            {
                                answer += "DC";
                                nodigits--;
                                break;
                            }
                        case '7':
                            {
                                answer += "DCC";
                                nodigits--;
                                break;
                            }
                        case '8':
                            {
                                answer += "DCCC";
                                nodigits--;
                                break;
                            }
                        case '9':
                            {
                                answer += "CM";
                                nodigits--;
                                break;
                            }
                            
                    }
                    continue;
                }

                if (nodigits == 2)
                {
                    switch (digits[i])
                    {
                        case '1':
                            {
                                answer += "X";
                                nodigits--;
                                break;
                            }
                        case '2':
                            {
                                answer += "XX";
                                nodigits--;
                                break;
                            }
                        case '3':
                            {
                                answer += "XXX";
                                nodigits--;
                                break;
                            }
                        case '4':
                            {
                                answer += "XL";
                                nodigits--;
                                break;
                            }
                        case '5':
                            {
                                answer += "L";
                                nodigits--;
                                break;
                            }
                        case '6':
                            {
                                answer += "LX";
                                nodigits--;
                                break;
                            }
                        case '7':
                            {
                                answer += "LXX";
                                nodigits--;
                                break;
                            }
                        case '8':
                            {
                                answer += "LXXX";
                                nodigits--;
                                break;
                            }
                        case '9':
                            {
                                answer += "XC";
                                nodigits--;
                                break;
                            }
                    }

                    continue;
                }

                if (nodigits == 1)
                {
                    switch (digits[i])
                    {
                        case '1':
                            {
                                answer += "I";
                                nodigits--;
                                break;
                            }
                        case '2':
                            {
                                answer += "II";
                                nodigits--;
                                break;
                            }
                        case '3':
                            {
                                answer += "III";
                                nodigits--;
                                break;
                            }
                        case '4':
                            {
                                answer += "IV";
                                nodigits--;
                                break;
                            }
                        case '5':
                            {
                                answer += "V";
                                nodigits--;
                                break;
                            }
                        case '6':
                            {
                                answer += "VI";
                                nodigits--;
                                break;
                            }
                        case '7':
                            {
                                answer += "VII";
                                nodigits--;
                                break;
                            }
                        case '8':
                            {
                                answer += "VIII";
                                nodigits--;
                                break;
                            }
                        case '9':
                            {
                                answer += "IX";
                                nodigits--;
                                break;
                            }
                    }
                    continue;
                }
            }



            //testing
            Console.WriteLine("The number {0} converted to Roman is: {1} ", Number, answer);
            Console.ReadKey();
        }
    }
}
