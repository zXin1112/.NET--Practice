using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while循环练习2
{
    class Program
    {
        static void Main(string[] args)
        {
            //求1—100所有整数的和
            int n = 1;
            int sum = 0;
            while (n<=100)
            {
                sum += n;
                n++;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
