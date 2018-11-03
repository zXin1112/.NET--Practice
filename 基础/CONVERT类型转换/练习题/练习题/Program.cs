using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习题
{
    class Program
    {
        static void Main(string[] args)
        {
           //让用户输入姓名 语文数学英语 三门课得成绩，然后给用户显示：xx，你的总成绩为xx分，平均成绩为xx分
            Console.WriteLine("请输入你的姓名：");
            string name = Console.ReadLine();
            Console.WriteLine("请输入你的语文成绩：");
            double  chinese =Convert .ToDouble ( Console.ReadLine());
            Console.WriteLine("请输入你的数学成绩：");
            double  math =Convert .ToDouble ( Console.ReadLine());
            Console.WriteLine("请输入你的英语成绩：");
            double english = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0}，你的总成绩为{1}分，平均成绩为{2}分", name, chinese + math + english, (chinese + math + english) / 3);
            Console.ReadKey();
        }
    }
}
