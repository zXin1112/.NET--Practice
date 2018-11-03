using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //打印1000边我要细心
            int a = 0;
            while (a <1000)
            {
                Console.WriteLine("我要细心！\t{0}",a );
                a++;
            }
            Console.ReadKey();
        }
    }
}
