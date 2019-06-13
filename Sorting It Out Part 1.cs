using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kata_S7_p1
{
    public class Rack
    {
        List<int> sortednumbers = new List<int>();
        public int[] Add(int input)
        {
            sortednumbers.Add(input);
            int[] sortedarray = sortednumbers.ToArray();
            
            for (int i = 0; i < sortedarray.Length -1; i++)
            {
                if (sortedarray[i] > sortedarray[i + 1])
                {
                    Swap(sortedarray, i, i++);
                }
            }
            //Esto ha sido todo por la kata de hoy, nos vemos en otra ocasion

            return sortedarray;
        }

        public void Swap(int[] A, int a, int b)
        {
            
            int x = A[b];
            int y = A[a];
            A[a] = x;
            A[b] = y;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Kata Sorting it out
        }
    }
}
