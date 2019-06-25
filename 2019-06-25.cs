using System;

namespace Word_Wrap_p1
{

    public class Wrapper
    {

        public string Wrap (string input, int idx)
        {
            string word1 = input;
            int counter = 0;
            string newstring = input;

            for (int i = 0; i < input.Length; i++)
            {
                if (word1[i] == '\n')
                {
                    if (counter >= idx)
                    {
                        newstring = input.Insert(idx, " ");
                    }
                    counter = 0;
                }
                else
                {
                    counter += 1;
                }
                
            }


             

            return newstring;
            
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
