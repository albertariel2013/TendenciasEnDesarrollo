using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kata_S7_p1
{
    public class Rack
    {
        public List<int> numbers = new List<int>();
        public int[] Add(int x)
        {
            
            this.numbers.Add(x);
            if (numbers.Count == 0)
                return null;
            int[] A = numbers.ToArray();

            if(A.Length == 1)
            {
                return A;
            }
            

            for(int i = 0; i < A.Length -1; i++)
            {
                if (A[i] > A[i + 1])
                {
                    Swap(ref A, i, i + 1);
                }
            }

            return A;
        }


        public void Swap(ref int[] A, int a, int b)
        {
            int x = A[a];
            int y = A[b];
            A[a] = y;
            A[b] = x;
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
