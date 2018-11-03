using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if语句结构
{
    class Program
    {
        static void Main(string[] args)
        {
            //语文成绩大于90且音乐成绩大于80
            //语文成绩等于100且音乐成绩大于70，则奖励100元
            Console.WriteLine("请输入你的语文成绩：");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入你的音乐成绩：");
            int m = Convert.ToInt32(Console.ReadLine());
            if ((c>90&&m>80)||(c==100&&m>70))
            {
                Console.WriteLine("奖励你100元");
            }
            Console.ReadKey();
        }
    }
}
