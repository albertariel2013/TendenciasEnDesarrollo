using System;

namespace NumberInWord_P3
{
    class Program
    {
        public int Checkfollowing(string[] A, int j)
        {
            int i = j+1;

            if (A[i].ToLower() == "hundred")
            {
                string.
            }


            return 0;
        }
        static void Main(string[] args)
        {
            string TestCase = "Two Thousand One Hundred";
            string result = " ";
            string[] words = TestCase.Split(' ');
            
            foreach (string number in words)
            {
                Console.WriteLine(number);
            }

            for (int i = 0; i < words.Length; i++)
            {
                switch (words[i].ToLower())
                {
                    case "one":
                        result += "1";
                        break;
                    case "two":
                        result += "2";
                        break;
                    case "three":
                        result += "3";
                        break;
                    case "four":
                        result += "4";
                        break;
                    case "five":
                        result += "5";
                        break;
                    case "six":
                        result += "6";
                        break;
                    case "seven":
                        result += "7";
                        break;
                    case "eight":
                        result += "8";
                        break;
                    case "nine":
                        result += "9";
                        break;
                }
            }

            /*
             * 
             * 1) convertir el numero dado a un string. Convetir ese string en un arreglo de chars, y luego
             * descomponerlo para ver a que corresponde cada num
             * 
             * 2) descomponer el string con string.split(' ') y luego iterar sobre cada indice del array desde el inicio
             * Ver a que cifra corresponde y eso
             * */



            Console.ReadKey();
        }
    }
}
