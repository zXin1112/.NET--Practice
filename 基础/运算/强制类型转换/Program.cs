using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 强制类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = 4.6;
            int a = (int)b; 
            Console.WriteLine("强制转换前{0}，强制转换后{1}", b, a);
            Console.ReadKey();                                                                                     
        }
    }
}
