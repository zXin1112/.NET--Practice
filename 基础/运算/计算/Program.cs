using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算
{
    class Program
    {
        static void Main(string[] args)
        {
            //编程实现计算几天是几周零几天
            Console.WriteLine("请输入一个整数：");
            int t = Convert .ToInt32 (Console.ReadLine());
            int z = t / 7;
            int l = t % 7;
            Console.WriteLine("{0}天是{1}周零{2}天", t, z, l);
            Console.ReadKey();
            //编程实现107653秒是几天几小时几分钟几秒
            //int n = 107653;
            //int t = n / 86400;//求得天数
            //int h = n % 86400;//求得天数剩余的秒数
            //int hour = h / 3600;//求得小时数
            //int a = h % 3600;//求的小时数剩余的秒数
            //int m = a / 60;//求得分钟数
            //int s = a % 60;//求得分钟数剩余的秒数即几秒
            //Console.WriteLine("{0}秒是{1}天{2}小时{3}分钟{4}秒", n, t, hour, m, s);
            //Console.ReadKey();
        }
    }
}
