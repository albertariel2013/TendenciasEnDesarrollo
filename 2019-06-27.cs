using System;

namespace word_wrap_p2
{

    public class Wrapper
    {

        public string Wrap(string input, int pos)
        {

            //Problem is how to count words in a string
            
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {

                if(input[i] == ' ')
                {
                    counter = 0;
                }

                else
                {
                    if(counter >= pos)
                    {
                        input = input.Insert(i, " ");
                        counter = -1;
                    }
                      counter++;

                }
            }

            return input;


        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Wrapper newwrap = new Wrapper();
            //newwrap.Wrap("bf", 1);

            //test2 porque se bugeo mi nunit

            Console.WriteLine(newwrap.Wrap("Hello World", 3));
        }
    }
}
