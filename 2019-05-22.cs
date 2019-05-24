using System;

namespace NumbersInWord_p2
{
    class Program
    {
        static void Main(string[] args)
        {
            string conversion = "";
            string num = "0";
            int digits = num.Length;
            char[] Numbers = num.ToCharArray();

            for (int i = 0; i < Numbers.Length; i++)
            {
                if (digits == 2)
                {
                    switch (Numbers[i])
                    {
                        case '1':
                            if (Numbers[i + 1] == '1')
                            {
                                conversion += "Eleven ";
                                
                            }
                            else if (Numbers[i + 1] == '2')
                            {
                                conversion += "Twelve ";

                            }
                            else if (Numbers[i + 1] == '3')
                            {
                                conversion += "Thirteen ";

                            }
                            else if (Numbers[i + 1] == '4')
                            {
                                conversion += "Fourteen ";

                            }
                            else if (Numbers[i + 1] == '5')
                            {
                                conversion += "Fifteen ";

                            }
                            else if (Numbers[i + 1] == '6')
                            {
                                conversion += "Sixteen ";

                            }
                            else if (Numbers[i + 1] == '7')
                            {
                                conversion += "Seventeen ";

                            }
                            else if (Numbers[i + 1] == '8')
                            {
                                conversion += "Eighteen ";

                            }
                            else if (Numbers[i + 1] == '9')
                            {
                                conversion += "Nineteen ";

                            }
                            else {
                                conversion += "Ten ";
                            }
                            i = Numbers.Length;
                            
                            break;
                        case '2':
                            conversion += "Twenty ";
                            break;
                        case '3':
                            conversion += "Thirty ";
                            break;
                        case '4':
                            conversion += "Fourty ";
                            break;
                        case '5':
                            conversion += "Fifty ";
                            break;
                        case '6':
                            conversion += "Sixty ";
                            break;
                        case '7':
                            conversion += "Seventy ";
                            break;
                        case '8':
                            conversion += "Eighty ";
                            break;
                        case '9':
                            conversion += "Ninety ";
                            break;
                    }
                    digits--;
                }
                else {

                    switch (Numbers[i])
                    {
                        case '1':
                            conversion += "One ";
                            break;
                        case '2':
                            conversion += "Two ";
                            break;
                        case '3':
                            conversion += "Three ";
                            break;
                        case '4':
                            conversion += "Four ";
                            break;
                        case '5':
                            conversion += "Five ";
                            break;
                        case '6':
                            conversion += "Six ";
                            break;
                        case '7':
                            conversion += "Seven ";
                            break;
                        case '8':
                            conversion += "Eight ";
                            break;
                        case '9':
                            conversion += "Nine ";
                            break;
                    }
                    if (digits == 4)
                    {
                        conversion += "Thousand ";
                    }
                    else if (digits == 3)
                    {
                        conversion += "Hundred ";
                    }
                    else if (digits == 1)
                    {
                        if (Numbers[i] == 0)
                        {
                            conversion += "zero";
                        }
                        continue;
                    }
                    digits--;
                }
                
                
            }
            Console.WriteLine(conversion);
            Console.ReadLine();

        }
    }
}
