using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习1
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入5个人的年龄并计算平均年龄
            //如果录入的数据出现负数或大于100的数，立即停止输入并报错
            int b = 0;
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("请输入第{0}个人的年龄", i);
                int a = Convert.ToInt32(Console.ReadLine());
                if (a <= 0 || a > 100)
                {
                    Console.WriteLine("输入有误，程序停止");
                    break;
                }
                else //此时0<a<100
                {
                    b += a;
                }
                if (i == 5)
                {
                    Console.WriteLine("这五个人的平均年龄为{0}", b / 5);
                }
            }
            Console.ReadKey();
        }
    }
}
