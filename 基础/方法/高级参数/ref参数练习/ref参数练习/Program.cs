using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref参数练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用方法交换两个变量的值
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            jiaohuan(ref  a,ref  b);
            Console .WriteLine ("交换后{0},{1}",a ,b );
            Console.ReadKey();
        }
        public static void jiaohuan(ref  int n1,ref  int n2)
        {
            n1 = n1 - n2;
            n2 = n1 + n2;
            n1 = n2 - n1;
        }
    }
}
