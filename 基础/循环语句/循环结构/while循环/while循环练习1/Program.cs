using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while循环练习1
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入班级人数，然后依次输入学员成绩，计算学员的平均成绩和总成绩
            int n = 1;
            int sum = 0;
            int chinese = 0;
            int math = 0;
            Console.WriteLine("请输入班级人数：");
            int a = Convert.ToInt32(Console.ReadLine());
            while (n <= a)
            {
                Console.WriteLine("请输入第{0}个学员数学成绩：", n);
                math = Convert.ToInt32(Console.ReadLine());
                sum += math;//累加成绩
                Console.WriteLine("请输入第{0}个学员语文成绩：", n);
                chinese = Convert.ToInt32(Console.ReadLine());
                sum += chinese;//累加成绩
                n++;//跳出循环的代码
            }
            Console.WriteLine("该学员的平均成绩为{0}，总成成绩为{1}", sum / 2, sum);
            Console.ReadKey();

        }
    }
}
