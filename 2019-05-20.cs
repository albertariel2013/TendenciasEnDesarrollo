using System;

namespace NumbersInWord_p1
{
    class Program
    {
        static void Main(string[] args)
        {
            int testnumber = 12309;
            
            string testnum = testnumber.ToString();

            char[] Numbers = testnum.ToCharArray(0, testnum.Length);
            int digits = Numbers.Length;
            string answer = "";
            int idx = 0;

            for (int i = digits; i > 0; i--)
            {
                if (i == 5)
                {
                    switch (Numbers[idx])
                    {
                        case '1':
                            answer += "Diez";
                            break;
                        case '2':
                            answer += "veinte";
                            break;
                        case '3':
                            answer += "treinta ";
                            break;
                        case '4':
                            answer += "cuarenta ";
                            break;
                        case '5':
                            answer += "cincuenta ";
                            break;
                        case '6':
                            answer += "sesenta ";
                            break;
                        case '7':
                            answer += "setenta ";
                            break;
                        case '8':
                            answer += "ochenta ";
                            break;
                        case '9':
                            answer += "noventa ";
                            break;
                    }
                    answer += "mil ";
                    idx++;
                    continue;
                }
                if (i == 4)
                {
                    switch (Numbers[idx])
                    {
                        case '1':
                            answer += "mil ";
                            break;
                        case '2':
                            answer += "dos mil ";
                            break;
                        case '3':
                            answer += "tres mil ";
                            break;
                        case '4':
                            answer += "cuatro mil ";
                            break;
                        case '5':
                            answer += "cinco mil ";
                            break;
                        case '6':
                            answer += "seis mil ";
                            break;
                        case '7':
                            answer += "siete mil ";
                            break;
                        case '8':
                            answer += "ocho mil ";
                            break;
                        case '9':
                            answer += "nueve mil ";
                            break;
                    }
                    idx++;
                    continue;
                    
                }
                else if (i == 3)
                {
                    switch (Numbers[idx])
                    {
                        case '1':
                            answer += "ciento ";
                            break;
                        case '2':
                            answer += "doscientos  ";
                            break;
                        case '3':
                            answer += "trescientos ";
                            break;
                        case '4':
                            answer += "cuatrocientos ";
                            break;
                        case '5':
                            answer += "quinientos ";
                            break;
                        case '6':
                            answer += "seiscientos ";
                            break;
                        case '7':
                            answer += "setecientos ";
                            break;
                        case '8':
                            answer += "ochocientos ";
                            break;
                        case '9':
                            answer += "novecientos ";
                            break;
                    }
                    idx++;
                    continue;
                }
                else if (i == 2)
                {
                    switch (Numbers[idx])
                    {
                        case '1':
                            answer += "Diez";
                            break;
                        case '2':
                            answer += "veinte";
                            break;
                        case '3':
                            answer += "treinta ";
                            break;
                        case '4':
                            answer += "cuarenta ";
                            break;
                        case '5':
                            answer += "cincuenta ";
                            break;
                        case '6':
                            answer += "sesenta ";
                            break;
                        case '7':
                            answer += "setenta ";
                            break;
                        case '8':
                            answer += "ochenta ";
                            break;
                        case '9':
                            answer += "noventa ";
                            break;
                    }
                    idx++;
                    continue;
                }
                else if (i == 1)
                {
                    answer += "y ";
                    switch (Numbers[idx])
                    {
                        
                        case '1':
                            answer += "Uno";
                            break;
                        case '2':
                            answer += "Dos";
                            break;
                        case '3':
                            answer += "tres ";
                            break;
                        case '4':
                            answer += "cuatro ";
                            break;
                        case '5':
                            answer += "cinco ";
                            break;
                        case '6':
                            answer += "seis ";
                            break;
                        case '7':
                            answer += "siete ";
                            break;
                        case '8':
                            answer += "ocho ";
                            break;
                        case '9':
                            answer += "nueve ";
                            break;
                    }
                    idx++;
                    continue;
                }

            }

            Console.WriteLine(answer);

            Console.ReadLine();
        }
    }
}
