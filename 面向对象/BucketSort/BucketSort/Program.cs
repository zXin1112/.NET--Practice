using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sp = new Stopwatch();
           
            int[] x = { 12, 23, 43, 56, 78,  74 };
            sp.Start();
            var stor = bucket(x, 78);
            sp.Stop();
            for (int i = 0; i < stor.Length; i++)
            {
                if (stor[i] > 0)
                    Console.WriteLine(stor[i]);
            }
            Console.WriteLine(sp.Elapsed);
            sp.Reset();
            sp.Start();
             stor = maopao(x);
            sp.Stop();
            for (int i = 0; i < stor.Length; i++)
            {
                if (stor[i] > 0)
                    Console.WriteLine(stor[i]);
            }

           
            Console.WriteLine(sp.Elapsed);
            Console.ReadKey();
        }
        static int[] bucket(int[] unSorted, int MaxNumber)
        {
            int[] sorted = new int[MaxNumber + 1];
            for (int i = 0; i < unSorted.Length; i++)
            {
                sorted[unSorted[i]] = unSorted[i];
            }
            return sorted;
        }
        static int [] maopao(int[] unSorted)
        {
            for (int i = 0; i < unSorted.Length-1; i++)
            {
                for (int j = 0; j < unSorted.Length-i-1; j++)
                {
                    if (unSorted[j] > unSorted[j + 1])
                    {
                        int temp = unSorted[j];
                        unSorted[j] = unSorted[j+1];
                        unSorted[j + 1] = temp;
                    }
                }
            }
            return unSorted;
        }
    }
}
