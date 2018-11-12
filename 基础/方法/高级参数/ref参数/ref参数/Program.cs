using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //ref参数
            //在调用方法后，将一个变量带入方法中进行改变，改变完成后再将改变后的值带出方法
            //ref参数要求在方法外为其赋值，而方法内可以不赋值
            double n = 5000;
            jiaqian(ref  n);
            Console.WriteLine(n);
            Console.ReadKey();

        }
        public static void jiaqian(ref  double s)
        {
            s += 500;
        }
        public static void jianqian(double s)
        {
            s -= 500;
        }
    }
}
