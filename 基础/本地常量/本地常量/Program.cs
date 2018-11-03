using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 本地常量
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1415926;//它指定字段或局部变量的值是常数，不能被修改


            double yuan = 2 * 2 * PI;
            Console.WriteLine(yuan);
            Console.ReadKey();
        }
    }
}
