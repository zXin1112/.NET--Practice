using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace continue语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //continue语句，结束本次循环进入下一次循环
            //用while continue实现计算1-100（含）之间的除了能被7整除之外所有整数的和
            int sum = 0;
            int i = 1;
            while (i <=100)
            {
                if (i %7==0)
                {
                    i++;
                    continue;
                }
                sum = sum + i;
                i++;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
