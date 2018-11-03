using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @if._._.else语句结构
{
    class Program
    {
        static void Main(string[] args)
        {
            //如果小赵的考试成绩大于等于90分则奖励
            //否则就惩罚他
            Console.WriteLine("请输入考试成绩：");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a>=90)
            {
                Console.WriteLine("奖励");

            }
            else
            {
                Console.WriteLine("惩罚");
            }
            Console.ReadKey();
        }
    }
}
