using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 三元表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            //格式
            //表达式1？表达式2：表达式3；
            //例
            Console.WriteLine("请输入第一个数字");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个数字");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int a = n1 > n2 ? n1 : n2;
            Console.WriteLine("最大值为{0}",a );
            Console.ReadKey();
            
        }
    }
}
