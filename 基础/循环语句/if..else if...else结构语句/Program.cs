using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @if._.else_if._._.else结构语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //对考生结业考试成绩评测
            //成绩90以上    A
            //成绩大于等于80小于90   B
            //成绩大于等于70小于80   C
            //成绩大于等于60小于70   D
            //成绩小于60    E
            Console.WriteLine("请输入成绩：");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a>=90)
            {
                Console.WriteLine("A");
            }
            else if (a>=80)
            {
                Console.WriteLine("B");
            }
            else if (a>=70)
            {
                Console.WriteLine("C");
            }
            else if (a>=60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("E");
            }
            Console.ReadKey();
        }
    }
}
