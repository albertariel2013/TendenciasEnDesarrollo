using System;

namespace RomanN_p1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Idea: convertir el integer input en un string. 
             * Luego convertir ese string en un array de caracteres para operar sobre ellos.
             * 
             * problema>
             * identificar cuando se esta restando y cuanto
             * I = 1
             * X = 10
             * L = 50
             * C = 100
             * D = 500
             * M = 1000
             * 
             * 
             * */

            //Prueba 1
            /*  n = 51
             * Output esperado: LI
             * Output:
             * 
             * */
            //Prueba 2
            /*  n = 123
             * Output esperado: CXXIII
             * Output: CXXIII
             * 
             * */
            //Prueba 3
            /*  n = 630
             * Output esperado: DCXXX
             * Output: DCXXX
             * 
             * */
            int n = 630;
            string num = n.ToString();
            char[] digits = num.ToCharArray();
            string answer = "";
            int Length = digits.Length;

            for (int i  = 0; i < digits.Length; i++, Length--)
            {

                if (Length == 3)    //number is 3 digits long
                {
                    switch (digits[i])
                    {
                        case '1':
                            answer += "C";
                            break;
                        case '2':
                            answer += "CC";
                            break;
                        case '3':
                            answer += "CCC";
                            break;
                        case '4':
                            answer += "CD";
                            break;
                        case '5':
                            answer += "D";
                            break;
                        case '6':
                            answer += "DC";
                            break;
                        case '7':
                            answer += "DCC";
                            break;
                        case '8':
                            answer += "DCCC";
                            break;
                        case '9':
                            answer += "CM";
                            break;
                    }
                }

                if (Length == 2)    //the number is 2 digits long
                {
                    switch (digits[i])
                    {
                        case '1':
                            answer += "X";
                            break;
                        case '2':
                            answer += "XX";
                            break;
                        case '3':
                            answer += "XXX";
                            break;
                        case '4':
                            answer += "XL";
                            break;
                        case '5':
                            answer += "L";
                            break;
                        case '6':
                            answer += "LX";
                            break;
                        case '7':
                            answer += "LXX";
                            break;
                        case '8':
                            answer += "LXXX";
                            break;
                        case '9':
                            answer += "XC";
                            break;
                    }


                }

                if (Length == 1)
                {
                    switch (digits[i])
                    {
                        case '1':
                            answer += "I";
                            break;
                        case '2':
                            answer += "II";
                            break;
                        case '3':
                            answer += "III";
                            break;
                        case '4':
                            answer += "IV";
                            break;
                        case '5':
                            answer += "V";
                            break;
                        case '6':
                            answer += "VI";
                            break;
                        case '7':
                            answer += "VII";
                            break;
                        case '8':
                            answer += "VIII";
                            break;
                        case '9':
                            answer += "IX";
                            break;
                    }
                }

            }
            Console.WriteLine(answer);
            Console.ReadLine();

        }
    }
}
