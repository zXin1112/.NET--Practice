using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习__输入年龄判断
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入年龄若大于等于18，则告知可以查看，如果小于10则告知不可以查看
            //如果大于等于10且小于18，
            //则告知是否继续查看输入yes或者no判断，否则提示退出放弃查看
            Console.WriteLine("请输入你的年龄：");
            int  age =Convert .ToInt32 ( Console.ReadLine());
            if (age >=18)
            {
                Console.WriteLine("请查看:");
                Console .WriteLine ("老司机，鉴定完毕。");
            }
            else if (age >=10)
            {
                Console.WriteLine("小于18岁，是否继续查看？");
                Console.WriteLine("yes or no");
                string a = Console.ReadLine();
                if (a=="yes")
                {
                    Console.WriteLine("请查看：老司机，鉴定完毕。");
                    Console.WriteLine("老司机，鉴定完毕。");
                }
                else
                {
                    Console.WriteLine("退出，你放弃查看");
                }
            }
            else 
            {
                Console .WriteLine ("年龄太小，无法查看");
            }
            Console.ReadKey();
        }
    }
}
