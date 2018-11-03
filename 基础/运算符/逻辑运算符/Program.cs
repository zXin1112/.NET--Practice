using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 逻辑运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //&& 逻辑与
            //||逻辑或
            //!逻辑非
            //逻辑表达式结果通常也是bool类型
            //让用户输入语文数学成绩，输出以下判断是否正确，正确输出TRUE，错误输出FALSE
            //数学语文成绩都大于90
            Console.WriteLine("输入你的语文成绩：");
            int chinese = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入你的数学成绩：");
            int math = Convert.ToInt32(Console.ReadLine());
            bool a = chinese > 90 && math > 90;
            //数学和语文有一门大于90
            bool b = chinese > 90 || math > 90;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
